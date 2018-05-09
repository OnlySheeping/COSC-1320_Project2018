using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using EventSystem;

namespace ProjectFinalExam1
{
    public partial class frmEventFullView : Form
    {
        public string theUserName { get; set; }
        public frmEventFullView()
        {
            InitializeComponent();
        }
        public frmEventFullView(string theUserName)
        {
            InitializeComponent();
        }

        private void lvDetailView_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void frmEventFullView_Load(object sender, EventArgs e)
        {

        }

        private void frmEventFullView_Load_1(object sender, EventArgs e)
        {
            this.Text = theUserName + " - Event Admin Menu";
        }

        private void btnLoadEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
           
           new ParticipantMenu().Show();
            this.Hide();
        }



        // private void lvDetailView_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     // Diana Bell added the following statement 5/4/2018
        //     Event teaserView = new Event();
        //     teaserView.GetEventForTeaser();
        // }

        // private void Populate()
        // {
        //     //Event teaserView = new Event();
        //     //teaserView.GetEventForTeaser();
        //     List<Event> partList = new List<Event>();
        //     SqlConnection connection =
        //         new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");

        //     SqlCommand command = new SqlCommand("SELECT CategoryDescription, EventName " +
        //"FROM dbo.Categories.CategoryID " +
        //"INNER JOIN dbo.Events " +
        //"ON dbo.Categories.CategoryID = dbo.Events.CategoryID " +
        //"ORDER BY CategoryDescription ASC, EventName ASC;", connection);


        //     SqlDataReader reader;

        //     try
        //     {
        //         connection.Open();
        //         reader = command.ExecuteReader();
        //         while (reader.Read())
        //         {
        //             partList.Add(new Event()
        //             {
        //                 CategoryDescription = reader.GetString(reader.GetOrdinal("CategoryDescription")),
        //                 EventName = reader.GetString(reader.GetOrdinal("EventName"))
        //             });

        //         }
        //         //}
        //         reader.Close();
        //         command.Dispose();
        //         connection.Close();
        //     }
        //     catch (Exception exp)
        //     {
        //         throw;
        //     }

        // }
        // private void btnPopulate_Click(object sender, EventArgs e)
        // {
        //     //Event teaserView = new Event();
        //     //teaserView.GetEventForTeaser();
        //     List<Event> partList = new List<Event>();
        //     SqlConnection connection = 
        //         new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");

        //     SqlCommand command = new SqlCommand ("SELECT CategoryDescription, EventName " +
        //"FROM dbo.Categories.CategoryID " +
        //"INNER JOIN dbo.Events " +
        //"ON dbo.Categories.CategoryID = dbo.Events.CategoryID " +
        //"ORDER BY CategoryDescription ASC, EventName ASC;", connection);


        //     SqlDataReader reader;

        //     try
        //     {
        //         connection.Open();
        //         reader = command.ExecuteReader();
        //         while (reader.Read())
        //         {
        //             partList.Add(new Event()
        //             {
        //                 CategoryDescription = reader.GetString(reader.GetOrdinal("CategoryDescription")),
        //                 EventName = reader.GetString(reader.GetOrdinal("EventName"))
        //             });

        //         }
        //         //}
        //         reader.Close();
        //         command.Dispose();
        //         connection.Close();
        //     }
        //     catch (Exception exp)
        //     {
        //         throw;
        //     }

    }
    }
