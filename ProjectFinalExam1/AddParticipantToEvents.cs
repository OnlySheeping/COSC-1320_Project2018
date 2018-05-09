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

            Participant viewParticipant = new Participant();
            List<string> participantView = new List<string>();
            participantView = Participant.GetAllParticipants();

            //for (var i = 0; i < participantView.Length; i++)
            //{

            //}
            int participantCount = 0;
            foreach (string word in participantView)
            {
                // System.Diagnostics.Debug.WriteLine(word);

                String[] participantDetail = word.Split('|');
                lxbParticipantManager.Items.Add(participantDetail[0]);
                lxbParticipantManager.Items[participantCount].SubItems.Add(participantDetail[1]);
                lxbParticipantManager.Items[participantCount].SubItems.Add(participantDetail[2]);
                lxbParticipantManager.Items[participantCount].SubItems.Add(participantDetail[3]);
                lxbParticipantManager.Items[participantCount].SubItems.Add(participantDetail[4]);
                participantCount++;
            }
        }

    }

}

