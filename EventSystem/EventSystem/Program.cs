using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
    }
        //class UserData
        //{
        //    SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10");
        //    SqlCommand cmd = new System.Data.SqlClient.SqlCommand("select * from Project1.dbo.Users", conn);
        //}
    }
        
}
