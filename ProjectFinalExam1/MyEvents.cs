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
    public partial class MyEvents : Form
    {
        public MyEvents()
        {
            InitializeComponent();
        }

        private void btnEventDetailView_Click(object sender, EventArgs e)
        {
            new frmEventFullView().Show();
            this.Hide();
        }
    }
}
