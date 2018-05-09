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
    public partial class EventAdminsAllEvents : Form
    {
        public string theUserName { get; set; }
        public EventAdminsAllEvents()
        {
            InitializeComponent();
        }

        private void EventAdminsAllEvents_Load(object sender, EventArgs e)
        {
            //Will change form title to username - All events
            this.Text = theUserName + " - All Events";

            //Instantiate Event object
            //Event teaserView = new Event();
            ////Create a list to store method outpust
            //List<string> eventsList = new List<string>();
            ////Make list equal to method return value
            //eventsList = Event.ShowEventsForListView();
            //int eventCount = 0;
        //    ////int eventCountTwo = 0;
        //    //foreach (string word in eventsList)
        //    {
        //        //System.Diagnostics.Debug.WriteLine(word);
        //        String[] eventDetails = word.Split('|');
        //        //lviListViewEvents.Items.Add(eventDetails[0]);
        //        //lviListViewEvents.Items[eventCount].SubItems.Add(eventDetails[1]);

        //        //lviList.Items.Add(eventDetails[0]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[1]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[2]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[3]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[4]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[5]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[6]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[7]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[8]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[9]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[10]);
        //        //lviList.Items[eventCount].SubItems.Add(eventDetails[11]);

        //        eventCount++;
        //    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEventFullView admin = new frmEventFullView();
            admin.theUserName = theUserName;
            admin.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
