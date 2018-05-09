using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Travis Eddy

namespace EventSystem
{


    public class CurrentUser
    {
        public string userName { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public int roleID { get; private set; }

        public string GetUserName(string theUsername)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users WHERE Username = @username", conn))
            {
                command.Parameters.AddWithValue("@username", theUsername);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userName = reader.GetString(reader.GetOrdinal("Username"));
                    }
                }
                return userName;
            }
        }




        public string GetFirstName(string theUsername)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            //
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users WHERE Username = @username", conn))
            {
                command.Parameters.AddWithValue("@username", theUsername);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        firstName = reader.GetString(reader.GetOrdinal("UserFirstName"));
                    }
                }
                return firstName;
            }
        }

        public string GetLastName(string theUsername)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            //
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users WHERE Username = @username", conn))
            {
                command.Parameters.AddWithValue("@username", theUsername);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lastName = reader.GetString(reader.GetOrdinal("UserLastName"));
                    }
                }
                return lastName;
            }
        }


        public int VerifyUserNamePassword(string theUsername, string thePassword)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users WHERE Username = @username and Passsword = @password", conn))
            {
                // Invoke ExecuteReader method.
                command.Parameters.AddWithValue("@username", theUsername);
                command.Parameters.AddWithValue("@password", thePassword);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        roleID = reader.GetInt32(reader.GetOrdinal("RoleID"));
                    }
                }
                return roleID;
            }
        }
    }
}
