using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Supervisor : User
    {
        public new int Id { get; }
        public int UserId { get; set; }
        public string WorkNumber { get; set; }

        public Supervisor(int id, string firstname, string lastname, string username, string password, int userId, string workNumber) : base(userId, firstname, lastname, username, password)
        {
            Id = id;
            UserId = userId;
            WorkNumber = workNumber;
        }
    }
}
