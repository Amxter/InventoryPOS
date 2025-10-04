using System;
using System.Data;
using System.Data.SqlClient;

namespace DataOfProjectPOS
{



    namespace UserDataModels
    {
        public class RoleRepository : IRoleRepository 
        {

            public   DataTable ListRole()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select * from Roles ";



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
                            dataTable = new DataTable()  ;
                            ExceptionLogger.Log(ex);
                        }
                    }
                }
                return dataTable;
            }
            public   string GetRoleNameByRoleID(int roleID)
            {


                string nameRole = null;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select * from Roles  Where RoleID = @RoleID  ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@RoleID", roleID);


                        try
                        {

                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    nameRole = reader["RoleName"].ToString();
                                }


                                else
                                {
                                    nameRole = null;

                                }




                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            nameRole = null;
                        }
                    }
                }

                return nameRole;
            }

        }
    }
 
}
