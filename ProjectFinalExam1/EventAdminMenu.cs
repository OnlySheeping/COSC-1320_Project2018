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
    public partial class EventAdminMenu : Form
    {
        public EventAdminMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new EventManager().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ManageParticipants().Show();
            this.Hide();

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}