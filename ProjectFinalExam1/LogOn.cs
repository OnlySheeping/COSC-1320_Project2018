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
            int roleID = currentUser.VerifyUserNamePassword(tbUserName.Text, tbPassword.Text);
            string firstName = currentUser.VerifyFirstName(tbUserName.Text);
            string lastName = currentUser.VerifyLastName(tbUserName.Text);

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
                EventAdminMenu admin = new EventAdminMenu();
                admin.Show();
                Visible = false;
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
