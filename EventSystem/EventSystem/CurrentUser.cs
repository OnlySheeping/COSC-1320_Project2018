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
        string username;
        string firstName;
        string lastName;
        int age;
        int roleID;

        //Verifies Username and Password and returns roleID to send to proper form in UI with if statement reading roleID
        public int VerifyUserNamePassword(string theUserName, string thePassWord)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users where Username =@username and Passsword = @password", conn))
            {
                // Invoke ExecuteReader method.
                command.Parameters.AddWithValue("@username", theUserName);
                command.Parameters.AddWithValue("@password", thePassWord);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        username = reader.GetString(reader.GetOrdinal("Username"));
                        firstName = reader.GetString(reader.GetOrdinal("UserFirstName"));
                        lastName = reader.GetString(reader.GetOrdinal("UserLastName"));
                        age = reader.GetInt32(reader.GetOrdinal("UserAge"));
                        roleID = reader.GetInt32(reader.GetOrdinal("RoleID"));
                    }
                }
                else
                {
                    MessageBox.Show("Contact Administrator");
                }
                return roleID;
              
            }
        }

        public string VerifyFirstName(string theUsername)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            //
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users where UserFirstName = @username", conn))
            {
                // Invoke ExecuteReader method.
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

        public string VerifyLastName(string theUsername)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users where roleID = @username", conn))
            {
                // Invoke ExecuteReader method.
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
    }
}
