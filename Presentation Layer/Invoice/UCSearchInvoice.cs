using POSLogic;
using POSLogic.LogicInvoice;
using POSLogic.LogicProduct;
using POSLogic.LogicUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Project_Plint_of_Sale_System
{
    public partial class UCSearchInvoice : UserControl
    {
       
        enum enWaySearch { InvoiceNumber, DateInvoice, CashierName, Status }
        IUserService _userService ;
        IInvoiceSarvice _invoiceSarvice ;
        IInvoiceStatus _invoiceStatus ;
        private void LastColumnFill(DataGridView dataGridView)
        {
            int lastColumnIndex = dataGridView.Columns.Count - 1;
            dataGridView.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }
        private void GetAllInvoice()
        {
            DataTable dt = _invoiceSarvice.GetAllInvoice();
            Initialize(_invoiceSarvice.SumColumn(dt, "TotalAmount"), _invoiceSarvice.CountRow(dt));
            dataGridView1.DataSource = dt;
            LastColumnFill(dataGridView1);


        }
        public UCSearchInvoice()
        {
            InitializeComponent();
            _userService = ServiceFactory.CreateUserService();
            _invoiceSarvice = ServiceFactory.CreateInvoiceService();
            _invoiceStatus = ServiceFactory.CreateInvoiceStatus();
            GetAllInvoice();
           
             
        }

     

        enWaySearch _WaySearch;
 
        private void Initialize (double Total , int count  )
        {

            labelTotalAmount.Text = "Total Amount Invoices : " + Total;
            labelDateFirstInvoice.Text = "Date First Invoice : " + dateTimePickerFirstInvoise.Value.ToString("dd/MM/yyyy HH:mm");
            labelDateLastInvoice.Text = "Date Last Invoice : " +  dateTimePickerLastInvoise.Value.ToString("dd/MM/yyyy HH:mm");
            labelCauntInvoice.Text = "Count Invoice : " + count ;
        }

        private void SearchBy(string WaySearch)
        {


  
            textBox1.Visible = false ;

            if (WaySearch == "Invoice Number")
            {
                _WaySearch = enWaySearch.InvoiceNumber ;
                cbComponents.DataSource = _invoiceSarvice.GetAllInvoice();
                cbComponents.DisplayMember = "InvoiceNumber";
                cbComponents.ValueMember = "InvoiceID";
                textBox1.Visible = true;

            }
            else if (WaySearch == "Date Invoice")
            {
                _WaySearch = enWaySearch.DateInvoice;
                cbComponents.Visible   = false  ;
                

            }
            else if (WaySearch == "Cashier Name")
            {
                
                _WaySearch = enWaySearch.CashierName;
                cbComponents.DataSource = _userService.GetAllUsers();
                cbComponents.DisplayMember = "FirstName";
                cbComponents.ValueMember = "UserID";
                cbComponents.Visible = true;
            }
            else if (WaySearch == "Status")
            {
                _WaySearch = enWaySearch.Status;
                cbComponents.DataSource = _invoiceStatus.ListStatus();
                cbComponents.DisplayMember = "StatusName";
                cbComponents.ValueMember = "InvoiceStatusID";
                cbComponents.Visible = true;

            }

            butSearch.Visible = true;

        }
        private void SearchByInvoiceNumber(string InvoiceNumber, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            DataTable   dt = _invoiceSarvice.GetInvoiceByInvoiceNumberID(InvoiceNumber, dateTimeStart, dateTimeEnd);
            dataGridView1.DataSource = dt;
            Initialize(_invoiceSarvice.SumColumn(dt, "TotalAmount") , _invoiceSarvice.CountRow(dt));
            LastColumnFill(dataGridView1);
        }
        private void SearchByStatus(int StatusID, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            DataTable dt = _invoiceSarvice.GetInvoiceByStatusID(StatusID, dateTimeStart, dateTimeEnd);
            dataGridView1.DataSource = dt;
            Initialize(_invoiceSarvice.SumColumn(dt, "TotalAmount"), _invoiceSarvice.CountRow(dt));
            LastColumnFill(dataGridView1);

        }
        private void SearchByUserID(int UserID, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            DataTable dt = _invoiceSarvice.GetInvoiceByUserID(UserID, dateTimeStart, dateTimeEnd);
            dataGridView1.DataSource = dt;
            Initialize(_invoiceSarvice.SumColumn(dt, "TotalAmount"), _invoiceSarvice.CountRow(dt));
            LastColumnFill(dataGridView1);

        }
        private void SearchByDate(DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            DataTable dt = _invoiceSarvice.GetInvoiceByDate(dateTimeStart, dateTimeEnd);
            dataGridView1.DataSource = dt;
            Initialize(_invoiceSarvice.SumColumn(dt, "TotalAmount"), _invoiceSarvice.CountRow(dt));
            LastColumnFill(dataGridView1);

        }

        private void Search()
        {

            switch (_WaySearch)
            {
                case enWaySearch.InvoiceNumber :
                    SearchByInvoiceNumber(textBox1.Text , Convert.ToDateTime(dateTimePickerFirstInvoise.Text), Convert.ToDateTime(dateTimePickerLastInvoise.Text));
                    break;
                case enWaySearch.Status:
                    SearchByStatus(Convert.ToInt32(cbComponents.SelectedValue), Convert.ToDateTime(dateTimePickerFirstInvoise.Text), Convert.ToDateTime(dateTimePickerLastInvoise.Text));
                    break;
                case enWaySearch.CashierName:
                    SearchByUserID(Convert.ToInt32(cbComponents.SelectedValue), Convert.ToDateTime(dateTimePickerFirstInvoise.Text), Convert.ToDateTime(dateTimePickerLastInvoise.Text));
                    break;
                case enWaySearch.DateInvoice:
                    SearchByDate( Convert.ToDateTime( dateTimePickerFirstInvoise.Text ) , Convert.ToDateTime(dateTimePickerLastInvoise.Text));
                    break;


            }

        }

        private void cbSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SearchBy(cbSearch.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllInvoice();
        }

 
    }
}
