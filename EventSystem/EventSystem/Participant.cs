using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;

namespace EventSystem
{
    public class Participant : User
    {
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserAge { get; set; }
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


        // Programmer: Julain created logic & Diana B added the sql statement.
        public static List<string> GetAllParticipants()
        {
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            conn.Open();

            // Sql Statement String:
            string strSQL;

            strSQL = "SELECT UPPER(Event_Users.UserName) AS Participants" +
                     "Event_Users.DateRegistered, Events.Location " +
                     "FROM Event_Users" +
                     "INNER JOIN Events ON Event_Users.EventID = Events.EventID" +
                     "ORDER BY UserName ASC, DateRegistered ASC";

            // SQL placed strSQL in SqlCommand
            using (SqlCommand command = new SqlCommand(strSQL, conn))
            {
                List<string> allParticipants = new List<string>();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string participants = reader.GetString(reader.GetOrdinal("Participants"));
                    string dateRegistered = reader.GetString(reader.GetOrdinal("DateRegistered"));
                    string location = reader.GetString(reader.GetOrdinal("Location"));

                    allParticipants.Add(participants + " | " + dateRegistered + " | " + location);
                }
                return allParticipants;

            }
        }

    }
}