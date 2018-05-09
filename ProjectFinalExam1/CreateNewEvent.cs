using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventSystem;

namespace ProjectFinalExam1
{
    public partial class frmCreateEvent : Form
    {
        public string theUserName { get; set; }
        public frmCreateEvent()
        {
            InitializeComponent();
        }
        public frmCreateEvent(string theUserName)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Create New Event";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbEventName.Text = "";
            txbDescription.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            txbAge.Text = "";
            txbAttendees.Text = "";



        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txbEventName.Text = "";
            txbDescription.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            txbAge.Text = "";
            txbAttendees.Text = "";
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            frmAddParticipantToEvents admin = new frmAddParticipantToEvents();
            admin.theUserName = theUserName;
            admin.Show();
            Visible = true;
    }

        private void txbEventName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
