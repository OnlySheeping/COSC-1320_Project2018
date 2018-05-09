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

namespace EventSystem
{
    public partial class frmParticipantFullView : Form
    {
        public string theUserName { get; set; }
        public frmParticipantFullView()
        {
            InitializeComponent();
        }
        public frmParticipantFullView(string theUserName)
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmParticipantFullView_Load(object sender, EventArgs e)
        {
            Participant participantView = new Participant();
            List<string> allParticipantView = new List<string>();
            //Make list equal to method return value
            allParticipantView = Participant.GetAllParticipants();

            int participantCountTwo = 0;
            foreach (string wordTwo in allParticipantView)
            {
                // System.Diagnostics.Debug.WriteLine(word);
                String[] eventDetails = wordTwo.Split('|');
                lviViewAllParticipants.Items.Add(eventDetails[0]);
                lviViewAllParticipants.Items[participantCountTwo].SubItems.Add(eventDetails[1]);
                lviViewAllParticipants.Items[participantCountTwo].SubItems.Add(eventDetails[2]);
                participantCountTwo++;
            }

        }
    }
}
