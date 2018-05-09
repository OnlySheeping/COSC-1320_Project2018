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
    public partial class EventManager : Form
    {
        //Test commit.
        public EventManager()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.project1DataSet.Events);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LogOn().Show();
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            new frmCreateEvent().Show();
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            new frmEventEdit().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //  private void btn3_Click(object sender, EventArgs e)
        //  {
        //     new EditEvent().Show();
        //      this.Hide();
        //  }
    }
}
