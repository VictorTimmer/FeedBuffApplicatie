﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FeedBuffApplicatie.Classes
{
    public class User
    {
        public int Id { get; } 
        public string Firstname { get; set; }
        public string Lastname { get; set; }




        public User(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }


        public void AddUser() 
        {
        
        }

    }
}
