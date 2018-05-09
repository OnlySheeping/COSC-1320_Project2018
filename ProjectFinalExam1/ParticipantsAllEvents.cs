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
    public partial class ParticipantsAllEvents : Form
    {
        public string theUserName { get; set; }
        public ParticipantsAllEvents()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ParticipantsAllEvents_Load(object sender, EventArgs e)
        {
            //Will change form title to username - All events
            this.Text = theUserName + " - All Events";

            //Instantiate Event object
            Event teaserView = new Event();
            //Create a list to store method outpust
            List<string> eventsList = new List<string>();
            //Make list equal to method return value
            eventsList = Event.ShowEventsForListView();
            int eventCount = 0;
            //int eventCountTwo = 0;
            foreach (string word in eventsList)
            {
                //System.Diagnostics.Debug.WriteLine(word);
                String[] eventDetails = word.Split('|');
                lviListView.Items.Add(eventDetails[0]);
                lviViewAllEvents.Items.Add(eventDetails[0]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[1]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[1]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[2]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[3]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[4]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[5]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[6]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[7]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[8]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[9]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[10]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetails[11]);

                eventCount++;
            }
        }
        private void btnFullView_Click(object sender, EventArgs e)
        {
            frmEventFullView admin = new frmEventFullView();
            admin.theUserName = theUserName;
            admin.Show();
            this.Hide();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

