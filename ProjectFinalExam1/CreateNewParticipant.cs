using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSystem
{
    public partial class frmCreateNewParticipant : Form
    {
        public string theUserName { get; set; }

        public frmCreateNewParticipant()
        {
            InitializeComponent();
        }
        public frmCreateNewParticipant(string theUserName)
        {
            InitializeComponent();
        }
        private void lstbxCreateNewParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCreateNewParticipant_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";
        }
    }
}
