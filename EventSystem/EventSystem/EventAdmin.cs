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

        SqlConnection connection = new SqlConnection();

        public void NewParticipant(string userName, string password,
            string firstName, string lastName, int userAge, int roleID)
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
                newparticipant.CommandText += "into Project1.dbo.Users";
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
                newparticipant.CommandText += userAge;
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
                "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
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
            string lastName, int userAge, string userName)
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
                    if (Password != null)
                    {
                        editparticipant.CommandText = "update ";
                        editparticipant.CommandText += "Project1.dbo.Users ";
                        editparticipant.CommandText += "set (Passsword = '" + password;
                        editparticipant.CommandText += "');";
                        editparticipant.CommandText += "where Username = ";
                        editparticipant.CommandText += "'";
                        editparticipant.CommandText += userName;
                        editparticipant.CommandText += "';";
                        connection.Open();
                        editparticipant.ExecuteNonQuery();
                        connection.Close();
                    }

                    if (FirstName != null)
                    {
                        editparticipant.CommandText = "update ";
                        editparticipant.CommandText += "Project1.dbo.Users ";
                        editparticipant.CommandText += "set (UserFirstName ='" + firstName;
                        editparticipant.CommandText += "');";
                        editparticipant.CommandText += "where Username = ";
                        editparticipant.CommandText += "'";
                        editparticipant.CommandText += userName;
                        editparticipant.CommandText += "';";
                        connection.Open();
                        editparticipant.ExecuteNonQuery();
                        connection.Close();

                    }

                    if (LastName != null)
                    {
                        editparticipant.CommandText = "update ";
                        editparticipant.CommandText += "Project1.dbo.Users ";
                        editparticipant.CommandText += "set (UserLastName ='" + lastName;
                        editparticipant.CommandText += "');";
                        editparticipant.CommandText += "where Username = ";
                        editparticipant.CommandText += "'";
                        editparticipant.CommandText += userName;
                        editparticipant.CommandText += "';";
                        connection.Open();
                        editparticipant.ExecuteNonQuery();
                        connection.Close();

                    }

                    if (UserAge != null)
                    {
                        editparticipant.CommandText = "update ";
                        editparticipant.CommandText += "Project1.dbo.Users ";
                        editparticipant.CommandText += "set (UserLastName ='" + userAge;
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
                    regparticipant.CommandText += "into Project1.dbo.Event_Users";
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
                deleteevent.CommandText += "from Project1.dbo.Event ";
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
            string eventDescription, string startDate, double endDate,
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
                if (EventName!= null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (EventName = '";
                    editevent.CommandText +=  eventName;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (Status != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (Status = '";
                    editevent.CommandText +=  status;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (EventDescription != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (EventDescription = '";
                    editevent.CommandText +=  eventDescription;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (StartDate != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (StartDate = '";
                    editevent.CommandText += startDate;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (EndDate != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (EndDate = '";
                    editevent.CommandText += endDate;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (EventNotes != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (EventNotes = '";
                    editevent.CommandText += eventNotes;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (AgeRequirement != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (AgeRequirement = '";
                    editevent.CommandText += ageRequirement;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (CategoryID != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (CategoryID = '";
                    editevent.CommandText += categoryID;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (CategoryID != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (CategoryID = '";
                    editevent.CommandText += categoryID;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (Private != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (Private = '";
                    editevent.CommandText += privateVal;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (Closed != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (Closed = '";
                    editevent.CommandText += closed;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (Location != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (Location = '";
                    editevent.CommandText += location;
                    editevent.CommandText += "');";
                    editevent.CommandText += "where EventID = ";
                    editevent.CommandText += "'";
                    editevent.CommandText += eventID;
                    editevent.CommandText += "';";
                    connection.Open();
                    editevent.ExecuteNonQuery();
                    connection.Close();
                }

                if (MaxAttendees != null)
                {
                    editevent.CommandText = "update ";
                    editevent.CommandText += "Project1.dbo.Event ";
                    editevent.CommandText += "set (MaxAttendees = '";
                    editevent.CommandText += maxAttendees;
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

        }

        public void AddEvent(string eventName, string status,
            string eventDescription, string startDate, 
            string endDate, string startTime, string endTime,
            string eventNotes, int ageRequirement, 
            int categoryID, int privateVal, string closed,
            string location, int maxAttendees)
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
                newparticipant.CommandText += "into Project1.dbo.Users";
                newparticipant.CommandText += "values ";
                newparticipant.CommandText += "('";
                newparticipant.CommandText += eventName;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += status;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += eventDescription;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += startDate;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += endDate;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += startTime;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += endTime;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += startDate;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += eventNotes;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += ageRequirement;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += categoryID;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += privateVal;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += closed;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += location;
                newparticipant.CommandText += "','";
                newparticipant.CommandText += maxAttendees;
                newparticipant.CommandText += "');";
                newparticipant.ExecuteNonQuery();
                connection.Close();
            }
        }

        public string GetFullView()
        {
            throw new System.NotImplementedException();
        }

        public string PartialView()
        {
            throw new System.NotImplementedException();
        }
        public string GetListView()
        {
            throw new System.NotImplementedException();
        }
    }
}