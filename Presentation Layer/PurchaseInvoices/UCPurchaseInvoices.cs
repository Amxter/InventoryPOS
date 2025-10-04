using POSLogic;
using POSLogic.LogicProduct;
using POSLogic.LogicPurchaseInvoice;
using Project_Plint_of_Sale_System.PurchaseInvoices;
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
    public partial class UCPurchaseInvoices : UserControl
    {

        IPurchaseInvoiceService _PurchaseInvoiceService;
        private void LastColumnFill(DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count == 0)
                return;

            int lastColumnIndex = dataGridView.Columns.Count - 1;
            dataGridView.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }
        private void GetAllInvoice()
        {
            dataGridView1.DataSource = _PurchaseInvoiceService.ListInvoice();
            LastColumnFill(dataGridView1);
        }
        public UCPurchaseInvoices()
        {
            InitializeComponent();
            _PurchaseInvoiceService = ServiceFactory.CreatePurchaseInvoiceService();
            GetAllInvoice();
        }

        private void ShowInfo(DataRow row)
        {
            labelInvoiceID.Text = "Invoices ID : " + row["PurchaseInvoicesID"].ToString();
            labelName.Text = "Cashier :" + row["Cashier"].ToString();
            labelSypplierName.Text = "Supplier Name : " + row["SupplierName"].ToString();
            labelTotalAmount.Text = "Total Amount : " + row["TotalAmount"].ToString();
            labelDateOfPurchase.Text = "Date Of Purchase : " + row["DateOfPurchase"].ToString();


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    ShowInfo(rowView.Row);
                }
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DetailsInvoicePurchase d = new DetailsInvoicePurchase(Convert.ToInt32(rowView["PurchaseInvoicesID"]));
                    d.ShowDialog();

                }
            }

        }

        private void butDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {

                    if (_PurchaseInvoiceService.DeleteInvoice(Convert.ToInt32(rowView["PurchaseInvoicesID"])) )
                    {
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {

                    if (_PurchaseInvoiceService.DeleteInvoice(Convert.ToInt32(rowView["PurchaseInvoicesID"])))
                    {
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

        private void button1_Click(object sender, EventArgs e)
        {

            AddAndUpdatePurchaseInvoices add = new AddAndUpdatePurchaseInvoices();
            add.ShowDialog();
            GetAllInvoice();

        }
    }
}
