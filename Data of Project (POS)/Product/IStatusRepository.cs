using System.Data;

namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public interface IStatusRepository
        {
            DataTable ListStatus();
            string GetStatusNameByID(int StatusID);
        }
    }
 
}
