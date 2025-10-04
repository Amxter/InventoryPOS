using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfProjectPOS
{
    namespace PurchaseInvoiceDataModel
    {
        public class InvoiceInfo
        {

            public int InvoiceID { get; set; }
            public int SupplierID { get; set; }
            public int UserID { get; set; }
            public double TotalAmount { get; set; }
            public DateTime DateOfPurchase { get; set; }

        }

        public interface IPurchaseInvoiceRepository
        {

            DataTable ListInvoice();
            DataTable ListSupplier();
            int AddInvoice(InvoiceInfo invoiceInfo);
            bool AddDetailsInvoice(int PurchaseInvoiceID, int productID, int quantity, double PriceAtPurchase);
            bool UpdateInvoice(InvoiceInfo invoiceInfo);
            bool DeleteInvoiceDetailByID(int InvoiceDetailID);
            bool DeleteInvoiceByID(int InvoiceDetailID);
            DataTable ListDetailsInvoiceByPurchaseInvoiceID(int PurchaseInvoiceID);
        }

        public class PurchaseInvoiceRepository : IPurchaseInvoiceRepository 
        {
            public DataTable ListInvoice()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                   SELECT PurchaseInvoices.PurchaseInvoicesID, Suppliers.SupplierName, Users.FirstName  +' '+ Users.LastName as  Cashier  , PurchaseInvoices.DateOfPurchase, PurchaseInvoices.TotalAmount
                   FROM     Suppliers INNER JOIN
                  PurchaseInvoices ON Suppliers.SupplierID = PurchaseInvoices.SupplierID INNER JOIN
                  Users ON PurchaseInvoices.UserID = Users.UserID     ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        try
                        {

                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                dataTable.Load(reader);
                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            dataTable = null;
                        }
                    }
                }
                return dataTable;
            }
            public int AddInvoice(InvoiceInfo invoiceInfo)
            {


                invoiceInfo.InvoiceID = -1;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"INSERT INTO [dbo].[PurchaseInvoices]
                            ([SupplierID]
                            ,[UserID]
                            ,[DateOfPurchase]
                            ,[TotalAmount])
                      VALUES
                      
                                  (   @SupplierID , @UserID  ,   @DateOfPurchase , @TotalAmount ) ; 
                      
                       Select SCOPE_IDENTITY() ; 
                         
                          ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@SupplierID", invoiceInfo.SupplierID);
                        cmd.Parameters.AddWithValue("@UserID", invoiceInfo.UserID);
                        cmd.Parameters.AddWithValue("@TotalAmount", invoiceInfo.TotalAmount);
                        cmd.Parameters.AddWithValue("@DateOfPurchase", invoiceInfo.DateOfPurchase);


                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                                invoiceInfo.InvoiceID = insertedID;



                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            invoiceInfo.InvoiceID = -1;
                        }
                    }
                }

                return invoiceInfo.InvoiceID;
            }
            public bool AddDetailsInvoice(int PurchaseInvoiceID, int productID, int quantity, double PriceAtPurchase)
            {
                bool isAdd = false;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"INSERT INTO [dbo].[PurchaseInvoiceDetails]
                             ([PurchaseInvoiceID]
                             ,[ProductID]
                             ,[Quantity]
                             ,[PriceAtPurchase])
                       VALUES
                      
                                  (   @PurchaseInvoiceID , @ProductID  ,   @quantity , @PriceAtPurchase ) ; 
                      
                       Select SCOPE_IDENTITY() ; 
                         
                          ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@PurchaseInvoiceID", PurchaseInvoiceID);
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@PriceAtPurchase", PriceAtPurchase);


                        try
                        {
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result != 0)
                                isAdd = true;
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            isAdd = false;
                        }
                    }
                }

                return isAdd;
            }
            public bool UpdateInvoice(InvoiceInfo invoiceInfo)
            {
                bool isUpdate = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"[dbo].[PurchaseInvoices]
                            SET [SupplierID]      =  @SupplierID
                               ,[UserID]          =  @UserID
                               ,[DateOfPurchase]  = @DateOfPurchase
                               ,[TotalAmount]     = @TotalAmount
               
                          WHERE  PurchaseInvoicesID = @PurchaseInvoicesID  ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", invoiceInfo.SupplierID);
                        cmd.Parameters.AddWithValue("@DateOfPurchase", invoiceInfo.DateOfPurchase);
                        cmd.Parameters.AddWithValue("@UserID", invoiceInfo.UserID);
                        cmd.Parameters.AddWithValue("@TotalAmount", invoiceInfo.TotalAmount);
                        cmd.Parameters.AddWithValue("@PurchaseInvoicesID", invoiceInfo.InvoiceID);

                        try
                        {
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result != 0)
                                isUpdate = true;

                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            isUpdate = false;
                        }
                    }
                }

                return isUpdate;
            }
            public bool DeleteInvoiceDetailByID(int PurchaseInvoiceID)
            {
                bool isDelete = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM PurchaseInvoiceDetails WHERE PurchaseInvoiceID = @PurchaseInvoiceID", conn, tran))
                            {
                                cmd.Parameters.Add("@PurchaseInvoiceID", SqlDbType.Int).Value = PurchaseInvoiceID;
                                cmd.ExecuteNonQuery();
                                isDelete = true;
                            }



                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            ExceptionLogger.Log(ex);
                            isDelete = false;
                        }
                    }
                }


                return isDelete;
            }
            public bool DeleteInvoiceByID(int PurchaseInvoiceID)
            {
                bool isDelete = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {

                            if (DeleteInvoiceDetailByID(PurchaseInvoiceID))
                            { 
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM PurchaseInvoices WHERE PurchaseInvoicesID = @PurchaseInvoicesID", conn, tran))
                            {
                                cmd.Parameters.Add("@PurchaseInvoicesID", SqlDbType.Int).Value = PurchaseInvoiceID;
                                cmd.ExecuteNonQuery();
                                isDelete = true;
                            }

                            }
                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            ExceptionLogger.Log(ex);
                            isDelete = false;
                        }
                    }
                }


                return isDelete;
            }
            public DataTable ListDetailsInvoiceByPurchaseInvoiceID(int PurchaseInvoiceID)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                  SELECT PurchaseInvoiceDetails.PurchaseDetailID,PurchaseInvoiceDetails.ProductID , Products.ProductName, Companies.CompanyName, Products.CostPrice, Products.SellingPrice, PurchaseInvoiceDetails.Quantity, PurchaseInvoiceDetails.PriceAtPurchase
                  FROM     PurchaseInvoiceDetails INNER JOIN
                  Products ON PurchaseInvoiceDetails.ProductID = Products.ProductID INNER JOIN
                  Companies ON Products.CompanyID = Companies.CompanyID
                  where PurchaseInvoiceDetails.PurchaseInvoiceID = @PurchaseInvoiceID ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@PurchaseInvoiceID", PurchaseInvoiceID);



                        try
                        {

                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                dataTable.Load(reader);
                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            dataTable = null;
                        }
                    }
                }
                return dataTable;
            }

            public DataTable ListSupplier()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"SELECT * FROM [InventoryManagement].[dbo].[Suppliers]" ;
 


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        try
                        {

                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                dataTable.Load(reader);
                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            dataTable = null;
                        }
                    }
                }
                return dataTable;
            }

        }
    } 
}
 
