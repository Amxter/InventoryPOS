using System;
using System.Data;
using System.Data.SqlClient;

namespace DataOfProjectPOS
{



    namespace UserDataModels
    {
        public class UserStatusRepository : IUserStatusRepository 
        {

            public  DataTable ListStatus()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = " Select * from UserStatuses  ";



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

            public string GetStatusNameByStatusID(int statusID)
            {
                string statusName = null;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {
                    string query = @"SELECT StatusName
                         FROM UserStatuses
                         WHERE UserStatuseID = @UserStatuseID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserStatuseID", statusID);

                        try
                        {
                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    statusName = reader["StatusName"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                        }
                    }
                }

                return statusName;
            }


        }
    }
 
}
