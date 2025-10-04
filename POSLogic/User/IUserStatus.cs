using System.Data;

namespace POSLogic
{


    namespace LogicUser
    {
        public interface IUserStatus
        {
            DataTable GetStatus();
            string GetStatusNameByID(int statusID);

        }

    }

}
