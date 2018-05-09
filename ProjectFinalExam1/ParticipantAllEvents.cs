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
    public partial class ParticipantAllEvents : Form
    {
        public string theUserName { get; set; }
        public ParticipantAllEvents()
        {
            InitializeComponent();
        }
        public ParticipantAllEvents(string theUserName)
        {
            InitializeComponent();
        }

        private void EventListView_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - All Events";

            Event teaserView = new Event();
            List<string> eventsTeaser = new List<string>();
            //Make list equal to method return value
            eventsTeaser = Event.GetEventForTeaser();

            int eventCountTwo = 0;
            foreach (string wordTwo in eventsTeaser)
            {
                // System.Diagnostics.Debug.WriteLine(word);
                String[] eventDetails = wordTwo.Split('|');
                lviViewAllEvents.Items.Add(eventDetails[0]);
                lviViewAllEvents.Items[eventCountTwo].SubItems.Add(eventDetails[1]);
                lviViewAllEvents.Items[eventCountTwo].SubItems.Add(eventDetails[2]);
                eventCountTwo++;
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Event teaserView = new Event();
            //List<string> eventsTeaser = new List<string>();
            //eventsTeaser = Event.GetEventForTeaser();
            //MessageBox.Show(eventsTeaser[1]);
        }

        private void btnFullView_Click(object sender, EventArgs e)
        {
            frmEventFullView admin = new frmEventFullView();
            admin.theUserName = theUserName;
            admin.Show();
            this.Hide();
        }

        private void lviViewAllEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
