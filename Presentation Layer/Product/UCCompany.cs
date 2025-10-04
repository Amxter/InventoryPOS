using POSLogic;
using POSLogic.LogicProduct;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class UCCompany : UserControl
    {
        ICompanySarvice _ICompanySarvice;
        private void LastColumnFill(DataGridView dataGridView)
        {
            int lastColumnIndex = dataGridView.Columns.Count - 1;
            dataGridView.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCompany.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridViewCompany.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }
        private void LodeCompany()
        {
            dataGridViewCompany.DataSource = _ICompanySarvice.GetAllCompany();
            LastColumnFill(dataGridViewCompany);

        }
        public enum Mode { Add, Update };
        Mode _Mode;
        int _ID;
        public UCCompany()
        {
            InitializeComponent();
            _ICompanySarvice = ServiceFactory.CreateCompanyService();
            LodeCompany();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCompany.DataSource = _ICompanySarvice.GetAllCompanyByProductName(textBox1.Text);
            LastColumnFill(dataGridViewCompany);
        }
        private void ShowInfoCompany(DataRow dataRow)
        {

            labelName.Text = "Name: " + dataRow["CompanyName"].ToString();
            labelCompanyID.Text = "Company ID : " + dataRow["CompanyID"].ToString();
            labelPhone.Text = "Phone : " + dataRow["Phone"].ToString();
            labelAddress.Text = "Address : " + dataRow["Address"].ToString();


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
        private void button1_Click(object sender, EventArgs e)
        {
            LodeCompany();
        }

    
        private void InitializeAddMode()
        {
            labTital.Text = "Add";
            botAddOrUpdate.Text = "Add Company";
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtDiscrption.Text = string.Empty;
            maskedTextBoxPhone.Text = string.Empty;
            panel1.Visible = true;
            Enable(false);

        }
        private void InitializeUpdateMode(DataRow dataRow)
        {
            labTital.Text = "Update";
            botAddOrUpdate.Text = "Update Company";
            txtName.Text = dataRow["CompanyName"].ToString();
            txtAddress.Text = dataRow["Address"].ToString();
            txtDiscrption.Text = dataRow["Description"].ToString();
            maskedTextBoxPhone.Text = dataRow["Phone"].ToString();
            _ID = Convert.ToInt32(dataRow["CompanyID"]);
            panel1.Visible = true;
            Enable(false);

        }
        private void Enable(bool enable)
        {
            dataGridViewCompany.Enabled = enable;
            groupBox1.Enabled = enable;
            textBox1.Enabled = enable;
            textBox1.Enabled = enable;

        }
        private bool ErrorProviderOfTextBox(TextBox button, string Message)
        {


            if (string.IsNullOrWhiteSpace(button.Text))
            {

                errorProvider1.SetError(button, Message);
                return false;
            }
            else
            {

                errorProvider1.SetError(button, "");
                return true;
            }
        }
        private bool ErrorProviderOfTextBox(MaskedTextBox button, string Message)
        {


            if (string.IsNullOrWhiteSpace(button.Text))
            {

                errorProvider1.SetError(button, Message);
                return false;
            }
            else
            {

                errorProvider1.SetError(button, "");
                return true;
            }
        }
        private void AddCompany()
        {

            if (ErrorProviderOfTextBox(txtName, "Name is required!") &
                 ErrorProviderOfTextBox(txtAddress, "Address is required!") &
                 
                 ErrorProviderOfTextBox(maskedTextBoxPhone, "Phone is required!"))
            {


                if (_ICompanySarvice.AddCompany(txtName.Text, maskedTextBoxPhone.Text, txtAddress.Text, txtDiscrption.Text) != -1)
                {
                    MessageBox.Show("Add Company is Successfully . ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LodeCompany();
                }
                else
                {
                    MessageBox.Show("Add Company is not Successfully . ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    panel1.Visible = false; 
                }
            }



            

        }
        private void UpdateCompany(int CompanyID)
        {
            if (ErrorProviderOfTextBox(txtName, "Name is required!") &
              ErrorProviderOfTextBox(txtAddress, "Address is required!") &
              
              ErrorProviderOfTextBox(maskedTextBoxPhone, "Phone is required!"))
            {
                if (_ICompanySarvice.UpdateCompany(CompanyID, txtName.Text, maskedTextBoxPhone.Text, txtAddress.Text, txtDiscrption.Text))
                {
                    MessageBox.Show("Update Company is Successfully . ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LodeCompany();
                }
                else
                {
                    MessageBox.Show("Update Company is not Successfully . ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 panel1.Visible = false;
                }


               

            }

        }

        private void DeleteCompany()
        {

            DataRowView rowView = dataGridViewCompany.CurrentRow.DataBoundItem as DataRowView;

            int companyID = Convert.ToInt32(rowView["CompanyID"]);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the Company with ID {companyID}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {

                if (_ICompanySarvice.DeleteCompany(companyID))
                {

                    LodeCompany();
                    MessageBox.Show("Company deleted is successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Company deleted is not successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        private void botAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (_Mode == Mode.Add)
            {
                AddCompany();
            }
            else if (_Mode == Mode.Update)
            {
                UpdateCompany(_ID);

            }
            Enable(true);
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
        private void butUpdate_Click(object sender, EventArgs e)
        {
          _Mode = Mode.Update ;
            SendeEow();


        }


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Mode = Mode.Update; 
            SendeEow();
        }

    
        private void butCanncel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtDiscrption.Text = string.Empty;
            maskedTextBoxPhone.Text = string.Empty;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteCompany();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCompany();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Mode = Mode.Add ;
            InitializeAddMode();
        }

        private void UCCompany_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Enable(true);
            panel1.Visible = false ;
        }
    }

}
