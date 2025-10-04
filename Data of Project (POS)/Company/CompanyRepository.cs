using System;
using System.Data;
using System.Data.SqlClient;

namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public class CompanyRepository : ICompanyRepository 
        {
            public DataTable ListCompany()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                                  SELECT [CompanyID]
                                        ,[CompanyName]
                                        ,[Phone]
                                        ,[Address]
                                        ,[Description]
                                    FROM [dbo].[Companies]";


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
            public int AddCompany(CompanyInfo companyInfo)
            {


                companyInfo.CompanyID = -1;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"INSERT INTO [dbo].[Companies]
           ([CompanyName]
           ,[Phone]
           ,[Address]
           ,[Description])
     VALUES
    
                   ( @CompanyName , @Phone, @Address ,  @Description  ) ; 

        Select SCOPE_IDENTITY() ; 

        ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@CompanyName", companyInfo.CompanyName);
                        cmd.Parameters.AddWithValue("@Phone", companyInfo.Phone);
                        

                        if (companyInfo.Description != null)
                            cmd.Parameters.AddWithValue("@Address", companyInfo.Address);
                        else
                            cmd.Parameters.AddWithValue("@Address", System.DBNull.Value);

                        if (companyInfo.Description != null)
                            cmd.Parameters.AddWithValue("@Description", companyInfo.Description);
                        else
                            cmd.Parameters.AddWithValue("@Description", System.DBNull.Value);




                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                                companyInfo.CompanyID = insertedID;



                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            companyInfo.CompanyID = -1;
                        }
                    }
                }

                return companyInfo.CompanyID;
            }
            public bool UpdateCompany(CompanyInfo companyInfo)
            {
                bool isUpdate = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"UPDATE [dbo].[Companies]
   SET [CompanyName] =  @CompanyName
      ,[Phone] = @Phone
      ,[Address] = @Address
      ,[Description] = @Description
 WHERE  CompanyID = @CompanyID";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CompanyID", companyInfo.CompanyID);
                        cmd.Parameters.AddWithValue("@CompanyName", companyInfo.CompanyName);
                        cmd.Parameters.AddWithValue("@Phone", companyInfo.Phone );


                        if (companyInfo.Description != null)
                            cmd.Parameters.AddWithValue("@Description", companyInfo.Description);
                        else
                            cmd.Parameters.AddWithValue("@Description", System.DBNull.Value);

                        if (companyInfo.Address != null)
                            cmd.Parameters.AddWithValue("@Address", companyInfo.Address);
                        else
                            cmd.Parameters.AddWithValue("@Address", System.DBNull.Value);

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
            public bool DeleteCompanyByID(int companyID)
            {
                bool isDelete = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"DELETE FROM  Companies 
              WHERE  CompanyID = @CompanyID";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CompanyID", companyID);
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
            public CompanyInfo GetCompanyByID(int companyID)
            {
                CompanyInfo category = null;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select * from Categories WHERE  CompanyID = @CompanyID";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@CompanyID", companyID);


                        try
                        {

                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    category = new CompanyInfo();

                                    category.CompanyID = Convert.ToInt32(reader["CategoryID"]);
                                    category.Description = reader["Description"].ToString();
                                    category.Phone = reader["Phone"].ToString();
                                    category.Address = reader["Address"].ToString();
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
            public DataTable ListCompanyByName(string companyName)
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                     SELECT [CompanyID]
                           ,[CompanyName]
                           ,[Phone]
                           ,[Address]
                           ,[Description]
                       FROM [dbo].[Companies]
                        where  CompanyName  LIKE  @companyName    ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@companyName", "%" + companyName + "%");



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
