using System;
using System.Data;

namespace POSLogic
{
    namespace LogicInvoice
    {
        public interface IInvoiceSarvice
        {
            int AddInvoice(string InvoiceNumber, int StatusID, int UserID,
                double TotalAmount, DateTime DateOfBuy, DataTable InvoiceTable );
            bool UpdateInvoice(int InvoiceID, string InvoiceNumber, int StatusID, int UserID,
                 double TotalAmount, DateTime DateOfBuy, DataTable InvoiceTable);
            bool DeleteInvoice(int InvoiceID);
            DataTable GetAllInvoice();
            DataTable GetDetailsInvoiceByInvoiceID(int InvoiceID);
            DataTable GetDetailsInfoInvoiceByInvoiceID(int InvoiceID);
            DataTable GetInvoiceByDate(DateTime dateTimeStart, DateTime dateTimeEnd);
            DataTable GetInvoiceByInvoiceNumberID(string invoiceNumber, DateTime dateTimeStart, DateTime dateTimeEnd);
            DataTable GetInvoiceByStatusID(int statusID, DateTime dateTimeStart, DateTime dateTimeEnd);
            DataTable GetInvoiceByUserID(int userID, DateTime dateTimeStart, DateTime dateTimeEnd);
            double SumColumn(DataTable dataTable, string v);
            double SumColumn(DataTable dataTable, string v , string Quantity);
            int CountRow(DataTable dataTable);
            void ProfitCalculation(ref double Profit, ref double TotalSales, ref int TotalProducts, DateTime dateTimeStart, DateTime dateTimeEnd);
            DataTable ListInfoTopOneUserSale(DateTime dateTimeStart, DateTime dateTimeEnd);
        }


    }
}
