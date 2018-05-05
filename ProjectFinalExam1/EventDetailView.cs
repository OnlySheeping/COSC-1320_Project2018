using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using EventSystem;

namespace ProjectFinalExam1
{
    public partial class fmdetailView : Form
    {
        public fmdetailView()
        {
            InitializeComponent();
        }

        private void EventDetailView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lvDetailView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Diana Bell added the following statement 5/4/2018
            Event teaserView = new Event();
            teaserView.ShowEventsForTeaserView();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //Event teaserView = new Event();
            //teaserView.ShowEventsForTeaserView();
            List<Event> partList = new List<Event>();
            SqlConnection connection = 
                new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");

            SqlCommand command = new SqlCommand ("SELECT CategoryDescription, EventName " +
       "FROM dbo.Categories.CategoryID " +
       "INNER JOIN dbo.Events " +
       "ON dbo.Categories.CategoryID = dbo.Events.CategoryID " +
       "ORDER BY CategoryDescription ASC, EventName ASC;", connection);


            SqlDataReader reader;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    partList.Add(new Event()
                    {
                        CategoryDescription = reader.GetString(reader.GetOrdinal("CategoryDescription")),
                        EventName = reader.GetString(reader.GetOrdinal("EventName"))
                    });

                }
                //}
                reader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception exp)
            {
                throw;
            }

        }
    }
}
