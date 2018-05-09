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
    public partial class EventAdminMenu : Form
    {
        public string theUserName { get; set; }


        public EventAdminMenu(string theUserName)
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            EventManager admin = new EventManager(theUserName);
            admin.theUserName = theUserName;
            admin.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            ManageParticipants admin = new ManageParticipants();
            admin.theUserName = theUserName;
            this.Hide();

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";
        }
    }
}
