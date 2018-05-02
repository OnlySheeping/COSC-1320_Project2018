using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;

namespace EventSystem
{
    public class EventAdmin : User
    {
        SqlConnection connection = new SqlConnection();

        public void NewParticipant(string userName, string password,
            string firstName, string lastName, int age, int roleID)
        {
            //Server=myServerAddress;Database=myDataBase;
            // User Id=myUsername;Password = myPassword;
            connection.ConnectionString =
                "Server=cis1.actx.edu;Database=db_owner;User Id=db1;Password = db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);
            Console.ReadKey();

            // SQL INSERT Statement: 
            using (SqlCommand newparticipant = connection.CreateCommand())
            {
                newparticipant.CommandText = "insert ";
                newparticipant.CommandText += "into db_owner.Users";
                newparticipant.CommandText += "values ";
                newparticipant.CommandText += "('";
                newparticipant.CommandText += userName;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += password;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += firstName;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += lastName;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += age;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += roleID;
                newparticipant.CommandText += "');";
                newparticipant.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteParticipant(string userName, 
            string firstName, string lastName)
        {
            //Server=myServerAddress;Database=myDataBase;
            // User Id=myUsername;Password = myPassword;
            connection.ConnectionString = 
                "Server=cis1.actx.edu;Database=db_owner;User Id=db1;Password = db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);
            Console.ReadKey();

            // SQL DELETE Statement: 
            using (SqlCommand deleteparticipant = connection.CreateCommand())
            {
                deleteparticipant.CommandText = "delete ";
                deleteparticipant.CommandText += "from db_owner.Event ";
                deleteparticipant.CommandText += "where Username = ";
                deleteparticipant.CommandText += "'";
                deleteparticipant.CommandText += userName;
                deleteparticipant.CommandText += "'";
                deleteparticipant.CommandText += " and UserFirstName = ";
                deleteparticipant.CommandText += "'";
                deleteparticipant.CommandText += firstName;
                deleteparticipant.CommandText += "'";
                deleteparticipant.CommandText += " and UserLastName = ";
                deleteparticipant.CommandText += "'";
                deleteparticipant.CommandText += lastName;
                deleteparticipant.CommandText += "';";
                connection.Open();
                deleteparticipant.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EditParticipant(string password, string firstName,
            string lastName, int age, string userName)
        {
            {
                //Server=myServerAddress;Database=myDataBase;
                // User Id=myUsername;Password = myPassword;
                connection.ConnectionString =
                    "Server=cis1.actx.edu;Database=db_owner;User Id=db1;Password = db10;";
                connection.Open();
                Console.WriteLine(connection.ServerVersion);
                Console.ReadKey();

                // SQL EDIT-UPDATE Statement:
                using (SqlCommand editparticipant = connection.CreateCommand())
                {
                    editparticipant.CommandText = "update ";
                    editparticipant.CommandText += "db_owner.Users ";
                    editparticipant.CommandText += "set (Password = '" + password;
                    editparticipant.CommandText += ",' UserFirstName ='" + firstName;
                    editparticipant.CommandText += ",' UserLastName ='" + lastName;
                    editparticipant.CommandText += ",' UserAge ='" + age;
                    editparticipant.CommandText += "');";
                    editparticipant.CommandText += "where Username = ";
                    editparticipant.CommandText += "'";
                    editparticipant.CommandText += userName;
                    editparticipant.CommandText += "';";
                    connection.Open();
                    editparticipant.ExecuteNonQuery();
                    connection.Close();
                }

            }
        }

        public void RegisterParticipant(int eventID, string userName,
            double dateRegistered)
        {
            {
                //Server=myServerAddress;Database=myDataBase;
                // User Id=myUsername;Password = myPassword;
                connection.ConnectionString =
                    "Server=cis1.actx.edu;Database=db_owner;User Id=db1;Password = db10;";
                connection.Open();
                Console.WriteLine(connection.ServerVersion);
                Console.ReadKey();

                // SQL INSERT Statement: 
                using (SqlCommand regparticipant = connection.CreateCommand())
                {
                    regparticipant.CommandText = "insert ";
                    regparticipant.CommandText += "into db_owner.Event_Users";
                    regparticipant.CommandText += "values ";
                    regparticipant.CommandText += "('";
                    regparticipant.CommandText += eventID;
                    regparticipant.CommandText += "','";
                    regparticipant.CommandText += userName;
                    regparticipant.CommandText += "','";
                    regparticipant.CommandText += dateRegistered;
                    regparticipant.CommandText += "');";
                    regparticipant.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void DeleteEvent(string eventID, string eventName)
        {
            //Server=myServerAddress;Database=myDataBase;
            // User Id=myUsername;Password = myPassword;
            connection.ConnectionString = 
                "Server=cis1.actx.edu;Database=db_owner;User Id=db1;Password = db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);
            Console.ReadKey();

            // SQL DELETE Statement: 
            using (SqlCommand deleteevent = connection.CreateCommand())
            {
                deleteevent.CommandText = "delete ";
                deleteevent.CommandText += "from db_owner.Event ";
                deleteevent.CommandText += "where ";
                deleteevent.CommandText += "EventID = ";
                deleteevent.CommandText += "'";
                deleteevent.CommandText += eventID;
                deleteevent.CommandText += "'";
                deleteevent.CommandText += "and ";
                deleteevent.CommandText += "EventName = ";
                deleteevent.CommandText += "'";
                deleteevent.CommandText += eventName;
                deleteevent.CommandText += "';";
                connection.Open();
                deleteevent.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EditEvent(string eventName, string status,
            string eventDescription, double startDate, double endDate,
            string eventNotes, int ageRequirement, int categoryID,
            int privateVal, int closed, string location, 
            int maxAttendees, string eventID)
        {
            //Server=myServerAddress;Database=myDataBase;
            // User Id=myUsername;Password = myPassword;
            connection.ConnectionString = 
                "Server=cis1.actx.edu;Database=db_owner;User Id=db1;Password = db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);
            Console.ReadKey();

            // SQL EDIT-UPDATE Statement:
            using (SqlCommand editevent = connection.CreateCommand())
            {
                editevent.CommandText = "update ";
                editevent.CommandText += "db_owner.Event ";
                editevent.CommandText += "set (EventName = '" + eventName;
                editevent.CommandText += ",' Status ='" + status;
                editevent.CommandText += ",' EventDescription ='" + eventDescription;
                editevent.CommandText += ",' StartDate ='" + startDate;
                editevent.CommandText += ",' EndDate ='" + endDate;
                editevent.CommandText += ",' EventNotes ='" + eventNotes;
                editevent.CommandText += ",' AgeRequirement ='" + ageRequirement;
                editevent.CommandText += ",' CategoryID ='" + categoryID;
                editevent.CommandText += ",' Private ='" + privateVal;
                editevent.CommandText += ",' Closed ='" + closed;
                editevent.CommandText += ",' Location ='" + location;
                editevent.CommandText += ",' MaxAttendees ='" + maxAttendees;
                editevent.CommandText += "');";
                editevent.CommandText += "where EventID = ";
                editevent.CommandText += "'";
                editevent.CommandText += eventID;
                editevent.CommandText += "';";
                connection.Open();
                editevent.ExecuteNonQuery();
                connection.Close();
            }

        }

        public void ShowOwnedEvents()
        {
            throw new System.NotImplementedException();
        }
    }
}