using POSLogic;
using POSLogic.LogicInvoice;
using POSLogic.LogicProduct;
using POSLogic.LogicUser;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System.User
{
    public partial class UCDashboardCashier : UserControl
    {
        IInvoiceSarvice _invoiceSarvice;
        IProductService _Product; 
        DataTable _dataTable;
        public UCDashboardCashier()
        {
            InitializeComponent();
            _invoiceSarvice = ServiceFactory.CreateInvoiceService();
            _Product = ServiceFactory.CreateProductService();
            GetAllInvoicesFromUser();
            ShowInfo();
        
        }
        private void LastColumnFill(DataGridView dataGridView)
        {
 
            int lastColumnIndex = dataGridView.Columns.Count - 1;
            dataGridView.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }
        private void GetAllInvoicesFromUser()
        {
            CurrentUser currentUser = new CurrentUser() ;
            _dataTable = _invoiceSarvice.GetInvoiceByUserID(currentUser.GetUserID(),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), DateTime.Now);

            dataGridView1.DataSource = _dataTable ;
        }
        private void ListNotifyIcon()
        {

            DataTable dataTable = _Product.GetAllProductByQuantityIs(10);

            if (dataTable.Rows.Count > 0)
            {
                string message = "";
                foreach (DataRow row in dataTable.Rows)
                {
                    string productId = row["ProductID"]?.ToString() ?? "Unknown";
                    string productName = row["ProductName"]?.ToString() ?? "Unknown";
                    message += $"ID:{productId} Name:{productName}\n";
                }

                if (message.Length > 250)
                    message = message.Substring(0, 247) + "...";

                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Low Stock Alert";
                notifyIcon1.BalloonTipText = message;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.ShowBalloonTip(10000);
            }

        }
        private void ShowInfo ()
        {
            label1.Text = "Number of invoices : " + _dataTable.Rows.Count;
            label3.Text = "Total Sales : " + _invoiceSarvice.SumColumn(_dataTable, "TotalAmount");
            double sum = 0;
            foreach (DataRow row in _dataTable.Rows)
            {
                sum += _invoiceSarvice.SumColumn(_invoiceSarvice.GetDetailsInfoInvoiceByInvoiceID(Convert.ToInt32(row["InvoiceID"])), "Quantity");
            }
            label2.Text = "Number of Products : " + sum ;

        }
        private void UCDashboardCashier_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            ListNotifyIcon();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
            LastColumnFill(dataGridView1);
        }
    }
}
