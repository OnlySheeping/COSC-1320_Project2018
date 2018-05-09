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

        private string startDate
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string endDate
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


        //  this is the LIST for our TEASER TAB in our "ALL EVENTS" FORM
        public static List<string> GetEventForTeaser()
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();
            

            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Events ORDER BY EventID ASC", conn))
            {
                List<string> teaserEvents = new List<string>();
                SqlDataReader reader = command.ExecuteReader(); 
                //if (reader.HasRows)

                while (reader.Read())
                {
                    string eventName = reader.GetString(reader.GetOrdinal("EventName"));
                    string eventDescription = reader.GetString(reader.GetOrdinal("EventDescription"));
                    string status = reader.GetString(reader.GetOrdinal("Status"));

                    teaserEvents.Add(eventName + " | " + eventDescription + " | " + status);
                }
                return teaserEvents;
                
            }
        }

        public static List<string> ShowEventsForListView()
        {
            //throw new System.NotImplementedException();
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();


            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Events ORDER BY EventID", conn))
            {
                List<string> listEvents = new List<string>();
                SqlDataReader reader = command.ExecuteReader();
                //if (reader.HasRows)

                while (reader.Read())
                {
                    string eventName = reader.GetString(reader.GetOrdinal("EventName"));
                    string status = reader.GetString(reader.GetOrdinal("Status"));
                    string eventDescription = reader.GetString(reader.GetOrdinal("EventDescription"));
                    DateTime rawStartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                    DateTime rawEndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                    TimeSpan rawStartTime = reader.GetTimeSpan(reader.GetOrdinal("StartTime"));
                    TimeSpan rawEndTime = reader.GetTimeSpan(reader.GetOrdinal("EndTime"));
                    string eventNotes = reader.GetString(reader.GetOrdinal("EventNotes"));
                    int rawAgeRequirement = reader.GetInt32(reader.GetOrdinal("AgeRequirement"));
                    int rawCategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID"));
                    short rawPrivateID = reader.GetByte(reader.GetOrdinal("Private"));
                    short rawClosed = reader.GetByte(reader.GetOrdinal("Closed"));
                    string location = reader.GetString(reader.GetOrdinal("Location"));
                    int rawMaxAttendee = reader.GetInt32(reader.GetOrdinal("MaxAttendees"));

                    string startDate = rawStartDate.ToString();
                    string endDate = rawEndDate.ToString();
                    string startTime = rawStartTime.ToString();
                    string endTime = rawEndTime.ToString();
                    string ageRequirement = rawAgeRequirement.ToString();
                    string closed = rawClosed.ToString();
                    string maxAttendee = rawMaxAttendee.ToString();
                    string privateID = rawPrivateID.ToString();
                    string categoryID = rawCategoryID.ToString();

                    listEvents.Add(eventName + " | " + eventDescription + " | " + status +" | "+ startDate +" | "+ endDate +"|"+ startTime + "|" + endTime + "|" + eventNotes + "|" + ageRequirement + "|" + categoryID +"|"+ location +"|"+ maxAttendee );
                }
                return listEvents;

            }
        }

        public static List<string> ShowEventDetail(string theEventName)
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Events where EventName = @eventID", conn))
            {
                List<string> eventInfo = new List<string>();
                // Invoke ExecuteReader method.
                command.Parameters.AddWithValue("@eventID", theEventName);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //UserData();
                    while (reader.Read())
                    {
                        string eventName = reader.GetString(reader.GetOrdinal("EventName"));
                        string status = reader.GetString(reader.GetOrdinal("Status"));
                        string eventDescription = reader.GetString(reader.GetOrdinal("EventDescription"));
                        DateTime rawStartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                        DateTime rawEndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                        TimeSpan rawStartTime = reader.GetTimeSpan(reader.GetOrdinal("StartTime"));
                        TimeSpan rawEndTime = reader.GetTimeSpan(reader.GetOrdinal("EndTime"));
                        string eventNotes = reader.GetString(reader.GetOrdinal("EventNotes"));
                        int rawAgeRequirement = reader.GetInt32(reader.GetOrdinal("AgeRequirement"));
                        int rawCategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID"));
                        short rawPrivateID = reader.GetByte(reader.GetOrdinal("Private"));
                        short rawClosed = reader.GetByte(reader.GetOrdinal("Closed"));
                        string location = reader.GetString(reader.GetOrdinal("Location"));
                        int rawMaxAttendee = reader.GetInt32(reader.GetOrdinal("MaxAttendees"));

                        string startDate = rawStartDate.ToString();
                        string endDate = rawEndDate.ToString();
                        string startTime = rawStartTime.ToString();
                        string endTime = rawEndTime.ToString();
                        string ageRequirement = rawAgeRequirement.ToString();
                        string closed = rawClosed.ToString();
                        string maxAttendee = rawMaxAttendee.ToString();
                        string privateID = rawPrivateID.ToString();
                        string catergoryID = rawCategoryID.ToString();

                        eventInfo.Add(eventName);
                        eventInfo.Add(status);
                        eventInfo.Add(eventDescription);
                        eventInfo.Add(startDate);
                        eventInfo.Add(endDate);
                        eventInfo.Add(startTime);
                        eventInfo.Add(endTime);
                        eventInfo.Add(eventNotes);
                        eventInfo.Add(ageRequirement);
                        eventInfo.Add(catergoryID);
                        eventInfo.Add(privateID);
                        eventInfo.Add(closed);
                        eventInfo.Add(location);
                        eventInfo.Add(maxAttendee);

                        //eventName = eventInfo[0];
                        //status = eventInfo[1];
                        //eventDesciption = eventInfo[2];
                        //startDate = eventInfo[3];
                        //endDate = eventInfo[4];
                        //startTime = eventInfo[5];
                        //endTime = eventInfo[6];
                        //eventNotes = eventInfo[7];
                        //ageRequirement = eventInfo[8];
                        //catergoryID = eventInfo[9];
                        //privateID = eventInfo[10];
                        //closed = eventInfo[11];
                        //location = eventInfo[12];
                        //maxAttendee = eventInfo[13];


                        
                    }

                    
                }
                return eventInfo;

            }
        }

//        // Cameron 
//        public Event(int eid)
//        {
//            Event eid = new Event;
//        }

//        public void event()
//{

//            // this is where we compaire the eventID taken from the for each loop and // compaire it to our eventIDs and post the rest of the data for that event.


//            System.out.printline(EventName + StartDate + StartTime + EndDate + EndTime + location)
//}

//        String [] = new [] String
//Populate[] EventID
//String2[] = new [] String
//Populate 2[]
//        userEventID


//foreach(String[])
//{
//if(userEventID = EventID)
//{
//System.out.printline(eventID.Event())
//}
//}

                


    }
}