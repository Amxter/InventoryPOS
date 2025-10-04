
using DataOfProjectPOS.InvoiceDataModel;
using System.Data;

namespace POSLogic
{
    namespace LogicInvoice
    {
        public class InvoiceStatus : IInvoiceStatus
        {
            
            IStatusInvoice _statusInvoice;
            public InvoiceStatus(StatusInvoice statusInvoice) 
            {

                _statusInvoice = statusInvoice;
            }

            public DataTable ListStatus ()
            {
                return _statusInvoice.ListStatus();
            }
        
        }


    }
}
