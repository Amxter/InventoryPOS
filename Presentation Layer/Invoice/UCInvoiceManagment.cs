using POSLogic;
using POSLogic.LogicInvoice;
using Project_Plint_of_Sale_System.Invoice;
using Project_Plint_of_Sale_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class UCInvoiceManagement : UserControl
    {

        IInvoiceSarvice _invoiceSarvice;
        public UCInvoiceManagement()
        {
            _invoiceSarvice = ServiceFactory.CreateInvoiceService();

            InitializeComponent();
            GetAllInvoice();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }
        private void LastColumnFill(DataGridView dataGridView)
        {
            int lastColumnIndex = dataGridView.Columns.Count - 1;
            dataGridView.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void GetAllInvoice()
        {
            dataGridView1.DataSource = _invoiceSarvice.GetAllInvoice();
            LastColumnFill(dataGridView1);
        }
        private void ShowInfoCompany(DataRow dataRow)
        {

            labelName.Text = "Name Cashier : " + dataRow["NameCashier"].ToString();
            labelInvoiceNumber.Text = "Invoice Number : " + dataRow["InvoiceNumber"].ToString();
            labelStatus.Text = "Status : " + dataRow["StatusName"].ToString();
            labelDateOfBuy.Text = "Date Of Buy : " + dataRow["DateOfBuy"].ToString();
            labelTotalAmount.Text = "Total Amount : " + dataRow["TotalAmount"].ToString();


        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    ShowInfoCompany(rowView.Row);
                }
            }
        }
        private void butSearch_Click(object sender, EventArgs e)
        {



            SearchInvoice searchInvoice = new SearchInvoice();
            searchInvoice.ShowDialog();

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                GetAllInvoice();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                //UCSearchInvoice ucAddUser = new UCSearchInvoice( );
                //ucAddUser.Dock = DockStyle.Fill;
                //panel1.Controls.Add(ucAddUser);
                //ucAddUser.BringToFront();
            }
            else if (tabControl1.SelectedIndex == 2)
            {






            }
        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DetailsInvoice detailsInvoice = new DetailsInvoice(rowView.Row);
                    detailsInvoice.ShowDialog();
                    GetAllInvoice();

                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddInvoice addInvoice = new AddInvoice();
            addInvoice.ShowDialog();
            GetAllInvoice();
        }
        private void ShowInfoUser(DataRow dataRow)
        {

            labelInvoiceNumber.Text = "Invoice Number: " + dataRow["InvoiceNumber"].ToString();
            labelTotalAmount.Text = "Total Amount :" + dataRow["TotalAmount"].ToString();
            labelStatus.Text = "Status : " + dataRow["StatusName"].ToString();
            labelName.Text = "Name Cashier : " + dataRow["NameCashier"].ToString();
            labelDateOfBuy.Text = "Date Of Buy : " + dataRow["DateOfBuy"].ToString();
        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    ShowInfoUser(rowView.Row);
                }

            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (rowView != null)
            {
                _invoiceSarvice.DeleteInvoice(Convert.ToInt32(rowView.Row["InvoiceID"]));
                GetAllInvoice();
                MessageBox.Show("Delete is Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete is not Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (rowView != null)
            {
                AddInvoice addInvoice = new AddInvoice(Convert.ToInt32(rowView.Row["InvoiceID"]),  rowView.Row["StatusName"].ToString() , rowView.Row["InvoiceNumber"].ToString());
                addInvoice.ShowDialog();
                GetAllInvoice();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (rowView != null)
            {
                AddInvoice addInvoice = new AddInvoice(Convert.ToInt32(rowView.Row["InvoiceID"]), rowView.Row["StatusName"].ToString(), rowView.Row["InvoiceNumber"].ToString());
                addInvoice.ShowDialog();
                GetAllInvoice();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (rowView != null)
            {
                _invoiceSarvice.DeleteInvoice(Convert.ToInt32(rowView.Row["InvoiceID"]));
                GetAllInvoice();
                MessageBox.Show("Delete is Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete is not Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

