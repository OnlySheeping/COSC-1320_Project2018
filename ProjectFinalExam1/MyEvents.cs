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
    public partial class MyEvents : Form
    {
        public string theUserName { get; set; }
        public string theUserName { get; set; }
        public MyEvents()
        {
            InitializeComponent();
        }
        public MyEvents(string theUserName)
        {
            InitializeComponent();
        }
        private void btnEventDetailView_Click(object sender, EventArgs e)
        {
            this.Close();
            new ParticipantMenu().Show();
        }

        private void btnFullView_Click(object sender, EventArgs e)
        {
            new frmEventFullView().Show();
            this.Close();
        }

        private void MyEvents_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";
        }
    }
}
