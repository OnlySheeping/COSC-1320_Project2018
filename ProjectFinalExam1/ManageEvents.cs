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
    public partial class ManageEvents : Form
    {
        //Test commit.
        public ManageEvents()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LogOn().Show();
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            new AddEvent().Show();
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            new EditEvent().Show();
            this.Hide();
        }
    }
}