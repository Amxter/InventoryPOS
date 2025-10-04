namespace POSLogic
{


    namespace LogicUser
    {
        public class CurrentUser
        {
            private  readonly  IUserStatus _repo ;
            private readonly IRoleService _roleService;
            public static DataOfProjectPOS.UserDataModels.UserInfo userInfo = new DataOfProjectPOS.UserDataModels.UserInfo();

            public CurrentUser()
            {
                _repo =  ServiceFactory.CreateUserStatusService();
                _roleService = ServiceFactory.CreateRoleService();
             }
            public string GetFirstName()
            {
                return userInfo.UserName;
            }

            public string GetStatusName()
            {
                return _repo.GetStatusNameByID(userInfo.StatusID);
            }
            public int GetUserID()
            {
                return userInfo.UserID ;
            }

            public  string GetRoleName()
            {
                  

                return _roleService.GetRoleByID(userInfo.RoleID);
            }

            public bool IsActive()
            {

                bool isActive = false;
                string statusName = _repo.GetStatusNameByID(userInfo.StatusID);
                if (statusName != null)
                {
                    if (statusName == "Active")
                        return true;
                }

                return isActive;

            }

        }
    }
}
