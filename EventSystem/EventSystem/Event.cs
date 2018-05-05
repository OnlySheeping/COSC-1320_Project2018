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
        SqlConnection connection = new SqlConnection();
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

        public void ShowEventsForTeaserView()
        {
            //SELECT CategoryDescription, EventName
            //    FROM Project1.dbo.Categories, Project1.dbo.Events
            //    Order By CategoryDescription, EventName ASC;
            using (SqlCommand command =
                new SqlCommand
                ("SELECT CategoryDescription, EventName " +
                "FROM dbo.Categories.CategoryID = dbo.Events.CategoryID " +
                "ORDER BY CategoryDescription ASC, EventName ASC;", Program.conn))
            {
                //
                // Invoke ExecuteReader method.
                //
                //command.Parameters.AddWithValue("@username", tbUserName.Text);
                //command.Parameters.AddWithValue("@password", tbPassword.Text);


                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //UserData();
                    while (reader.Read())
                    {
                        string categoryDescription =
                            reader.GetString(reader.GetOrdinal("CategoryDescription"));
                        string eventName =
                            reader.GetString(reader.GetOrdinal("EventName"));

                    }
                }
            }
        }

        public void ShowEventsForListView()
        {
            throw new System.NotImplementedException();
        }

        public void ShowEventDetail()
        {
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
    }

    }
}