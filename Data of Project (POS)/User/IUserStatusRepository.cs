using System.Data;

namespace DataOfProjectPOS
{



    namespace UserDataModels
    {
        public interface IUserStatusRepository {


            DataTable ListStatus();

            string GetStatusNameByStatusID(int userStatusesID);

        }
    }
 
}
