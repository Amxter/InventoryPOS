using POSLogic;
using POSLogic.LogicPurchaseInvoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System.PurchaseInvoices
{
    public partial class DetailsInvoicePurchase : Form
    {
        int ID =-1;
        IPurchaseInvoiceService _PurchaseInvoiceService;
        private void ShowInfo (DataRow dataRow)
        {
      
           labelCompanyName.Text = "Company Name : " + dataRow["CompanyName"].ToString();
            labelProductName.Text = "Product Name : " + dataRow["ProductName"].ToString();
            labelCostPrice.Text = "Cost Price : " + dataRow["CostPrice"].ToString();
            labelPriceAtPurchase.Text = "Price At Purchase : " + dataRow["PriceAtPurchase"].ToString();
            labelPurchaseDetailID.Text = "Purchase Detail ID : " + dataRow["PurchaseDetailID"].ToString();
            labelQuantity.Text = "Quantity : " + dataRow["Quantity"].ToString();
            labelSellingPrice.Text = "Selling Price : " + dataRow["SellingPrice"].ToString();
        }
        public DetailsInvoicePurchase(int PurchaseInvoicesID)
        {
            InitializeComponent();
            _PurchaseInvoiceService = ServiceFactory.CreatePurchaseInvoiceService();
            dataGridView1.DataSource = _PurchaseInvoiceService.ListDetailsInvoiceByPurchaseInvoiceID(PurchaseInvoicesID);
            ID = PurchaseInvoicesID;
        }

        public DetailsInvoicePurchase(DataTable data)
        {

            InitializeComponent();
            _PurchaseInvoiceService = ServiceFactory.CreatePurchaseInvoiceService();
          
            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = data;
            data.Columns["PriceAtPurchase"].ReadOnly = false;
            data.Columns["Quantity"].ReadOnly = false;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.ReadOnly = true;
            }
            dataGridView1.Columns["PriceAtPurchase"].ReadOnly = false;
            dataGridView1.Columns["Quantity"].ReadOnly = false;

            groupBox2.Visible = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null & ID != -1 )
                {
                    ShowInfo(rowView.Row);
                }
            }
        }

        private void DetailsInvoicePurchase_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;




        }

 
    }
}
