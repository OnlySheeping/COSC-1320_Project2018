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
        public LogOn()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
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

            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users where Username =@username and Passsword = @password", Program.conn))
            {
                // Invoke ExecuteReader method.

                command.Parameters.AddWithValue("@username", tbUserName.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //UserData();
                    while(reader.Read())
                    {
                        string userName = reader.GetString(reader.GetOrdinal("Username"));
                        string firstName = reader.GetString(reader.GetOrdinal("UserFirstName"));
                        string lastName = reader.GetString(reader.GetOrdinal("UserLastName"));
                        int userAge = reader.GetInt32(reader.GetOrdinal("UserAge"));
                        int roleID = reader.GetInt32(reader.GetOrdinal("RoleID"));

                        if (roleID == 1)
                        {
                            MessageBox.Show("Logon Successful" + Environment.NewLine + "Welcome" + " " + firstName + " " + lastName);
                            ParticipantMenu participant = new ParticipantMenu();
                            participant.Show();
                            Visible = false;
                        }
                        else if (roleID == 2)
                        {
                            MessageBox.Show("Logon Successful" + Environment.NewLine + "Welcome" + " " + firstName + " " + lastName);
                            AdminMenu admin = new AdminMenu();
                            admin.Show();
                            Visible = false;
                        }
                        else
                        {
                            
                            MessageBox.Show("Please enter correct Username and Password");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contact Administrator");
                }

            }
        }
    }
}
