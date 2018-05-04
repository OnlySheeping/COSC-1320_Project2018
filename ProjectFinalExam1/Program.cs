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
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Prac\TestAssembly\ForumsProjectCSharp\App_Data\Studetnt.mdf;Integrated Security=True;User Instance=True");
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
                        ID = dr.GetInt32(dr.GetOrdinal("ID")),  // GetOrdinal grabs information in the columns that are specified in quotes.
                        Name = dr.GetString(dr.GetOrdinal("Name")),  // The GetString, GetInt32, and GetDateTime are relevant to the types of information  you're getting.
                        DateOfBirth = dr.GetDateTime(dr.GetOrdinal("DateOfBirth"))
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
