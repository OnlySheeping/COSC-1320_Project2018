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
    public partial class CreateNewParticipant : Form
    {
        public CreateNewParticipant()
        {
            InitializeComponent();
        }

        private void lstbxCreateNewParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateNewParticipant_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to add this participant to the database?");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you would like to cancel? ");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
