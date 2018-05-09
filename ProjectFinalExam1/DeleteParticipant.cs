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
    public partial class DeleteParticipant : Form
    {
        public string theUserName { get; set; }
        public DeleteParticipant()
        {
            InitializeComponent();
        }
        public DeleteParticipant(string theUserName)
        {
            InitializeComponent();
        }
        private void DeleteParticipant_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";
        }
    }
}
