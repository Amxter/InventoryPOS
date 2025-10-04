using System.Data;

namespace POSLogic
{


    namespace LogicUser
    {
        public interface IUserService
        {
            bool LoginUser(string username, string password);
            int AddUser(UserModel user);
            bool UpdateUser(UserModel user);
            bool DeleteUser(int userId);
            bool IsUserExist(int userId);
            bool UserNameIsExist(string username);
            UserModel GetUserByUserID(int UserID); 
            bool CheckStatus(string status);
            DataTable GetAllUsers();
        }
    }
}

