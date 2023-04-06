using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Supervisor
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int WorkNumber { get; set; }

        public Supervisor(int id, string firstname, string lastname, string username, string password, int workNumber)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            WorkNumber = workNumber;
        }


        public void AddSupervisor()
        { 

        }
    }
}
