﻿using System;
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
    public partial class ParticipantMenu : Form
    {
        public ParticipantMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }






        private void btnMyEvents_Click(object sender, EventArgs e)
        {
            new MyEvents().Show();
            this.Hide();

        }

        private void btnListAllEvents_Click(object sender, EventArgs e)
        {
            new ListAllEvents().Show();
            this.Hide();

        }
    }
}