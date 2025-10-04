using System.Data;

namespace DataOfProjectPOS.UserDataModels
{

 
        public interface IUserRepository
        {
            int AddUser(UserInfo user);
            bool UpdateUser(UserInfo user);
            bool DeleteUserByID(int userID);
            bool ExistUserByUserID(int userID);
            UserInfo GetUserByUserID(int userID);
            UserInfo GetUserByUsername(string userName);
            DataTable ListUsers();
        }

     
}