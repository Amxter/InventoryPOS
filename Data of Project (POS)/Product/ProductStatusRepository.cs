using System;
using System.Data;
using System.Data.SqlClient;

namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public class StatusRepository : IStatusRepository 
        {
            public   DataTable ListStatus()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = " Select * from ProductStatuses  ";



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
            public   string GetStatusNameByID(int StatusID)
            {


                string statusName = null;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select * from ProductStatuses  Where ProductStatuseID = @StatusID  ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@StatusID", StatusID);


                        try
                        {

                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    statusName = reader["StatusName"].ToString();
                                }


                                else
                                {
                                    statusName = null;

                                }




                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            statusName = null;
                        }
                    }
                }

                return statusName;
            }

        }
    }
 
}
