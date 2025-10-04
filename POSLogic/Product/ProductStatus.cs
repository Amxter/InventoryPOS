using DataOfProjectPOS.ProductDataModel;
using System.Data;

namespace POSLogic
{

    namespace LogicProduct
    {
        public interface IStatus
        {
            DataTable GetStatus();
            string GetStatusNameByID(int StatusID);
        }
        public class Status : IStatus
        {
            IStatusRepository _statusRepository;


            public Status( StatusRepository statusRepository)
            {
                _statusRepository = statusRepository;
            }

            public DataTable GetStatus()
            {

                return _statusRepository.ListStatus();

            }


            public string GetStatusNameByID(int StatusID)
            {

                return _statusRepository.GetStatusNameByID(StatusID);

            }
        }

    }

}
