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
    public partial class frmAddParticipantToEvents : Form
    {
        public string theUserName { get; set; }

        public frmAddParticipantToEvents()
        {
            InitializeComponent();
        }
        public frmAddParticipantToEvents(string theUserName)
        {
            InitializeComponent();
        }
        private void frmAddParticipantToEvents_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Add Participants";
        }
    }
}
