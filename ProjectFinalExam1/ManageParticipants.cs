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
    public partial class ManageParticipants : Form
    {
        public ManageParticipants()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // new Participant().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LogOn().Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxParticipantManagerList.SelectedItem !null)
                {
                MessageBox.Show(lbxParticipantManagerList.SelectedItem.Tostring());
                }
        }
    }
}
