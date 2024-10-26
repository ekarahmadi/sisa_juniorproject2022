﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISA
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public virtual bool Login()
        {
            // Login logic (check username and password)
            return true;
        }
        public virtual void ProcessWasteReport()
        {
            Console.WriteLine("Processing waste report in a generic way.");
        }
    }
}
