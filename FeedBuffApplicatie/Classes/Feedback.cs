using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Feedback : Feeditem
    {

        public int FeeditemId { get; set; }
        public string Notes { get; set; }


        public Feedback(int id, DateTime creationDate, bool completed, int approvedBy, int assignmentId, int supervisorId, int studentId, string contents, int feeditemId, string notes) : base(feeditemId, creationDate, completed, approvedBy, assignmentId, supervisorId, studentId, contents)
        {
            Id = id;
            FeeditemId = feeditemId;
            Notes = notes;
        }

    }
}
