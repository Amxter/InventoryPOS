using POSLogic;
using POSLogic.LogicProduct;
using POSLogic.LogicPurchaseInvoice;
using POSLogic.LogicUser;
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
    public partial class AddAndUpdatePurchaseInvoices : Form
    {
        DataTable _InvoiceTable;

        IPurchaseInvoiceService _PurchaseInvoiceService;
        IProductService _productService; 
        private void GetAllProduct ()
        {
            dataGridView1.DataSource = _productService.GetAllProduct();
           
        }
        public AddAndUpdatePurchaseInvoices()
        {
            InitializeComponent();
            _PurchaseInvoiceService = ServiceFactory.CreatePurchaseInvoiceService();
            _productService = ServiceFactory.CreateProductService();
            _InvoiceTable = new DataTable();
            GetAllProduct();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;


                AddorUpdateData addorUpdateData = new AddorUpdateData(rowView.Row, _InvoiceTable);
                addorUpdateData.ShowDialog();

                label2.Text = "$" + TotalPrice().ToString() ;
                //    foreach (DataRow dataRow in _InvoiceTable.Rows)
                //    {
                //        if (rowView.Row["ProductID"].ToString() == dataRow["ProductID"].ToString())
                //        {
                //            if ((Convert.ToInt32(dataRow["Quantity"]) + 1) <= Convert.ToInt32(rowView["Quantity"]))
                //            {
                //                dataRow["Quantity"] = (Convert.ToInt32(dataRow["Quantity"]) + 1).ToString();
                //                label2.Text = "$" + TotalPrice().ToString();
                //                return;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This product is out of stock");
                //            }
                //        }
                //    }
                //    if (rowView != null)
                //    {
                //        if (1 <= Convert.ToInt32(rowView["Quantity"]))
                //        {

                //            _InvoiceTable.Rows.Add(rowView.Row["ProductID"],
                //            rowView.Row["ProductName"],
                //            rowView.Row["SellingPrice"], 1);

                //        }
                //        else
                //        {
                //            MessageBox.Show("This product is out of stock");
                //        }


                //    }
                //}
                //label2.Text = "$" + TotalPrice().ToString();
            }
        }
        private void AddAndUpdatePurchaseInvoices_Load(object sender, EventArgs e)
        {
            _InvoiceTable.Columns.Add("ProductID");
            _InvoiceTable.Columns.Add("ProductName");
            _InvoiceTable.Columns.Add("PriceAtPurchase");
            _InvoiceTable.Columns.Add("Quantity");
            cbSupplierName.DataSource = _PurchaseInvoiceService.ListSupplier();
            cbSupplierName.DisplayMember = "SupplierName";
            cbSupplierName.ValueMember = "SupplierID";

            panel1.Controls.Add(new UCSearchProduct(dataGridView1));
        }
        private double TotalPrice()
        {

            double total = 0;

            foreach (DataRow row in _InvoiceTable.Rows)
            {
                total += Convert.ToDouble(row["PriceAtPurchase"]);
            }

            return total;
        }
        private void botAddorUpdateUser_Click(object sender, EventArgs e)
        {
            CurrentUser currentUser = new CurrentUser();
            if (_PurchaseInvoiceService.AddInvoice(Convert.ToInt32(cbSupplierName.SelectedValue), currentUser.GetUserID(), TotalPrice(), DateTime.Now, _InvoiceTable) != -1 )
            {
                MessageBox.Show("Add is Successfully ");
                
            }
            else
            {
                MessageBox.Show("Add is not Successfully ");

            }

            this.Close();
        }
        private void linkLabelShowDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailsInvoicePurchase detailsInvoicePurchase = new DetailsInvoicePurchase(_InvoiceTable);
            detailsInvoicePurchase.ShowDialog();
            label2.Text = "$" + TotalPrice().ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _InvoiceTable.Clear();
        }
    }
}