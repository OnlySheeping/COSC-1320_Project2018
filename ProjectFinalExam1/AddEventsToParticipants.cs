using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalExam1     // CREATED BY CHRISTINA 5.6.18

{
    public partial class frmAddEventsToParticipants : Form
    {
        public string theUserName { get; set; }

        public frmAddEventsToParticipants()
        {
            InitializeComponent();
        }
        public frmAddEventsToParticipants(string theUserName)
        {
            InitializeComponent();
        }
        private void frmAddEventsToParticipants_Load(object sender, EventArgs e)
        {

        }

        private void cklstbxAddEventsToParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnWaitList_Click(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";
        }
    }
}
