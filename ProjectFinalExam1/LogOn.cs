using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalExam1
{
    public partial class LogOn : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            User currentUser1 = new User();

            currentUser1.Login(username, password);

            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);





            using (SqlCommand readAllUsernameRecords = connection.CreateCommand())
            {
                //changed this sql command to try tomorrow
                readUsernameRecords.CommandText = "select RoleID ";
                readUsernameRecords.CommandText += "from Project1.dbo.Users ";
                readUsernameRecords.CommandText += "where Username = ";
                readUsernameRecords.CommandText += "'";
                readUsernameRecords.CommandText += userName;

                using (SqlDataReader reader = readAllUsernameRecords.ExecuteReader())
                {

                    int roleID = 0;
                    string currentUser = username;

                    if (reader.HasRows)
                    {
                        //Research this area, unable to pull proper RoleID, page only pulls up AdminMenu, not veryfing properly
                        //need to figure out the reader function
                        while (reader.Read())
                        {
                            //while loop is only reading role ID while in the while loop
                            // need to figure out the reader function

                            //instantiated user again to see if assigning it to you.roleID would make a difference reading the role ID
                            User you = new User();


                            you.roleID = reader.GetInt32["Role ID"];
                            //this.Close();
                        }
                    }

                    if (you.roleID == 1)
                    {
                        new ParticipantMenu().Show();
                        //this.Close();
                    }

                    else if (you.roleID == 2)
                    {
                        new AdminMenu().Show();
                        //this.Close();
                    }

                    else
                    {
                        //error
                    }

                }
            }
        }
        //using (SqlCommand readUsernameRecords = connection.CreateCommand())
        //{
        //    readUsernameRecords.CommandText = "select RoleID ";
        //    readUsernameRecords.CommandText += "from Project1.dbo.Role ";
        //    readUsernameRecords.CommandText += "where 'RoleID' =  '1' or '2'";



    }


    private void tbUserName_TextChanged(object sender, EventArgs e)
    {

    }
}
}