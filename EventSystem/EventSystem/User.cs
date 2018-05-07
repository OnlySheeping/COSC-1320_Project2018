using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Input;

namespace EventSystem
{
    public abstract class User
    {
        SqlConnection connection = new SqlConnection();

        private string firstName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string lastName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private int age
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int capacity
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string userLevel
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private Event registeredEvents
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string username
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private string password
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        public int roleID { get; set; }
    }
}
