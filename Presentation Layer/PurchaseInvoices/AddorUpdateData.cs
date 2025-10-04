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
    public partial class AddorUpdateData : Form
    {
        
        IPurchaseInvoiceService _PurchaseInvoiceService;
        DataTable _InvoiceTable ; 
        int IDProduct;
        string ProductName;
        private void ShowInfo (DataRow row)
        {
            IDProduct = Convert.ToInt32(row["ProductID"]);
            ProductName = row["ProductName"].ToString();
            labProductName.Text = "Product Name : " + row["ProductName"].ToString();
            labCompany.Text = "Company   : " + row["CompanyName"].ToString();
            labCategory.Text = "Category   : " + row["CategoryName"].ToString();
            labelSellingPrice.Text = "Selling Price   : " + row["SellingPrice"].ToString();
            labelCostPrice.Text = "Cost Price   : " + row["CostPrice"].ToString();
            labQuantity.Text = "Quantity   : " + row["Quantity"].ToString();
           
          
        }
        public AddorUpdateData(DataRow row, DataTable  InvoiceTable  )
        {
            InitializeComponent();
            _PurchaseInvoiceService = ServiceFactory.CreatePurchaseInvoiceService();
            ShowInfo(row);
            _InvoiceTable = InvoiceTable ;
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
        
        private void butUpdate_Click(object sender, EventArgs e)
        {
            int Quantity = 0 ;
            double PriceAtPurchase = 0 ;
            try
            {
                  Quantity = Convert.ToInt32(txtOrderQuantity.Text);
                PriceAtPurchase = Convert.ToDouble(txtPriceAtPurchase.Text);
            }
            catch (Exception ex)
            {

                txtOrderQuantity.Text = "";
                txtPriceAtPurchase.Text = "";
            }
             

            if (ErrorProviderOfTextBox(txtOrderQuantity, "" )  &
                ErrorProviderOfTextBox(txtPriceAtPurchase, ""))

            {

                _InvoiceTable.Rows.Add(IDProduct ,ProductName , PriceAtPurchase , Quantity);


                MessageBox.Show("Save is successfully ", "Save");
                this.Close();

            }
            else
            {

                MessageBox.Show("Save is not successfully ", "Save");
            }
        }
    }
}
