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
            if(MessageBox.Show("Are you sure you want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventSystem.CurrentUser currentUser = new EventSystem.CurrentUser();
            string firstName = currentUser.GetFirstName(tbUserName.Text);
            string lastName = currentUser.GetLastName(tbUserName.Text);
            string userName = tbUserName.Text;
            int roleID = currentUser.VerifyUserNamePassword(tbUserName.Text, tbPassword.Text);



            if (currentUser.roleID == 1)
            {
                MessageBox.Show("Logon Successful" + Environment.NewLine + "Welcome" + " " + firstName + " " + lastName);
                ParticipantMenu participant = new ParticipantMenu(userName);
                participant.theUserName = userName;
                participant.Show();
            }
            else if (currentUser.roleID == 2)
            {

                MessageBox.Show("Logon Successful" + Environment.NewLine + "Welcome" + " " + firstName + " " + lastName);
                EventAdminMenu admin = new EventAdminMenu(userName);
                admin.theUserName = userName;
                admin.Show();
                
            }
            else
            {
                MessageBox.Show("Please enter correct Username and Password");
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
