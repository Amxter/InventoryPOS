using POSLogic;
using POSLogic.LogicProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class UCCategoryProduct : UserControl
    {
        ICategorySarvice _categorySarvice;
        public enum Mode { Add, Update };
        Mode _Mode;
        int _ID;
        public UCCategoryProduct()
        {
            InitializeComponent();
            _categorySarvice = ServiceFactory.CreateCategoryService();
            LodeCategory();
        }

        private void LastColumnFill (DataGridView  dataGridView)
        {

            int lastColumnIndex = dataGridView.Columns.Count - 1;
            dataGridView.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCompany.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridViewCompany.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }
        private void LodeCategory()
        {
            dataGridViewCompany.DataSource = _categorySarvice.GetAllCategory();
            LastColumnFill(dataGridViewCompany);
        }
        private void InitializeAddMode()
        {
            labTital.Text = "Add";
            botAddOrUpdate.Text = "Add Category";
            txtName.Text = string.Empty;
            txtDiscrption.Text = string.Empty;
            _Mode = Mode.Add;
            panel1.Visible = true;
            Enable(false);

        }
        private void InitializeUpdateMode(DataRow dataRow)
        {
            labTital.Text = "Update";
            botAddOrUpdate.Text = "Update Category";
            txtName.Text = dataRow["CategoryName"].ToString();
            txtDiscrption.Text = dataRow["Description"].ToString();
            _ID = Convert.ToInt32(dataRow["CategoryID"]);
            panel1.Visible = true;
            _Mode = Mode.Update ;
            Enable(false);

        }
        private void Enable(bool enable)
        {
            dataGridViewCompany.Enabled = enable;
            groupBox1.Enabled = enable;
            textBox1.Enabled = enable;
            textBox1.Enabled = enable;

        }
        private bool ErrorProviderOfTextBox(TextBox button, string message)
        {


            if (string.IsNullOrWhiteSpace(button.Text))
            {

                errorProvider1.SetError(button, message);
                return false;
            }
            else
            {

                errorProvider1.SetError(button, "");
                return true;
            }
        }

        private void AddCategory()
        {


            if (ErrorProviderOfTextBox(txtName, "Name is required!"))
            {


                if (_categorySarvice.AddCategory(txtName.Text, txtDiscrption.Text) != -1)
                {
                    MessageBox.Show("Add Category is Successfully . ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LodeCategory();
                }
                else
                {
                    MessageBox.Show("Add Category is not Successfully . ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                panel1.Visible = false; 
            }




           

        }
        private void UpdateCategory(int categoryID)
        {
            if (ErrorProviderOfTextBox(txtName, "Name is required!"))

            {
                if (_categorySarvice.UpdateCategory(categoryID, txtName.Text, txtDiscrption.Text))
                {
                    MessageBox.Show("Update Category is Successfully . ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LodeCategory();
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Update Category is not Successfully . ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    panel1.Visible = false;
                }


               

            }

        }
        private void DeleteCategory()
        {

            DataRowView rowView = dataGridViewCompany.CurrentRow.DataBoundItem as DataRowView;

            int categoryID = Convert.ToInt32(rowView["CategoryID"]);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the Category with ID {categoryID}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {

                if (_categorySarvice.DeleteCategory(categoryID))
                {

                    LodeCategory();
                    MessageBox.Show("Category deleted is successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Category deleted is not successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        private void SendeEow()
        {

            if (dataGridViewCompany.CurrentRow != null)
            {
                DataRowView rowView = dataGridViewCompany.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    InitializeUpdateMode(rowView.Row);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCompany.DataSource = _categorySarvice.GetAllCategoryByName(textBox1.Text);
            LastColumnFill(dataGridViewCompany); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LodeCategory();
        }

        private void botAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (_Mode == Mode.Add)
            {
                AddCategory();
            }
            else if ( _Mode == Mode.Update )
            {
                UpdateCategory(_ID);

            }

            Enable (true ); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeAddMode();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            SendeEow();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendeEow(); 
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void ShowInfoCompany(DataRow dataRow)
        {

            labelName.Text = "Name : " + dataRow["CategoryName"].ToString();
            labelCompanyID.Text = "Category ID : " + dataRow["CategoryID"].ToString();
            labelDescription.Text = "Description : " + dataRow["Description"].ToString();

        }
   
        private void dataGridViewCompany_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompany.CurrentRow != null)
            {
                DataRowView rowView = dataGridViewCompany.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    ShowInfoCompany(rowView.Row);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Enable(true);
        }
    }
}
