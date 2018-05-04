//Danny Pina
//COSC1320-002
//Final Exam Project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectFinalExam1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            List<test> student = new List<test>();                                        //change below where the database is
            SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
            SqlCommand cmd = new SqlCommand("select * from Student", conn);
            SqlDataReader dr;               //change above to * what your grabbing from the database
            try
            {
                conn.Open(); // Opening a connection to the database.
                dr = cmd.ExecuteReader();  // Gives dr the ability to store the information from the commands.
                while (dr.Read()) // Creates a loop to keep reading as long as there's information in the database.
                {
                    student.Add(new test() // This would reference the class where you have your Array.
                    {
                        RoleID = dr.GetInt32(dr.GetOrdinal("RoleID")),  // GetOrdinal grabs information in the columns that are specified in quotes.
                        Username = dr.GetString(dr.GetOrdinal("Username")),
                        UserFirstName = dr.GetString(dr.GetOrdinal("UserFirstName")),  // The GetString, GetInt32, and GetDateTime are relevant to the types of information  you're getting.
                        UserLastName = dr.GetString(dr.GetOrdinal("UserLastName")),
                        Age = dr.GetInt32(dr.GetOrdinal("Age")),

                        
                    });

                }
                dr.Close();  // Stops DR.
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                conn.Close(); // Closes the connection.
                              }
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogOn());
        }
    }
}
