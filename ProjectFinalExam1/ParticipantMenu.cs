﻿using System;
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
    public partial class ParticipantMenu : Form
    {
        public string theUserName { get; set; }
        public ParticipantMenu()
        {
            InitializeComponent();
        }
        public ParticipantMenu(string theUserName)
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
            MyEvents participant = new MyEvents();
            participant.theUserName = theUserName;
            participant.Show();
            this.Hide();

        }

        private void btnListAllEvents_Click(object sender, EventArgs e)
        {
            ParticipantMenu participant = new ParticipantMenu();
            participant.theUserName = theUserName;
            participant.Show();
            this.Hide();
        }

        private void ParticipantMenu_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Participant Menu";
        }


    }
}
