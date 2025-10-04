using System;

namespace DataOfProjectPOS.UserDataModels



{
    public class UserInfo
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int StatusID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }


}

