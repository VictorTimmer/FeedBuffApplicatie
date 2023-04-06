using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Feedback : Feeditem
    {

        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreationTime { get; set; }


        public void  Feeditem(string description, string status, DateTime creationTime)
        {
            
            Description = description;
            Status = status;
            CreationTime = creationTime;
        }

        public Feedback(int id, string creationDate, bool completed, string approvedBy, string reviewedBy, int studentId, int assignmentId, int supervisorId) : base(id, creationDate, completed, approvedBy, reviewedBy, studentId, assignmentId, supervisorId)
        {
        }


        public void AddFeedback()
        { 
        
        }



    }
}
