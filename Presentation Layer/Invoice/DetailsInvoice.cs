using POSLogic;
using POSLogic.LogicInvoice;
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
using System.Xml.Linq;

namespace Project_Plint_of_Sale_System.Invoice
{
    public partial class DetailsInvoice : Form
    {

        int _invoiceID ;
      
        IInvoiceSarvice _invoiceSarvice;
        DataTable _dataTable1;
        private void LastColumnFill(DataGridView dataGridView)
        {
            int lastColumnIndex = dataGridView.Columns.Count - 1;
            dataGridView.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void GetAllInvoice()
        {
            DataTable dt = _invoiceSarvice.GetDetailsInvoiceByInvoiceID(_invoiceID);
            
            dataGridView1.DataSource = dt;
            LastColumnFill(dataGridView1);
        }
        public DetailsInvoice(DataRow dataRow )
        {
            
            InitializeComponent();
           
            _invoiceSarvice = ServiceFactory.CreateInvoiceService();
            Initialize(dataRow);
            GetAllInvoice();
        }
        public DetailsInvoice(DataTable dataRow)
        {

            InitializeComponent();
            _invoiceSarvice = ServiceFactory.CreateInvoiceService();
            _dataTable1 = dataRow;
            Initialize(dataRow);
              
        }

        private void Initialize(DataRow dataRow)
        {
            
           _invoiceID = Convert.ToInt32( dataRow["InvoiceID"]) ;
            labelInvoiceNumber.Text = "Invoice Number  : " + dataRow["InvoiceNumber"].ToString();
            labelStatus.Text = "Status : " + dataRow["StatusName"].ToString();
            labelName.Text = "Name Cashier : " + dataRow["NameCashier"].ToString();
            labelTotalAmount.Text = "Total Amount : " + _invoiceSarvice.SumColumn(_invoiceSarvice.GetDetailsInvoiceByInvoiceID(_invoiceID), "Price", "Quantity") ;
            labelDateOfBuy.Text = "Date Of Buy : " + dataRow["DateOfBuy"].ToString();
           
        }
        private void Initialize(DataTable dataTable)
        {

            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = dataTable;



            dataTable.Columns["SellingPrice"].ReadOnly = false;
            dataTable.Columns["Quantity"].ReadOnly = false;
 
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.ReadOnly = true;
            }
            dataGridView1.Columns["SellingPrice"].ReadOnly = false;  
            dataGridView1.Columns["Quantity"].ReadOnly = false;

            dataGridView1.DataSource=dataTable;
            
           
            labelInvoiceNumber.Text = "Invoice Number  : "  ;
            labelStatus.Text = "Status : "  ;
            CurrentUser currentUser = new CurrentUser();
            labelName.Text = "Name Cashier : " + currentUser.GetFirstName();
            labelTotalAmount.Text = "Total Amount : " + _invoiceSarvice.SumColumn(dataTable , "SellingPrice", "Quantity"  );
            labelDateOfBuy.Text = "Date Of Buy : " +DateTime.Now.ToString("dd/MM/yyyy HH:mm");





        }
        private void  LodeDetailsInvoice (int invoiceID)
        {
           

        }

        private void DetailsInvoice_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            object newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            _dataTable1.Rows[e.RowIndex][columnName] = newValue;
            labelTotalAmount.Text = "Total Amount : " + _invoiceSarvice.SumColumn(_dataTable1, "SellingPrice", "Quantity");

        }
    }
}
