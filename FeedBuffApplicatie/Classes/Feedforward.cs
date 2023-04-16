using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Feedforward : Feeditem
    {

        public int FeeditemId { get; set; }


        public Feedforward(int id, DateTime creationDate, bool completed, int approvedBy, int assignmentId, int supervisorId, int studentId, string contents, int feeditemId) : base(feeditemId, creationDate, completed, approvedBy, assignmentId, supervisorId, studentId, contents)
        {
            Id = id;
            FeeditemId = feeditemId;
        }
    }
}
