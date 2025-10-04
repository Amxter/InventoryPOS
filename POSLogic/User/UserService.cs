using DataOfProjectPOS.UserDataModels;
using System.Collections.Generic;
using System.Data;
using static DataOfProjectPOS.UserDataModels.UserRepository;

namespace POSLogic
{

    namespace LogicUser
    {


        public class UserService : IUserService
        {
 
            private readonly IUserRepository _repo;
 
            public UserService(IUserRepository repo)
            {
                _repo = repo;
            }
 
            private UserInfo ConvertToDataUser(UserModel model)
            {
                return new UserInfo
                {
                    UserID = model.UserID,
                    RoleID = model.RoleID,
                    StatusID = model.StatusID,
                    Email = model.Email,
                    Password = model.Password,
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    BirthDate = model.BirthDate
                };
            }

            private UserModel ConvertToUserModel(UserInfo dataUser)
            {
                if (dataUser == null) return null;

                return new UserModel
                {
                    UserID = dataUser.UserID,
                    RoleID = dataUser.RoleID,
                    StatusID = dataUser.StatusID,
                    Email = dataUser.Email,
                    Password = dataUser.Password,
                    UserName = dataUser.UserName,
                    FirstName = dataUser.FirstName,
                    LastName = dataUser.LastName,
                    BirthDate = dataUser.BirthDate
                };
            }
            public bool LoginUser(string username, string password)
            {
                var user = _repo.GetUserByUsername(username);
                if (user != null)
                {
                    if (PasswordHelper.VerifyPassword(password, user.Password))
                    {
                        CurrentUser.userInfo = user;
                        return true;
                    }

                }
                return false;
            }
            public int AddUser(UserModel userModel)
            {
                var dataUser = ConvertToDataUser(userModel);
                dataUser.Password = PasswordHelper.HashPassword(dataUser.Password);
                return _repo.AddUser(dataUser);
            }
            public bool UpdateUser(UserModel userModel)
            {
                var dataUser = ConvertToDataUser(userModel);
                dataUser.Password = PasswordHelper.HashPassword(dataUser.Password);
                return _repo.UpdateUser(dataUser);
            }
            public bool DeleteUser(int userId)
            {
                UserModel userModel = ConvertToUserModel(_repo.GetUserByUserID(userId) );
                userModel.StatusID = 6 ;
                return UpdateUser(userModel);
            }
            public bool IsUserExist(int userId)
            {
                return _repo.ExistUserByUserID(userId);
            }
            public bool CheckStatus(string status)
            {
                return status != null && status == "Active";
            }
            public bool UserNameIsExist(string userName)
            {
                var user = _repo.GetUserByUsername(userName);
                return user != null;
            }

            public UserModel GetUserByUserID(int UserID)
            {

                return ConvertToUserModel(_repo.GetUserByUserID(UserID));




            }
 
            public DataTable GetAllUsers()
            {
                var result = _repo.ListUsers();
                return result ?? new DataTable();
            }
        }
    }
}
