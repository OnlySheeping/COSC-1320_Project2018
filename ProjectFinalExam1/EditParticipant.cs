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
    public partial class EditParticipant : Form
    {
        public string theUserName { get; set; }
        public EditParticipant()
        {
            InitializeComponent();
        }
        public EditParticipant(string theUserName)
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new ManageParticipants().Show();
            this.Hide();

        }

        private void EditParticipant_Load(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";
        }
    }
}
