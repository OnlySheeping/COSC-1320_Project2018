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
    public partial class EventListView : Form
    {
        public string theUserName { get; set; }
        public EventListView()
        {
            InitializeComponent();
        }
        public EventListView(string theUserName)
        {
            InitializeComponent();
        }

        private void EventListView_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";

            Event teaserView = new Event();
            List<string> eventsTeaser = new List<string>();
            eventsTeaser = Event.GetEventForTeaser();

            //for (var i = 0; i < eventsTeaser.Length; i++)
            //{

            //}
            int eventCount = 0;
            foreach (string word in eventsTeaser)
            {
                // System.Diagnostics.Debug.WriteLine(word);
                String[] eventDetail = word.Split('|');
                lviViewAllEvents.Items.Add(eventDetail[0]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetail[1]);
                lviViewAllEvents.Items[eventCount].SubItems.Add(eventDetail[2]);
                eventCount++;
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
            
        }
    }
}
