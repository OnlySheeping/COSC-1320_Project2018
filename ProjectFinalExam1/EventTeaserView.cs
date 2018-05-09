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
    public partial class Form1 : Form
    {
        public string theUserName { get; set; }
        public Form1()
        {
           InitializeComponent();
        }
        public Form1(string theUserName)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";
        }
    }
}
