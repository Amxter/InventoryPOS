using DataOfProjectPOS.UserDataModels;
using System.Data;

namespace POSLogic
{


    namespace LogicUser
    {
        public class RoleService : IRoleService
        {
            private readonly IRoleRepository _role ;

            public RoleService(RoleRepository role)
            {


                _role = role ;
            }
            public  DataTable GetAllRoles()
            {

                return _role.ListRole();

            }



            public   string GetRoleByID(int RoleID)
            {

                return _role.GetRoleNameByRoleID(RoleID);

            }

        }

    }

}
