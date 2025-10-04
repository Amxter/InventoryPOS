using System;
using System.Data;

namespace DataOfProjectPOS
{
    namespace InvoiceDataModel
    {
        public interface IInvoiceRepository
        {
            DataTable ListInvoice();
            //   ProductInfo GetProductByProductID(int invoiceID);
            bool AddDetailsInvoice(int invoiceID, int productID, int quantity, double price);
            int AddInvoice(InvoiceInfo invoiceInfo);
            bool UpdateInvoice(InvoiceInfo invoiceInfo);
            bool DeleteInvoiceByID(int invoiceID);
            bool DeleteInvoiceDetailByID(int InvoiceDetailID);
            DataTable ListDetailsInvoiceByInvoiceID(int InvoiceID);
            DataTable ListDetailsInfoInvoiceByInvoiceID(int InvoiceID);
            DataTable ListInvoiceByDate(DateTime dateTimeStart, DateTime dateTimeEnd);
            DataTable ListInvoiceByInvoiceNumberID(string invoiceNumber , DateTime dateTimeStart, DateTime dateTimeEnd);
            DataTable ListInvoiceByStatusID(int statusID , DateTime dateTimeStart, DateTime dateTimeEnd);
            DataTable ListInvoiceByUserID(int userID, DateTime dateTimeStart, DateTime dateTimeEnd);

            double ProfitCalculation(DateTime dateTimeStart, DateTime dateTimeEnd);
            int TotalProductsSales(DateTime dateTimeStart, DateTime dateTimeEnd);
            double TotalSalesCalculation(DateTime dateTimeStart, DateTime dateTimeEnd);
            DataTable ListInfoTopOneUserSale(DateTime dateTimeStart, DateTime dateTimeEnd);




        }



    }

}


