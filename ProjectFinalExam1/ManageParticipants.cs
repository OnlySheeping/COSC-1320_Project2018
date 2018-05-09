using EventSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ProjectFinalExam1
{
    public partial class ManageParticipants : Form
    {
        public string theUserName { get; set; }
        public ManageParticipants()
        {
            InitializeComponent();
        }
        public ManageParticipants(string theUserName)
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEventsToParticipants admin = new frmAddEventsToParticipants();
            admin.theUserName = theUserName;
            admin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LogOn().Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxParticipantManagerList.SelectedItem !=null)
                {
                MessageBox.Show(lbxParticipantManagerList.SelectedItem.ToString());
                }
        }

        private void ManageParticipants_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + "'s User Account Manager";

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

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void lxbParticipantManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
