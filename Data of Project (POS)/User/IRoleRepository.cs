using System.Data;

namespace DataOfProjectPOS
{



    namespace UserDataModels
    {
        public interface IRoleRepository
        {
            DataTable ListRole();
            string GetRoleNameByRoleID(int roleID);

        }
    }
 
}
