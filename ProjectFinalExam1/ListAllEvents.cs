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

    public partial class frmEventListView : Form
    {
        String eventviewDetails = "{0, -10}{1, -20}{2, -20}{3, -20}{4, -20}{5, -16}";
        public frmEventListView()
        {
            InitializeComponent();
        }

        private void ListAllEvents_Load(object sender, EventArgs e)
        {

        }

        private void lviListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetDetailView_Click(object sender, EventArgs e)
        {
           //fmDetailView fdv2 new = fmDetailView ();

           // fdv2.ShowDialog();
        }

        private void lvTeaser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventSystem.Event events = new EventSystem.Event();
            events.ShowEventsForTeaserView();
            listbxTeaserView.Items.Add(String.Format(eventviewDetails, "Event Name", "Category"));
            
            // EventSystem.Event event = new EventSystem.Event();
            //lbxDetailView.Items.Add("Event Name: " + eventInfo[0]);
            //lbxDetailView.Items.Add("Category: " + eventInfo[9]);
        }
    }
}
