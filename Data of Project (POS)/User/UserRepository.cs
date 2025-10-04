using System;
using System.Data;
using System.Data.SqlClient;
using static DataOfProjectPOS.UserDataModels.UserRepository;

namespace DataOfProjectPOS
{

    namespace UserDataModels
    {
        public partial class UserRepository : IUserRepository
        {
            public int AddUser(UserInfo userInfo)
            {


                userInfo.UserID = -1;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"INSERT INTO [dbo].[Users]
           ([RoleID]
           ,[UserStatusID]
           ,[UserName]
           ,[Email]
           ,[Password]
           ,[FirstName]
           ,[LastName]
           ,[BirthDate])
     VALUES
                   ( @RoleID , @UserStatusID , @UserName ,  @Email , @Password, @FirstName ,  @LastName ,   @DateOfBirth  ) ; 

        Select SCOPE_IDENTITY() ; 

        ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@RoleID", userInfo.RoleID);
                        cmd.Parameters.AddWithValue("@UserStatusID", userInfo.StatusID);
                        cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
                        cmd.Parameters.AddWithValue("@Email", userInfo.Email);
                        cmd.Parameters.AddWithValue("@Password", userInfo.Password);
                        cmd.Parameters.AddWithValue("@FirstName", userInfo.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", userInfo.LastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", userInfo.BirthDate);



                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                                userInfo.UserID = insertedID;



                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            userInfo.UserID = -1;
                        }
                    }
                }

                return userInfo.UserID;
            }
            public bool DeleteUserByID(int userID)
            {
                bool isDelete = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"DELETE FROM  Users  WHERE  UserID = @UserID ";
              
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        try
                        {
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result != 0)
                                isDelete = true;

                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            isDelete = false;
                        }
                    }
                }

                return isDelete;
            }
            public bool ExistUserByUserID(int userID)
            {


                bool isFind = false;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select x = 1 from Users  Where UserID = @UserID";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        try
                        {
                            conn.Open();
                            object reader = cmd.ExecuteScalar();



                            if (reader != null)
                            {
                                isFind = true;
                            }
                            else
                            {
                                isFind = false;

                            }




                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            isFind = false;
                        }
                    }
                }
                return isFind;
            }
            public UserInfo GetUserByUserID(int userID)
            {



                UserInfo user = null;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select * from Users  Where UserID = @UserID ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@UserID", userID);


                        try
                        {

                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    user = new UserInfo();

                                    user.UserID = Convert.ToInt32(reader["UserID"]);
                                    user.RoleID = Convert.ToInt32(reader["RoleID"]);
                                    user.StatusID = Convert.ToInt32(reader["UserStatusID"]);
                                    user.Email = reader["Email"].ToString();
                                    user.Password = reader["Password"].ToString();
                                    user.UserName = reader["UserName"].ToString();
                                    user.FirstName = reader["FirstName"].ToString();
                                    user.LastName = reader["LastName"].ToString();
                                    user.BirthDate = Convert.ToDateTime(reader["BirthDate"]);

                                }


                                else
                                {

                                    user = null;

                                }




                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            user = null;
                        }
                    }
                }

                return user;
            }
            public UserInfo GetUserByUsername(string userName)
            {



                UserInfo user = null;

                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = "Select * from Users  Where UserName = @UserName ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@UserName", userName);


                        try
                        {

                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    user = new UserInfo();

                                    user.UserID = Convert.ToInt32(reader["UserID"]);
                                    user.RoleID = Convert.ToInt32(reader["RoleID"]);
                                    user.StatusID = Convert.ToInt32(reader["UserStatusID"]);
                                    user.Email = reader["Email"].ToString();
                                    user.Password = reader["Password"].ToString();
                                    user.UserName = reader["UserName"].ToString();
                                    user.FirstName = reader["FirstName"].ToString();
                                    user.LastName = reader["LastName"].ToString();
                                    user.BirthDate = Convert.ToDateTime(reader["BirthDate"]);

                                }


                                else
                                {
                                    user = null;

                                }




                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            user = null;
                        }
                    }
                }

                return user;
            }
            public DataTable ListUsers()
            {


                DataTable dataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @" 
                SELECT Users.UserID, Users.FirstName, Users.LastName, Users.UserName,   Roles.RoleName, UserStatuses.StatusName, Users.Email,    DATEDIFF (year ,  Users.BirthDate , GETDATE() ) as Age 
                   FROM     Users INNER JOIN
                  UserStatuses ON Users.UserStatusID = UserStatuses.UserStatuseID INNER JOIN
                  Roles ON Users.RoleID = Roles.RoleID ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {


                        try
                        {

                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                dataTable.Load(reader);
                            }
                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            dataTable = new DataTable();

                        }
                    }
                }
                return dataTable;
            }
            public bool UpdateUser(UserInfo userInfo)
            {
                bool IsUpdate = false;
                using (SqlConnection conn = new SqlConnection(InfoContact.connectionString))
                {

                    string query = @"UPDATE [dbo].[Users]
   SET [RoleID] = @RoleID
      ,[UserStatusID] = @UserStatusID
      ,[UserName] = @UserName
      ,[Email] = @Email
      ,[Password] = @Password
      ,[FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[BirthDate] = @DateOfBirth
 WHERE  UserID = @UserID ";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userInfo.UserID);
                        cmd.Parameters.AddWithValue("@RoleID", userInfo.RoleID);
                        cmd.Parameters.AddWithValue("@UserStatusID", userInfo.StatusID);
                        cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
                        cmd.Parameters.AddWithValue("@Email", userInfo.Email);
                        cmd.Parameters.AddWithValue("@Password", userInfo.Password);
                        cmd.Parameters.AddWithValue("@FirstName", userInfo.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", userInfo.LastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", userInfo.BirthDate);



                        try
                        {
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result != 0)
                                IsUpdate = true;

                        }
                        catch (Exception ex)
                        {
                            ExceptionLogger.Log(ex);
                            IsUpdate = false;
                        }
                    }
                }

                return IsUpdate;
            }


        }

    }
}