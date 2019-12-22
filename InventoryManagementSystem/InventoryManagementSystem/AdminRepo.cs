using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class AdminRepo
    {
        public static DataAccess DataAccess;
        public AdminRepo()
        {
            if (DataAccess == null)
            {
                DataAccess = new DataAccess();
            }
        }

        public int UpdateAdminPass(string id, string newPass)
        {
            String _insertQuery = "UPDATE users SET password=@newPass WHERE Id=@id";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@newPass", newPass);
            cmd.Parameters.AddWithValue("@id", id);
            return DataAccess.ExecuteNonQuery(cmd);
        }



        public int UpdateSalesman(int id, string FullName, string UserName, string Password, string Email, string PhoneNumber, string Address, DateTime DateOfBirth, string hobbies, string gender, string imagePath)
        {
            String _insertQuery =
                "UPDATE StudentInfo SET FullName=@FullName,Username=@Username,Password=@Password,Email=@Email,Phone=@Phone,Address=@Address,DateOfBirth=@DateOfBirth,Gender=@Gender,Hobbies=@Hobbies,imageLocation=@imageLocation) WHERE id=@id";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@FullName", FullName);
            cmd.Parameters.AddWithValue("@Username", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@imageLocation", imagePath);
            cmd.Parameters.AddWithValue("@Hobbies", hobbies);
            cmd.Parameters.AddWithValue("@Gender", gender);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public DataTable GetAdminByID(string username, string password)
        {
            String query = "select Id, name from users where username=@username and password=@password";

            SqlCommand cmd = DataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            return DataAccess.Execute(cmd);
        }

        public bool AdminLoginVerify(string username, string password)
        {
            String query = "select * from users where username=@username and password=@password";

            SqlCommand cmd = DataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DataTable dt = DataAccess.Execute(cmd);
            return dt.Rows.Count > 0 ? true : false;
        }


        public DataTable GetAllAdmins()
        {
            String query = "select * from users";

            return DataAccess.Execute(query);
        }

        public DataTable GetAdminPassByID(string id)
        {
            String query = "select password from users where Id=@id";

            SqlCommand cmd = DataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@id", id);
            return DataAccess.Execute(cmd);
        }


    }
}
