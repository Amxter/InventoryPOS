using System.Data;

namespace POSLogic
{


    namespace LogicUser
    {
        public interface IRoleService
        {

            DataTable GetAllRoles();
            string GetRoleByID(int RoleID);
        }

    }

}
