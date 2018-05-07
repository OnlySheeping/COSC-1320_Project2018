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
    public partial class frmEventEdit : Form
    {
        public frmEventEdit()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            txbEventEditStartDate.Text = "";
            txbEventEditEndDate.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void lblEditEvent_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbEventEditActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
