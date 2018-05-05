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
    public partial class fmdetailView : Form
    {
        public fmdetailView()
        {
            InitializeComponent();
        }

        private void EventDetailView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lvDetailView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Diana Bell added the following statement 5/4/2018
            Event teaserView = new Event();
            teaserView.ShowEventsForTeaserView();
        }
    }
}
