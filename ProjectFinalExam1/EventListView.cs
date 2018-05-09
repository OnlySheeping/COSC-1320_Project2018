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
        public EventListView()
        {
            InitializeComponent();
        }

        private void EventListView_Load(object sender, EventArgs e)
        {
            //Instantiate an Event object
            Event view = new Event();


            ////The following code is for the List View
            ////Create a list to store method
            //List<string> eventsList = new List<string>();
            ////Make list equal to method return value
            //eventsList = Event.ShowEventsForListView();
            //MessageBox.Show(eventsList[0]);
            //int eventCountOne = 0;
            //foreach (string wordOne in eventsList)
            //{
            //    System.Diagnostics.Debug.WriteLine(wordOne);
            //    String[] eventDetail = wordOne.Split('|');
            //    lviListView.Items.Add(eventDetail[0]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[1]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[2]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[3]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[4]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[5]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[6]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[7]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[8]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[9]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[10]);
            //    lviListView.Items[eventCountOne].SubItems.Add(eventDetail[11]);
            //    eventCountOne++;
            //}



            //The following code is for the Teaser View
            //Create a list to store method
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
            
        }
    }
}
