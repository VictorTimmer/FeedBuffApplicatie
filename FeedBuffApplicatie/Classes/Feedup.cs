using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Feedup : Feeditem
    {

        public int FeeditemId { get; set; }
        public int Priority { get; set; }
        public string Reflection { get; set; }


        public Feedup(int id, DateTime creationDate, bool completed, int approvedBy, int assignmentId, int supervisorId, int studentId, string contents, int feeditemId, int priority, string reflection) : base(id, creationDate, completed, approvedBy, assignmentId, supervisorId, studentId, contents)
        {
            FeeditemId = feeditemId;
            Priority = priority;
            Reflection = reflection;
        }
    }
}
