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
    public partial class EventListView : Form
    {
        public EventListView()
        {
            InitializeComponent();
        }

        private void frmAllEvents_Load(object sender, EventArgs e)
        {
            Event teaserView = new Event();
            List<string> eventsTeaser = new List<string>();
            //eventInfo = Event.ShowEventDetail(2);
            eventsTeaser = Event.GetEventsForTeaserView();
            MessageBox.Show(eventsTeaser[1]);
        }

    }
}
