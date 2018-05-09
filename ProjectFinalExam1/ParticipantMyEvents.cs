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
    public partial class ParticipantMyEvents : Form
    {
        public string theUserName { get; set; }
        public ParticipantMyEvents()
        {
            InitializeComponent();
        }
        public ParticipantMyEvents(string theUserName)
        {
            InitializeComponent();
        }
        private void btnEventDetailView_Click(object sender, EventArgs e)
        {

        }

        private void btnFullView_Click(object sender, EventArgs e)
        {
            frmEventFullView participant = new frmEventFullView();
            participant.theUserName = theUserName;
            participant.Show();
            this.Close();
        }

        private void MyEvents_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + "'s Events";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }
    }
}
