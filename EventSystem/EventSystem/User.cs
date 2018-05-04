using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Collections;

namespace EventSystem
{
    // included EventAdmin, Participant for logon transitioning to each of those pages
    public class User //: //EventAdmin, Participant
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

        public class UserData
        {
           // List<UserData> userData = new List<UserData>();
          //  SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10");
          //  SqlCommand cmd = new SqlCommand("select * from Project1.dbo.Users", conn);
          //  SqlDataReader dr;

                 
        //SqlConnection pubConnection = new SqlConnection();
        //    string connString;
        //    SqlCommand pubcommand;
        //    ArrayList userArray;
        //    SqlDataReader employeeDataReader;

        //    try
        //    {
        //        connString = "Data Source=drcsrv01;" +
        //            "Initial Catalog=pubs;Integrated Security=True";
        //        pubConnection.ConnectionString = connString;
        //        pubConnection.Open();
        //        pubcommand = new SqlCommand();
        //        pubcommand.Connection = pubConnection;
        //        pubcommand.CommandText =
        //            "Select * from Project1.dbo.Users";
        //        employeeDataReader = pubcommand.ExecuteReader();
        //        userArray = new ArrayList();
        //        while (employeeDataReader.Read())
        //        {
        //            userArray.Add(employeeDataReader["*"]);
        //        }
        //        return userArray;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if(pubConnection != null)
        //        {
        //            pubConnection.Close();
        //        }
        //    }
            
        }
        
        
        // public bool Login(string userName, string password)
       // {
         //   return didLoginWork;

            ////Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            //connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            //connection.Open();
            //Console.WriteLine(connection.ServerVersion);
            ////Console.ReadKey();

            //bool didLoginWork = false;

            //using (SqlCommand readAllUsernameRecords = connection.CreateCommand())
            //{
            //    readAllUsernameRecords.CommandText = "select  from Project1.dbo.Users where Username = 'userName';";

            //    using (SqlDataReader reader = readAllUsernameRecords.ExecuteReader())
            //    {
            //        int userCount = 0;


            //        while (reader.HasRows && reader.Read())
            //        {


            //            userCount++;

            //            if (userCount > 1)
            //            {
            //                //BIG Error
            //                didLoginWork = false;
            //                Console.WriteLine("Contact network administrator");
            //                return didLoginWork;
            //            }
            //            else if (userCount == 1)
            //            {
            //                // Put your success logic here.
            //                didLoginWork = true;
            //                MessageBox.Show("Logon Successful!");

            //                // Login a success. Carry on.

            //                //bool roleID = true;

            //                //readUsernameRecords.CommandText = "select RoleID ";
            //                //readUsernameRecords.CommandText += "from db_owner.Role ";
            //                //readUsernameRecords.CommandText += "where 'RoleID' =  '1'";
            //                return didLoginWork;
            //            }
            //            else
            //            {
            //                    Console.WriteLine("There was an issue with your username or password.");
            //                    return didLoginWork;
            //            }

            //        }

            //    }
            //}

       // }


        public void ShowRegisteredEvents()
        {
            throw new System.NotImplementedException();
        }
    }
}