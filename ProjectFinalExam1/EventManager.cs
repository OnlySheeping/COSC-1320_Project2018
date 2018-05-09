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
    
    public partial class EventManager : Form
    {
        public string theUserName { get; set; }
        public EventManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCreateEvents_Click(object sender, EventArgs e)
        {
            frmCreateEvent admin = new frmCreateEvent();
            admin.theUserName = theUserName;
            admin.Show();
            this.Hide();

        }

        private void btnAllEvents_Click(object sender, EventArgs e)
        {
            EventAdminAllEvents admin = new EventAdminAllEvents();
            admin.theUserName = theUserName;
            admin.Show();
            this.Hide();
        }

        private void EventManager_Load(object sender, EventArgs e)
        {

        }
    }
}
