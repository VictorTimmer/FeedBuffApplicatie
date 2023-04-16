using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Feeditem
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Completed { get; set; }
        public int ApprovedBy { get; set; }
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }
        public int SupervisorId { get; set; }
        public string Contents { get; set; }


        public Feeditem(int id, DateTime creationDate, bool completed, int approvedBy, int studentId, int assignmentId, int supervisorId, string contents)
        {
            Id = id;
            CreationDate = creationDate;
            Completed = completed;
            ApprovedBy = approvedBy;
            AssignmentId = assignmentId;
            SupervisorId = supervisorId;
            StudentId = studentId;
            Contents = contents;
        }


        public void AddFeedItem()
        {
        
        }
    }
}
