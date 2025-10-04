using System;
using System.Data;
using System.Data.SqlClient;

namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public  class CategoryRepository : ICategoryRepository 
        {
            public  DataTable ListCategory()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
               SELECT [CategoryID]
      ,[CategoryName]
      ,[Description]
  FROM [dbo].[Categories]";


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
            public  int  AddCategory(CategoryInfo categoryInfo)
            {


                categoryInfo.CategoryID = -1;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" INSERT INTO [dbo].[Categories]
           ([CategoryName]
           ,[Description])
     VALUES
    
                   ( @CategoryName , @Description  ) ; 

        Select SCOPE_IDENTITY() ; 

        ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                         
                        cmd.Parameters.AddWithValue("@CategoryName", categoryInfo.CategoryName);
                        if (categoryInfo.Description != null)
                            cmd.Parameters.AddWithValue("@Description", categoryInfo.Description);
                        else
                            cmd.Parameters.AddWithValue("@Description", System.DBNull.Value);

 


                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                                categoryInfo.CategoryID = insertedID;



                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            categoryInfo.CategoryID = -1;
                        }
                    }
                }

                return categoryInfo.CategoryID;
            }
            public  bool UpdateCategory(CategoryInfo categoryInfo)
            {
                bool isUpdate = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"UPDATE [dbo].[Categories]
   SET [CategoryName] =  @CategoryName
      ,[Description] = @Description
 WHERE CategoryID = @CategoryID  ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryInfo.CategoryID );
                        cmd.Parameters.AddWithValue("@CategoryName", categoryInfo.CategoryName);
 
 
                        if (categoryInfo.Description != null)
                            cmd.Parameters.AddWithValue("@Description", categoryInfo.Description);
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
            public  bool DeleteCategoryByID(int categoryID)
            {
                bool isDelete = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"DELETE FROM  Categories 
              WHERE  CategoryID = @CategoryID";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);
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
            public  CategoryInfo GetCategoryByCategoryID(int categoryID)
            {
                CategoryInfo category = null;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select * from Categories WHERE  CategoryID = @CategoryID";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);


                        try
                        {

                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    category = new CategoryInfo();

                                    category.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                                    category.Description = reader["Description"].ToString();
                    

                                }


                                else
                                {
                                    category = null;

                                }




                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            category = null;
                        }
                    }
                }

                return category;
            }

            public DataTable ListCategoryByName(string categoryName)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
          SELECT  [CategoryID]
      ,[CategoryName]
      ,[Description]
  FROM [InventoryManagement].[dbo].[Categories]
                        where  CategoryName  LIKE  @categoryName    ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoryName", "%" + categoryName + "%");



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
