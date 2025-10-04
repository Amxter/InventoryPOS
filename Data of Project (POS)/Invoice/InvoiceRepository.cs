using DataOfProjectPOS.ProductDataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfProjectPOS
{
    namespace InvoiceDataModel
    {
        public class InvoiceInfo
        {

            public int InvoiceID { get; set; }
            public string InvoiceNumber { get; set; }
            public string ImagePath { get; set; }
            public int StatusID { get; set; }
            public int UserID { get; set; }
            public double TotalAmount { get; set; }
            public DateTime DateOfBuy { get; set; }

        }
        public class InvoiceRepository : IInvoiceRepository
        {

            public DataTable ListInvoice()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                        SELECT Invoice.InvoiceID , Invoice.InvoiceNumber , InvoiceStatus.StatusName ,  Users.FirstName + ' ' + Users.LastName  as NameCashier , Invoice.TotalAmount, Invoice.DateOfBuy
                     from Invoice INNER JOIN InvoiceStatus ON Invoice.InvoiceStatusID = InvoiceStatus.InvoiceStatusID
                     INNER JOIN Users ON Invoice.UserID = Users.UserID      ";


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
            public DataTable ListInvoiceByUserID(int userID, DateTime dateTimeStart, DateTime dateTimeEnd)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                        SELECT Invoice.InvoiceID , Invoice.InvoiceNumber , InvoiceStatus.StatusName ,  Users.FirstName + ' ' + Users.LastName  as NameCashier , Invoice.TotalAmount, Invoice.DateOfBuy
                     from Invoice INNER JOIN InvoiceStatus ON Invoice.InvoiceStatusID = InvoiceStatus.InvoiceStatusID
                     INNER JOIN Users ON Invoice.UserID = Users.UserID   
                   where Invoice.UserID = @userID and Invoice.DateOfBuy >= @dateTimeStart and Invoice.DateOfBuy <= @dateTimeEnd ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@dateTimeStart", dateTimeStart);
                        cmd.Parameters.AddWithValue("@dateTimeEnd", dateTimeEnd);
                        cmd.Parameters.AddWithValue("@userID", userID);


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
            public DataTable ListInvoiceByStatusID(int statusID, DateTime dateTimeStart, DateTime dateTimeEnd)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                        SELECT Invoice.InvoiceID , Invoice.InvoiceNumber , InvoiceStatus.StatusName ,  Users.FirstName + ' ' + Users.LastName  as NameCashier , Invoice.TotalAmount, Invoice.DateOfBuy
                     from Invoice INNER JOIN InvoiceStatus ON Invoice.InvoiceStatusID = InvoiceStatus.InvoiceStatusID
                     INNER JOIN Users ON Invoice.UserID = Users.UserID   
                   where InvoiceStatus.InvoiceStatusID = @statusID and Invoice.DateOfBuy >= @dateTimeStart and Invoice.DateOfBuy <= @dateTimeEnd ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@dateTimeStart", dateTimeStart);
                        cmd.Parameters.AddWithValue("@dateTimeEnd", dateTimeEnd);
                        cmd.Parameters.AddWithValue("@statusID", statusID);


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
            public DataTable ListInvoiceByInvoiceNumberID(string invoiceNumber, DateTime dateTimeStart, DateTime dateTimeEnd)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                        SELECT Invoice.InvoiceID , Invoice.InvoiceNumber , InvoiceStatus.StatusName ,  Users.FirstName + ' ' + Users.LastName  as NameCashier , Invoice.TotalAmount, Invoice.DateOfBuy
                     from Invoice INNER JOIN InvoiceStatus ON Invoice.InvoiceStatusID = InvoiceStatus.InvoiceStatusID
                     INNER JOIN Users ON Invoice.UserID = Users.UserID   
                   where Invoice.InvoiceNumber LIKE  @invoiceNumber and Invoice.DateOfBuy >= @dateTimeStart and Invoice.DateOfBuy <= @dateTimeEnd  ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@dateTimeStart", dateTimeStart);
                        cmd.Parameters.AddWithValue("@dateTimeEnd", dateTimeEnd);
                        cmd.Parameters.AddWithValue("@invoiceNumber", "%" + invoiceNumber + "%");


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
            public DataTable ListInvoiceByDate(DateTime dateTimeStart, DateTime dateTimeEnd)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                        SELECT Invoice.InvoiceID , Invoice.InvoiceNumber , InvoiceStatus.StatusName ,  Users.FirstName + ' ' + Users.LastName  as NameCashier , Invoice.TotalAmount, Invoice.DateOfBuy
                     from Invoice INNER JOIN InvoiceStatus ON Invoice.InvoiceStatusID = InvoiceStatus.InvoiceStatusID
                     INNER JOIN Users ON Invoice.UserID = Users.UserID   
                   where Invoice.DateOfBuy >= @dateTimeStart and Invoice.DateOfBuy   <= @dateTimeEnd   ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@dateTimeStart", dateTimeStart);
                        cmd.Parameters.AddWithValue("@dateTimeEnd", dateTimeEnd);



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

                    string query = @"INSERT INTO [dbo].[Invoice]
                            ([InvoiceNumber]
                            ,[InvoiceStatusID]
                            ,[UserID]
                            ,[TotalAmount]
                            ,[DateOfBuy])
                            VALUES
                      
                                  (   @InvoiceNumber , @StatusID  ,   @UserID , @TotalAmount, @DateOfBuy ) ; 
                      
                       Select SCOPE_IDENTITY() ; 
                         
                          ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceInfo.InvoiceNumber);
                        cmd.Parameters.AddWithValue("@StatusID", invoiceInfo.StatusID);

                        cmd.Parameters.AddWithValue("@UserID", invoiceInfo.UserID);
                        cmd.Parameters.AddWithValue("@TotalAmount", invoiceInfo.TotalAmount);

                        cmd.Parameters.AddWithValue("@DateOfBuy", invoiceInfo.DateOfBuy);


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
            public bool AddDetailsInvoice(int invoiceID, int productID, int quantity, double price)
            {
                bool isAdd = false;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"INSERT INTO [dbo].[InvoiceDetails]
                                  ([InvoiceID]
                                  ,[ProductID]
                                  ,[Quantity]
                                  ,[Price])
                            VALUES
 
                      
                                  (   @invoiceID , @productID  ,   @quantity , @price ) ; 
                      
                       Select SCOPE_IDENTITY() ; 
                         
                          ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                        cmd.Parameters.AddWithValue("@productID", productID);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@price", price);


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

                    string query = @"UPDATE [dbo].[Invoice]
                            SET [InvoiceNumber] =  @InvoiceNumber
                               ,[InvoiceStatusID] = @StatusID
                               ,[UserID] = @UserID
                               ,[TotalAmount] = @TotalAmount
                               ,[DateOfBuy] = @CostPrice
                          
                          WHERE  InvoiceID = @InvoiceID  ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceInfo.InvoiceNumber);
                        cmd.Parameters.AddWithValue("@StatusID", invoiceInfo.StatusID);
                        cmd.Parameters.AddWithValue("@UserID", invoiceInfo.UserID);
                        cmd.Parameters.AddWithValue("@TotalAmount", invoiceInfo.TotalAmount);
                        cmd.Parameters.AddWithValue("@CostPrice", invoiceInfo.DateOfBuy);
                        cmd.Parameters.AddWithValue("@InvoiceID", invoiceInfo.InvoiceID);

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
            public bool DeleteInvoiceDetailByID(int InvoiceDetailID)
            {
                bool isDelete = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM InvoiceDetails WHERE InvoiceDetailID = @InvoiceDetailID", conn, tran))
                            {
                                cmd.Parameters.Add("@InvoiceDetailID", SqlDbType.Int).Value = InvoiceDetailID;
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
            public bool DeleteInvoiceByID(int invoiceID)
            {
                bool isDelete = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM InvoiceDetails WHERE InvoiceID = @InvoiceID", conn, tran))
                            {
                                cmd.Parameters.Add("@InvoiceID", SqlDbType.Int).Value = invoiceID;
                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM Invoice WHERE InvoiceID = @InvoiceID", conn, tran))
                            {
                                cmd.Parameters.Add("@InvoiceID", SqlDbType.Int).Value = invoiceID;
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
            public DataTable ListDetailsInvoiceByInvoiceID(int InvoiceID)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                   SELECT InvoiceDetails.InvoiceDetailID, InvoiceDetails.ProductID, InvoiceDetails.Quantity, InvoiceDetails.Price
                   FROM     InvoiceDetails  
                   where InvoiceDetails.InvoiceID = @InvoiceID ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);



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
            public DataTable ListDetailsInfoInvoiceByInvoiceID(int InvoiceID)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                                SELECT  InvoiceDetails.InvoiceID ,InvoiceDetails.ProductID, Products.ProductName,  InvoiceDetails.Quantity, InvoiceDetails.Price
                                FROM     InvoiceDetails INNER JOIN
                                Products ON InvoiceDetails.ProductID = Products.ProductID
                                where InvoiceDetails.InvoiceID = @InvoiceID ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);



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
            public double ProfitCalculation(  DateTime dateTimeStart, DateTime dateTimeEnd)
            {


                double Profit = 0;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"SELECT Sum (InvoiceDetails.Quantity * (InvoiceDetails.Price - Products.CostPrice    )) 
                  FROM     Invoice INNER JOIN
                  InvoiceDetails ON Invoice.InvoiceID = InvoiceDetails.InvoiceID INNER JOIN
                  Products ON InvoiceDetails.ProductID = Products.ProductID
				  where   Invoice.DateOfBuy >= @dateTimeStart   and Invoice.DateOfBuy <= @dateTimeEnd  ";
                         
                         


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@dateTimeStart", dateTimeStart);
                        cmd.Parameters.AddWithValue("@dateTimeEnd", dateTimeEnd );
 
                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && double.TryParse(result.ToString(), out double profit))
                                Profit = profit ;



                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            Profit = 0;
                        }
                    }
                }

                return Profit ;
            }
            public double TotalSalesCalculation(DateTime dateTimeStart, DateTime dateTimeEnd)
            {


                double Profit = 0;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"SELECT Sum ( InvoiceDetails.Price * InvoiceDetails.Quantity ) 
                  FROM     Invoice INNER JOIN
                  InvoiceDetails ON Invoice.InvoiceID = InvoiceDetails.InvoiceID  
				  where   Invoice.DateOfBuy >= @dateTimeStart   and Invoice.DateOfBuy <= @dateTimeEnd  ";




                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@dateTimeStart", dateTimeStart);
                        cmd.Parameters.AddWithValue("@dateTimeEnd", dateTimeEnd);

                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && double.TryParse(result.ToString(), out double profit))
                                Profit = profit;



                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            Profit = 0;
                        }
                    }
                }

                return Profit;
            }
            public int TotalProductsSales(DateTime dateTimeStart, DateTime dateTimeEnd)
            {


                int Products = 0;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"SELECT Sum (InvoiceDetails.Quantity) 
                  FROM     Invoice INNER JOIN
                  InvoiceDetails ON Invoice.InvoiceID = InvoiceDetails.InvoiceID  
				  where   Invoice.DateOfBuy >= @dateTimeStart   and Invoice.DateOfBuy <= @dateTimeEnd";




                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@dateTimeStart", dateTimeStart);
                        cmd.Parameters.AddWithValue("@dateTimeEnd", dateTimeEnd);

                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int products ))
                                Products = products;



                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            Products = 0;
                        }
                    }
                }

                return Products;
            }
            public DataTable ListInfoTopOneUserSale(DateTime dateTimeStart, DateTime dateTimeEnd)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                                SELECT TOP 1
                                U.UserID,
                                U.FirstName,
                                U.LastName,
                                ISNULL(SUM(CAST(ID.Quantity AS DECIMAL(18,2)) * ID.Price), 0) AS TotalAmount,
                                ISNULL(SUM(ID.Quantity), 0)                                    AS QuantityProduct,
                                ISNULL(SUM(CAST(ID.Quantity AS DECIMAL(18,2)) * (ID.Price - P.CostPrice)), 0) AS Profit
                            FROM Products P
                            JOIN InvoiceDetails ID ON P.ProductID = ID.ProductID
                            JOIN Invoice I         ON ID.InvoiceID  = I.InvoiceID
                            JOIN Users U           ON I.UserID      = U.UserID
                            WHERE I.DateOfBuy BETWEEN @dateTimeStart AND @dateTimeEnd
                            GROUP BY U.UserID, U.FirstName, U.LastName
                            ORDER BY TotalAmount DESC; ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@dateTimeStart", dateTimeStart);
                        cmd.Parameters.AddWithValue("@dateTimeEnd", dateTimeEnd);
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


