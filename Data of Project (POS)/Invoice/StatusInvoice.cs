using DataOfProjectPOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfProjectPOS
{
    namespace InvoiceDataModel
    {
        public class StatusInvoice : IStatusInvoice 
        {
            public DataTable ListStatus()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = " Select * from InvoiceStatus  ";



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
