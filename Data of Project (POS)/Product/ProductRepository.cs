using System;
using System.Data;
using System.Data.SqlClient;

namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public class ProductRepository : IProductRepository 
        {
           
            public   DataTable ListProduct()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
               SELECT Products.ProductID , Products.ProductName, Companies.CompanyName, Categories.CategoryName, ProductStatuses.StatusName, Products.CostPrice, Products.SellingPrice, Products.Quantity, Products.Description, Products.Barcode , Products.ImagePath 
               FROM     Products INNER JOIN
                   
                  ProductStatuses ON Products.ProductStatuseID = ProductStatuses.ProductStatuseID INNER JOIN
                  Companies ON Products.CompanyID = Companies.CompanyID INNER JOIN
                  Categories ON Products.CategoryID = Categories.CategoryID";


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
            public   DataTable ListProductByCompanyID(int Quantity)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
               SELECT Products.ProductID , Products.ProductName, Companies.CompanyName, Categories.CategoryName, ProductStatuses.StatusName, Products.CostPrice, Products.SellingPrice, Products.Quantity, Products.Description, Products.Barcode , Products.ImagePath 
FROM     Products INNER JOIN
                   
                  ProductStatuses ON Products.ProductStatuseID = ProductStatuses.ProductStatuseID INNER JOIN
                  Companies ON Products.CompanyID = Companies.CompanyID INNER JOIN
                  Categories ON Products.CategoryID = Categories.CategoryID   
                   where Products.CompanyID = @companyID  ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@companyID", Quantity);


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
            public   DataTable ListProductByStatusID(int statusID)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
               SELECT Products.ProductID , Products.ProductName, Companies.CompanyName, Categories.CategoryName, ProductStatuses.StatusName, Products.CostPrice, Products.SellingPrice, Products.Quantity, Products.Description, Products.Barcode , Products.ImagePath 
FROM     Products INNER JOIN
                   
                  ProductStatuses ON Products.ProductStatuseID = ProductStatuses.ProductStatuseID INNER JOIN
                  Companies ON Products.CompanyID = Companies.CompanyID INNER JOIN
                  Categories ON Products.CategoryID = Categories.CategoryID   
                   where Products.ProductStatuseID = @statusID  ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
            public   DataTable ListProductByCategoryID(int categoryID)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
               SELECT Products.ProductID , Products.ProductName, Companies.CompanyName, Categories.CategoryName, ProductStatuses.StatusName, Products.CostPrice,  Products.SellingPrice,Products.Quantity, Products.Description, Products.Barcode , Products.ImagePath 
FROM     Products INNER JOIN
                   
                  ProductStatuses ON Products.ProductStatuseID = ProductStatuses.ProductStatuseID INNER JOIN
                  Companies ON Products.CompanyID = Companies.CompanyID INNER JOIN
                  Categories ON Products.CategoryID = Categories.CategoryID   
                   where Products.CategoryID = @categoryID  ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoryID", categoryID);


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
            public   DataTable ListProductByName(string productName)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
               SELECT Products.ProductID , Products.ProductName, Companies.CompanyName, Categories.CategoryName, ProductStatuses.StatusName, Products.CostPrice, Products.SellingPrice, Products.Quantity, Products.Description, Products.Barcode , Products.ImagePath 
FROM     Products INNER JOIN
                   
                  ProductStatuses ON Products.ProductStatuseID = ProductStatuses.ProductStatuseID INNER JOIN
                  Companies ON Products.CompanyID = Companies.CompanyID INNER JOIN
                  Categories ON Products.CategoryID = Categories.CategoryID   
                   where Products.ProductName LIKE  @productName   ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productName", "%" + productName + "%");



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
            public   int AddProduct(ProductInfo productInfo)
            {


                productInfo.ProductID = -1;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"INSERT INTO [dbo].[Products]
           ([CategoryID]
           ,[CompanyID]
           ,[ProductStatuseID]
           ,[ProductName]
           ,[Description]
           ,[SellingPrice]
           ,[CostPrice]
           ,[Quantity]
           ,[Barcode]
           ,[ImagePath])
     VALUES
                   (   @CategoryID , @CompanyID  ,   @ProductStatuseID , @ProductName, @Description , @SellingPrice ,  @CostPrice ,   @Quantity ,   @Barcode , @ImagePath  ) ; 

        Select SCOPE_IDENTITY() ; 

        ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

              
                        cmd.Parameters.AddWithValue("@CompanyID", productInfo.CompanyID);
                        cmd.Parameters.AddWithValue("@CategoryID", productInfo.CategoryID);
                        cmd.Parameters.AddWithValue("@ProductStatuseID", productInfo.StatusID);
                        cmd.Parameters.AddWithValue("@ProductName", productInfo.ProductName);
                        cmd.Parameters.AddWithValue("@SellingPrice", productInfo.SellingPrice);
                        cmd.Parameters.AddWithValue("@CostPrice", productInfo.CostPrice);
                        cmd.Parameters.AddWithValue("@Quantity", productInfo.Quantity);
                        cmd.Parameters.AddWithValue("@Barcode", productInfo.Barcode);

                        if (!string.IsNullOrWhiteSpace(productInfo.ImagePath))
                            cmd.Parameters.AddWithValue("@ImagePath", productInfo.ImagePath);
                        else
                            cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                        if (productInfo.Description != "")
                            cmd.Parameters.AddWithValue("@Description", productInfo.Description);
                        else
                            cmd.Parameters.AddWithValue("@Description", System.DBNull.Value);


                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                                productInfo.ProductID = insertedID;



                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            productInfo.ProductID = -1;
                        }
                    }
                }

                return productInfo.ProductID;
            }
            public   bool UpdateProduct(ProductInfo productInfo)
            {
                bool isUpdate = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"UPDATE [dbo].[Products]
   SET [CategoryID] = @CategoryID
      ,[CompanyID] =  @CompanyID
      
      ,[ProductStatuseID] = @ProductStatuseID
      ,[ProductName] = @ProductName
      ,[Description] = @Description
      ,[SellingPrice] = @sellingPrice
      ,[CostPrice] = @CostPrice
      ,[Quantity] = @Quantity
      ,[Barcode] = @Barcode
,[ImagePath] =  @ImagePath
 WHERE  ProductID = @ProductID  ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productInfo.ProductID);
                        cmd.Parameters.AddWithValue("@CompanyID", productInfo.CompanyID);
                        cmd.Parameters.AddWithValue("@CategoryID", productInfo.CategoryID);

                        cmd.Parameters.AddWithValue("@ProductStatuseID", productInfo.StatusID);
                        cmd.Parameters.AddWithValue("@ProductName", productInfo.ProductName);
                         
                        cmd.Parameters.AddWithValue("@sellingPrice", productInfo.SellingPrice);
                        cmd.Parameters.AddWithValue("@CostPrice", productInfo.CostPrice);
                        cmd.Parameters.AddWithValue("@Quantity", productInfo.Quantity);
                        cmd.Parameters.AddWithValue("@Barcode", productInfo.Barcode);

                        if (!string.IsNullOrEmpty(productInfo.ImagePath))
                            cmd.Parameters.AddWithValue("@ImagePath", productInfo.ImagePath);
                        else
                            cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                        if (!string.IsNullOrEmpty(productInfo.Description))
                            cmd.Parameters.AddWithValue("@Description", productInfo.Description);
                        else
                            cmd.Parameters.AddWithValue("@Description", System.DBNull.Value);

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
            public   bool DeleteProductByID(int productID)
            {
                bool isDelete = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"DELETE FROM  Products 
              WHERE  ProductID = @ProductID";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        try
                        {
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result != 0)
                                isDelete = true;

                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            isDelete = false;
                        }
                    }
                }

                return isDelete;
            }
            public  ProductInfo GetProductByProductID(int productID)
            {
                ProductInfo product = null;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select * from Products WHERE  ProductID = @ProductID";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@ProductID", productID);


                        try
                        {

                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    product = new ProductInfo();

                                    product.ProductID = Convert.ToInt32(reader["ProductID"]);
                                    product.CompanyID = Convert.ToInt32(reader["CompanyID"]);
                                    product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                                
                                    product.StatusID = Convert.ToInt32(reader["ProductStatuseID"]);
                                    product.ProductName = reader["ProductName"].ToString();
                                  
                                    product.CostPrice = Convert.ToDouble(reader["CostPrice"]);
                                    product.SellingPrice = Convert.ToDouble(reader["SellingPrice"]);
                                    product.Quantity = Convert.ToInt32(reader["Quantity"]);
                                    product.Barcode = reader["Barcode"].ToString();


                                    if (reader["ImagePath"] != System.DBNull.Value)
                                        product.ImagePath =  reader["ImagePath"].ToString() ;
                                    else
                                        product.ImagePath = "";

                                    if (reader["Description"] != System.DBNull.Value)
                                        product.Description = reader["Description"].ToString();
                                    else
                                        product.Description = "";

                                }


                                else
                                {
                                    
                                    product = null;

                                }




                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            product = null;
                        }
                    }
                }

                return product;
            }
            public DataTable ListProductByQuantityIs(int Quantity)
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                          SELECT Products.ProductID, Companies.CompanyName, Products.ProductName, Products.CostPrice, Products.Quantity
                          FROM     Products INNER JOIN
                          Companies ON Products.CompanyID = Companies.CompanyID
				          where    Products.Quantity <= @Quantity ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", Quantity);


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
