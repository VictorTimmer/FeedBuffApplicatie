using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Feeditem
    {
        public int Id { get; }
        public string CreationDate { get; set; }

        public bool Completed { get; set; }

        public string ApprovedBy { get; set; }

        public string ReviewedBy { get; set; }

        public int StudentId { get; set; }
       
        public int AssignmentId { get; set; }

        public int SupervisorId { get; set; }

        public List<Feedback> feedback = new List<Feedback>();



        public Feeditem(int id, string creationDate, bool completed, string approvedBy, string reviewedBy, int studentId, int assignmentId, int supervisorId)
        {
            Id = id;
            CreationDate = creationDate;
            Completed = completed;
            ApprovedBy = approvedBy;
            ReviewedBy = reviewedBy;
            StudentId = studentId;
            AssignmentId = assignmentId;
            SupervisorId = supervisorId;
        }

        public Feeditem(int id, string creationDate, string approvedBy, string reviewedBy, int studentId, int assignmentId, int supervisorId)
        {
            Id = id;
            CreationDate = creationDate;
            ApprovedBy = approvedBy;
            ReviewedBy = reviewedBy;
            StudentId = studentId;
            AssignmentId = assignmentId;
            SupervisorId = supervisorId;
        }


        public void DeleteFeeditem()
        { 
        
        }

    }
}
