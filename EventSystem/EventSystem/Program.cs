using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Relegate;

namespace EventSystem
{
    static class Program
    {


   //     public static List<test1> student = new List<test1>();                                        //change below where the database is
        public static SqlConnection conn = new SqlConnection(@"Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {



            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LogOn());
        }
    }
}

