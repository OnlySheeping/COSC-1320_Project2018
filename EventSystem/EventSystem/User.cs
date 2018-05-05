using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Input;

namespace EventSystem
{
    // included EventAdmin, Participant for logon transitioning to each of those pages
    public abstract class User //: //EventAdmin, Participant
    {
        SqlConnection connection = new SqlConnection();
        string[] user = new string[4];
        int[] id = new int[3];

        private string firstName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string lastName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private int age
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int capacity
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string userLevel
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private Event registeredEvents
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string username
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string password
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
    //public class UserData
    //{
    //    public void GetLogin(string userName, string password)
    //    { 
    //    //Invoke ExecuteReader method.
    //        using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users where Username =@username and Passsword = @password", Program.conn))
    //        {
    //            command.Parameters.AddWithValue("@username", userName);
    //            command.Parameters.AddWithValue("@password", password);
    //        }
    //        SqlDataReader reader = command.ExecuteReader();

    //        if (reader.HasRows)
    //        {
    //            //UserData();
    //            while (reader.Read())
    //            {
    //                string userName1 = reader.GetString(reader.GetOrdinal("Username"));
    //                string firstName = reader.GetString(reader.GetOrdinal("UserFirstName"));
    //                string lastName = reader.GetString(reader.GetOrdinal("UserLastName"));
    //                int userAge = reader.GetInt32(reader.GetOrdinal("UserAge"));
    //                int roleID = reader.GetInt32(reader.GetOrdinal("RoleID"));

    //                if (roleID == 1)
    //                {
    //                    MessageBox.Show("Logon Successful" + Environment.NewLine + "Welcome" + " " + firstName + " " + lastName);
    //                    ProjectFinalExam1.ParticipantMenu participant = new ParticipantMenu();
    //                    participant.Show();
    //                    Visible = false;
    //                }
    //                else if (roleID == 2)
    //                {
    //                    MessageBox.Show("Logon Successful" + Environment.NewLine + "Welcome" + " " + firstName + " " + lastName);
    //                    AdminMenu admin = new AdminMenu();
    //                    admin.Show();
    //                    Visible = false;
    //                }
    //                else
    //                {

    //                    MessageBox.Show("Please enter correct Username and Password");
    //                }
    //            }
    //        }
    //        else
    //        {
    //            MessageBox.Show("Contact Administrator");
    //        }

        }
//    }
//}

//    }
