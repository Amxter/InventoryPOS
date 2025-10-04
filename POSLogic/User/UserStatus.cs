using DataOfProjectPOS.UserDataModels;
using System.Data;

namespace POSLogic
{


    namespace LogicUser
    {
        public class UserStatus : IUserStatus 
        {
            private readonly IUserStatusRepository _repo;

            public UserStatus(IUserStatusRepository repo)
            {
                _repo = repo;
            }
            public DataTable GetStatus()
            {

                return _repo.ListStatus();

            }


            public string GetStatusNameByID(int StatusID)
            {

                return _repo.GetStatusNameByStatusID(StatusID);

            }
        }

    }

}
