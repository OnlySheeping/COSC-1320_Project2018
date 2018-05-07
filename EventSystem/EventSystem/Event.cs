using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;

namespace EventSystem
{
    public class Event
    {
        
        private string title
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string description
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string eventCategory
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private DateTime startDate
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private DateTime endDate
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private int maxAttendees
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string location
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private User participants
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string status
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string notes
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private User waitList
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string eventID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string CategoryDescription { get; set; }
        public string EventName { get; set; }
        public string Status { get; set; }
        public string EventDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string EventNotes { get; set; }
        public string AgeRequirement { get; set; }
        public string CategoryID { get; set; }
        public string Private { get; set; }
        public string Closed { get; set; }
        public string Location { get; set; }
        public string MaxAttendees { get; set; }

        public void ShowEventsForTeaserView()
        {
            
            // This is setup and able to call this method from EventDetailView Form
            // Method is located in EventDetailView.cs under 
            //Event teaserView = new Event();
            //teaserView.ShowEventsForTeaserView();
            List<Event> partList = new List<Event>();
            SqlConnection connection = 
                new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");

            SqlCommand command = 
                new SqlCommand ("SELECT CategoryDescription, EventName " +
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
            catch (Exception)
            {
                throw;
            }
        }



        public void ShowEventsForListView()
        {
            throw new System.NotImplementedException();
        }

        public static string[] ShowEventDetail(string theEventID)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            //throw new System.NotImplementedException();
            //      SELECT TOP 1[EventID]
            //,[EventName]
            //,[Status]
            //,[EventDescription]
            //,[StartDate]
            //,[EndDate]
            //,[StartTime]
            //,[EndTime]
            //,[EventNotes]
            //,[AgeRequirement]
            //, CategoryID replace with CategoryDescription - table 
            //,[Private]
            //,[Closed]
            //,[Location]
            //,[MaxAttendees]
            //  FROM[Project1].[dbo].[Events]

            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Events where EventID = @eventID", conn))
            {
                string[] eventInfo = new string[13];
                // Invoke ExecuteReader method.
                command.Parameters.AddWithValue("@eventID", theEventID);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //UserData();
                    while (reader.Read())
                    {
                        int rawEventID = reader.GetInt32(reader.GetOrdinal("EventID"));
                        string eventname = reader.GetString(reader.GetOrdinal("EventName"));
                        string status = reader.GetString(reader.GetOrdinal("UserStatus"));
                        string eventDesciption = reader.GetString(reader.GetOrdinal("EventDesciption"));
                        DateTime rawStartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                        DateTime rawEndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                        DateTime rawStartTime = reader.GetDateTime(reader.GetOrdinal("StartTime"));
                        DateTime rawEndTime = reader.GetDateTime(reader.GetOrdinal("EndTime"));
                        string eventNotes = reader.GetString(reader.GetOrdinal("EventNotes"));
                        int rawAgeRequirement = reader.GetInt32(reader.GetOrdinal("AgeRequirements"));
                        int rawClosed = reader.GetInt32(reader.GetOrdinal("Closed"));
                        string location = reader.GetString(reader.GetOrdinal("Location"));
                        int rawMaxAttendee = reader.GetInt32(reader.GetOrdinal("MaxAttendees"));
                        int rawPrivateID = reader.GetInt32(reader.GetOrdinal("Private"));



                        
                        string eventID = rawEventID.ToString();
                        string startDate = rawEventID.ToString();
                        string endDate = rawEventID.ToString();
                        string startTime = rawEventID.ToString();
                        string endTime = rawEventID.ToString();
                        string ageRequirement = rawAgeRequirement.ToString();
                        string closed = rawClosed.ToString();
                        string maxAttendee = rawMaxAttendee.ToString();
                        string privateID = rawPrivateID.ToString();
                        eventID = eventInfo[0];
                        eventname = eventInfo[1];
                        status = eventInfo[2];
                        eventDesciption = eventInfo[3];
                        startDate = eventInfo[4];
                        endDate = eventInfo[5];
                        startTime = eventInfo[6];
                        endTime = eventInfo[7];
                        eventNotes = eventInfo[8];
                        ageRequirement = eventInfo[9];
                        privateID = eventInfo[10];
                        closed = eventInfo[11];
                        location = eventInfo[12];
                        maxAttendee = eventInfo[13];

                        

                    }

                    
                }
                return eventInfo;

            }
        }


                


    }
}