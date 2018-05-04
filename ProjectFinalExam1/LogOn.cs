using EventSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectFinalExam1
{
    public partial class LogOn : Form
    {
        SqlConnection connection = new SqlConnection();
        string userName;
        string password;
        string firstName;
        string lastName;
        int userAge;
        int roleID;

        public LogOn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public class UserData
        {
            static SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10");
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand("select * from Project1.dbo.Users", conn);
            SqlDataReader dr;
            



            //  if (userArray[5] == "1")
            //   {
            //       new AdminMenu().Show();
            //   }

            // try
            // {

            //    connString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            //        pubConnection.ConnectionString = connString;
            //            pubConnection.Open();
            //            pubcommand = new SqlCommand();
            //    pubcommand.Connection = pubConnection;
            //            pubcommand.CommandText = new SqlCommand("Select * from Project1.dbo.Users", )
            //            dr = pubcommand.ExecuteReader();




            //            while (userDataReader.Read())
            //            {
            //                userArray.Add(userDataReader["Username{0}, Passsword, UserFirstName, UserLastName, UserAge, RoleID"]);

            //                foreach ()

            //            }
            //userArg[0] = userArray[1][5];
            //        return userArray;
            //        }
            //        catch (SqlException ex)
            //        {
            //   throw ex;
            //}
            //finally
            //{
            //   if (pubConnection != null)
            //  {
            //     pubConnection.Close();
            //}
            //  }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string username = tbUserName.Text;
            string password = tbPassword.Text;

            User currentUser1 = new User();

            //currentUser1.Login(username, password);

            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);




            using (SqlCommand command = new SqlCommand("SELECT * FROM Project1.dbo.Users where Username =@username and Passsword = @password", connection))
            {
                //
                // Invoke ExecuteReader method.
                //
                command.Parameters.AddWithValue("@username", tbUserName.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);


                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //UserData();

                    // IF it has Rows so your Good to go and show your message 
                    MessageBox.Show("Logon Successful");
                    
                   // MessageBox.Show("UserArg[4]= " + userArg[4]);
                    //MessageBox.Show("UserArg[5]= " + userArg[5]);


                    //if()

                }
                else
                {
                    MessageBox.Show("Contact Administrator");
                }

            }
        }
    }
}
//error field            catch () { }
           // finally { }
        //}



    //}
    //}