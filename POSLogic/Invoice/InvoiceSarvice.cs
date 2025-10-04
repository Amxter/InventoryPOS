
using DataOfProjectPOS.InvoiceDataModel;
using DataOfProjectPOS.ProductDataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLogic
{
    namespace LogicInvoice
    {



        public class InvoiceSarvice : IInvoiceSarvice
        {
            IInvoiceRepository _invoice;
            ProductRepository _productRepository = new ProductRepository() ;

            public InvoiceSarvice(InvoiceRepository invoiceRepository)
            {
                _invoice = invoiceRepository;
            }

            private DataOfProjectPOS.InvoiceDataModel.InvoiceInfo ConvertParametartoClass(int InvoiceID,
                string InvoiceNumber, int StatusID, int UserID,
                double TotalAmount, DateTime DateOfBuy)
            {
                DataOfProjectPOS.InvoiceDataModel.InvoiceInfo InvoiceInfo = new DataOfProjectPOS.InvoiceDataModel.InvoiceInfo();
                InvoiceInfo.InvoiceID = InvoiceID;
                InvoiceInfo.InvoiceNumber = InvoiceNumber;
                InvoiceInfo.StatusID = StatusID;
                InvoiceInfo.UserID = UserID;
                InvoiceInfo.TotalAmount = TotalAmount;
                InvoiceInfo.DateOfBuy = DateOfBuy;


                return InvoiceInfo;

            }
            private void AddDetails(int InvoiceID, DataTable InvoiceTable)
            {
                foreach (DataRow row in InvoiceTable.Rows)
                {
                    _invoice.AddDetailsInvoice(InvoiceID, Convert.ToInt32(row["ProductID"]), Convert.ToInt32(row["Quantity"]), Convert.ToDouble(row["SellingPrice"]));
                    UpdateQuantity(Convert.ToInt32(row["ProductID"]), -1 * Convert.ToInt32(row["Quantity"]) );
                }
            }
            private void UpdateQuantity (int ProductID , int Quantity)
            {

                ProductInfo productInfo = new ProductInfo();
                productInfo = _productRepository.GetProductByProductID(ProductID);
                productInfo.Quantity += Quantity;
                _productRepository.UpdateProduct(productInfo);


            }
            
            private void DeleteInvoiceDetailByID(int InvoiceDetailID )
            {
                _invoice.DeleteInvoiceDetailByID(InvoiceDetailID);
            }

            public int AddInvoice(string InvoiceNumber, int StatusID, int UserID,
                double TotalAmount, DateTime DateOfBuy, DataTable InvoiceTable)
            {
                int id = _invoice.AddInvoice(ConvertParametartoClass(-1,
                  InvoiceNumber, StatusID, UserID, TotalAmount, DateOfBuy));
                if (id != -1)
                {
                    AddDetails(id, InvoiceTable);
                }

                _invoice.UpdateInvoice(ConvertParametartoClass(id,
                  "INV-"+ (1000+id), StatusID, UserID, TotalAmount, DateOfBuy));


                return id;

            }
            public bool UpdateInvoice(int InvoiceID, string InvoiceNumber, int StatusID, int UserID,
            double TotalAmount, DateTime DateOfBuy , DataTable InvoiceTable )
            {
                bool inUpdate = _invoice.UpdateInvoice(ConvertParametartoClass(InvoiceID,
                  InvoiceNumber, StatusID, UserID, TotalAmount, DateOfBuy));

                if (inUpdate)
                {
                    DataTable dataTable = _invoice.ListDetailsInvoiceByInvoiceID(InvoiceID);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        UpdateQuantity(Convert.ToInt32(row["ProductID"]), Convert.ToInt32(row["Quantity"]));
                        DeleteInvoiceDetailByID( Convert.ToInt32(row["InvoiceDetailID"]));
                    }

                    AddDetails(  InvoiceID,   InvoiceTable);
                }


                return inUpdate;

            }

 
            public bool DeleteInvoice(int InvoiceID)
            {
                DataTable dataTable = _invoice.ListDetailsInvoiceByInvoiceID(InvoiceID);
                bool isDelete = _invoice.DeleteInvoiceByID(InvoiceID);

                if (isDelete)
                {
               
                    foreach (DataRow row in dataTable.Rows)
                    {
                        UpdateQuantity(Convert.ToInt32(row["ProductID"]), Convert.ToInt32(row["Quantity"]));
                    }
                }
                return isDelete ;
            }


            public DataTable GetAllInvoice()
            {

                return _invoice.ListInvoice();

            }
            public DataTable GetInvoiceByDate(DateTime dateTimeStart, DateTime dateTimeEnd)
            {
                return _invoice.ListInvoiceByDate(dateTimeStart, dateTimeEnd);
            }
            public DataTable GetInvoiceByInvoiceNumberID(string invoiceNumber, DateTime dateTimeStart, DateTime dateTimeEnd)
            {
                return _invoice.ListInvoiceByInvoiceNumberID(invoiceNumber, dateTimeStart, dateTimeEnd);
            }
            public DataTable GetInvoiceByStatusID(int statusID, DateTime dateTimeStart, DateTime dateTimeEnd)
            {
                return _invoice.ListInvoiceByStatusID(statusID, dateTimeStart, dateTimeEnd);
            }
            public DataTable GetInvoiceByUserID(int userID, DateTime dateTimeStart, DateTime dateTimeEnd)
            {
                return _invoice.ListInvoiceByUserID(userID, dateTimeStart, dateTimeEnd);
            }
            public DataTable GetDetailsInvoiceByInvoiceID(int InvoiceID)
            {

                return _invoice.ListDetailsInfoInvoiceByInvoiceID(InvoiceID);
            }

            public DataTable GetDetailsInfoInvoiceByInvoiceID(int InvoiceID)
            {

                return _invoice.ListDetailsInfoInvoiceByInvoiceID(InvoiceID);
            }

            public double SumColumn(DataTable dataTable, string nameColumn)
            {
                double sum = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    sum += Convert.ToDouble(row[nameColumn]);
                }


                return sum;

            }

            public double SumColumn(DataTable dataTable, string nameColumn, string Quantity)
            {
                double sum = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    sum += Convert.ToDouble(row[nameColumn]) * Convert.ToDouble(row[Quantity]);
                }


                return sum;

            }
            public int CountRow(DataTable dataTable)
            {
                int count = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    count++;
                }


                return count;

            }

            public double SumColumn(DataTable dataTable)
            {
                throw new NotImplementedException();
            }
            public void ProfitCalculation(ref double Profit, ref double TotalSales, ref int TotalProducts, DateTime dateTimeStart, DateTime dateTimeEnd)
            {
                Profit = _invoice.ProfitCalculation(dateTimeStart, dateTimeEnd);
                TotalSales = _invoice.TotalSalesCalculation(dateTimeStart, dateTimeEnd );
                TotalProducts = _invoice.TotalProductsSales(dateTimeStart, dateTimeEnd);
            }

            public DataTable ListInfoTopOneUserSale(DateTime dateTimeStart, DateTime dateTimeEnd)
            {
                return _invoice.ListInfoTopOneUserSale(dateTimeStart, dateTimeEnd);
            }


        }


    }
}
