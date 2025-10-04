using System;
using System.ComponentModel;
using System.Diagnostics;
using static DataOfProjectPOS.ProductDataModel.ProductRepository;

namespace DataOfProjectPOS
{
    internal static class InfoContact
        {
            //  public static string ConnectionString = "Server=.;Database=InventoryManagement;Integrated Security=True;";
            public static string connectionString = "Server=.;Database=InventoryManagement;Integrated Security=True";

        }
    internal static class ExceptionLogger
    {

        private const string EventSource = "MyApp";
        private const string LogName = "Application";

        public static void Log(Exception ex)
        {
            try
            {
               
                if (!EventLog.SourceExists(EventSource))
                {
                    EventLog.CreateEventSource(EventSource, LogName);
                }

              
                EventLog.WriteEntry(EventSource, ex.ToString(), EventLogEntryType.Error);
            }
            catch
            {
                
                Console.WriteLine("Failed to write to event log.");
                Console.WriteLine(ex.ToString());
            }
        }


    }
 
}
