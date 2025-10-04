using POSLogic;
using POSLogic.LogicInvoice;
using POSLogic.LogicProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class UCDashboardAdmin : UserControl
    {
        IProductService _Product;
        IInvoiceSarvice _invoiceSarvice;
        public UCDashboardAdmin()
        {
            InitializeComponent();
            _invoiceSarvice = ServiceFactory.CreateInvoiceService();
            _Product = ServiceFactory.CreateProductService();
            ListNotifyIcon();
          


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowInfo(  double Profit,   double TotalSales,   int TotalProducts, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            labelTotalSales.Text = "Total Sales : " + TotalSales ;
            label1TotalNetProfit.Text = "Total Net Profit : " + Profit ;
            label1.Text = "Total Products Sales : " + TotalProducts;
            labelDataStartBox.Text = "Data Start : " + dateTimeStart.ToString() ;
            labelDataEndBox.Text= "Data End : " + dateTimeEnd.ToString() ;
    
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            double Profit = 0;   double TotalSales = 0; 
            int TotalProducts = 0; DateTime dateTimeStart = Convert.ToDateTime (dateTimePickerFirstInvoise.Text);
                DateTime dateTimeEnd = Convert.ToDateTime(dateTimePickerLastInvoise.Text);
            _invoiceSarvice.ProfitCalculation(ref Profit, ref TotalSales, ref TotalProducts, dateTimeStart, dateTimeEnd);

            ShowInfo(  Profit,   TotalSales,   TotalProducts,   dateTimeStart,  dateTimeEnd);


        }

        private void ListNotifyIcon ()
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


        private void ShowTopOneCashierOfMonth ()
        {

            DataTable dataTable = _invoiceSarvice.ListInfoTopOneUserSale(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), DateTime.Now);
            foreach (DataRow row in dataTable.Rows)
            {
                label13.Text = "Cashier Name : " + row["FirstName"].ToString() + " " + row["LastName"].ToString();
                label12.Text = "User ID : " + Convert.ToDouble(row["UserID"]);
                label10.Text = "Total Sales : " + Convert.ToDouble(row["TotalAmount"]);
                label11.Text = "Total Net Profit : " + Convert.ToDouble(row["Profit"]);
                label9.Text = "Total Products Sales : " + Convert.ToDouble(row["QuantityProduct"]);
            }
        }

        private void ShowTodaySales()
        {
            double Profit = 0;
            double TotalSales = 0;
            int TotalProducts = 0;
            DateTime dateTimeStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime dateTimeEnd = DateTime.Now;
            _invoiceSarvice.ProfitCalculation(ref Profit, ref TotalSales, ref TotalProducts, dateTimeStart, dateTimeEnd);
            labelSales.Text = "Sales : " + TotalSales;
            labelDayNetProfit.Text = "Net Profit : " + Profit;
            label2.Text = "Products Sales : " + TotalProducts;
        }
        private void ShowMonthSales()
        {
            double Profit = 0;
            double TotalSales = 0;
            int TotalProducts = 0;
            DateTime dateTimeStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime dateTimeEnd = DateTime.Now;
            _invoiceSarvice.ProfitCalculation(ref Profit, ref TotalSales, ref TotalProducts, dateTimeStart, dateTimeEnd);
            label6.Text = "Sales : " + TotalSales;
            label7.Text = "Net Profit : " + Profit;
            label5.Text = "Products Sales : " + TotalProducts;
        }

        private void UCDashboardAdmin_Load(object sender, EventArgs e)
        {


            ShowTodaySales();
            ShowMonthSales();


           
            ShowTopOneCashierOfMonth();
            butSearch.PerformClick();


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
 
