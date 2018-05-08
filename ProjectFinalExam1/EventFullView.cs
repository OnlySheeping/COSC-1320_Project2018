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
        public frmEventFullView()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Event getDetail = new Event();
            List<string> eventInfo = new List<string>();

            //bool all = eventInfo.All(x => x.Length > 0);
            eventInfo = Event.ShowEventDetail(2);
            // MessageBox.Show(all.);
            lbxDetailView.Items.Add("Event Name: " + eventInfo[0]);
            lbxDetailView.Items.Add("Status: " + eventInfo[1]);
            lbxDetailView.Items.Add("Event Description: " + eventInfo[2]);
            lbxDetailView.Items.Add("Start Date: " + eventInfo[3]);
            lbxDetailView.Items.Add("End Date: " + eventInfo[4]);
            lbxDetailView.Items.Add("Start Time: " + eventInfo[5]);
            lbxDetailView.Items.Add("End Time: " + eventInfo[6]);
            lbxDetailView.Items.Add("Event Notes: " + eventInfo[7]);
            lbxDetailView.Items.Add("Age Requirement: " + eventInfo[8]);
            lbxDetailView.Items.Add("Category: " + eventInfo[9]);
            lbxDetailView.Items.Add("Private: " + eventInfo[10]);
            lbxDetailView.Items.Add("Status: " + eventInfo[11]);
            lbxDetailView.Items.Add("Location: " + eventInfo[12]);
            lbxDetailView.Items.Add("Max Attendees: " + eventInfo[13]);

            
            
        }

        private void lvDetailView_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void frmEventFullView_Load(object sender, EventArgs e)
        {

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
