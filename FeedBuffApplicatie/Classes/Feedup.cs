using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Feedup : Feeditem
    {

        public int Id { get;} 

      public string Description { get; set; }

      public DateTime Creationtime { get; set; }


        public void Feeditem(string description, DateTime creationtime)
        {
            
            Description = description;
            Creationtime = creationtime;
        }

        public Feedup(int id, string creationDate, bool completed, string approvedBy, string reviewedBy, int studentId, int assignmentId, int supervisorId) : base(id, creationDate, completed, approvedBy, reviewedBy, studentId, assignmentId, supervisorId)
        {

        }

    }
}
