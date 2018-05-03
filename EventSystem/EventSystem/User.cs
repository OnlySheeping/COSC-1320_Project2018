using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace EventSystem
{
    // included EventAdmin, Participant for logon transitioning to each of those pages
    public abstract class User : EventAdmin, Participant
    {
        SqlConnection connection = new SqlConnection();

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

        public bool Login(string userName, string password)
        {

            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();

            bool didLoginWork = false;

            using (SqlCommand readUsernameRecords = connection.CreateCommand())
            {

                readUsernameRecords.CommandText = "select Username ";
                readUsernameRecords.CommandText += "from Project1.dbo.Users ";
                readUsernameRecords.CommandText += "where Username = ";
                readUsernameRecords.CommandText += "'";
                readUsernameRecords.CommandText += userName;
                readUsernameRecords.CommandText += "'";
                readUsernameRecords.CommandText += "and Passsword = ";
                readUsernameRecords.CommandText += "'";
                readUsernameRecords.CommandText += password;
                readUsernameRecords.CommandText += "'";

                using (SqlDataReader reader = readUsernameRecords.ExecuteReader())
                {
                    int userCount = 0;

                    while (reader.HasRows && reader.Read())
                    {
                        userCount++;
                        if (userCount > 1)
                        {
                            //BIG Error
                            didLoginWork = false;
                            Console.WriteLine("Contact network administrator");
                            return didLoginWork;
                        }
                        else if (userCount == 1)
                        {
                            // Put your success logic here.
                            didLoginWork = true;
                            MessageBox.Show("LogOn Successful!");

                            // Login a success. Carry on.

                            //bool roleID = true;

                            //readUsernameRecords.CommandText = "select RoleID ";
                            //readUsernameRecords.CommandText += "from db_owner.Role ";
                            //readUsernameRecords.CommandText += "where 'RoleID' =  '1'";
                        }

                        else
                        {
                            if (userName == "")
                            {
                                MessageBox.Show("Please enter username");
                            }
                            else if (password == "")
                            {
                                MessageBox.Show("Please enter password");
                            }
                            else
                            {
                                didLoginWork = false;
                                Console.WriteLine("There was an issue with your username or password.");
                                return didLoginWork;
                            }

                            string currentUser = userName;
                        }

                    }

                }
            }
            return didLoginWork;
            //Console.ReadKey();

        }

        public void ShowRegisteredEvents()
        {
            throw new System.NotImplementedException();
        }
    }
}