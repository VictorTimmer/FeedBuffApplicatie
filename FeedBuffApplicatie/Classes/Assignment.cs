using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Assignment
    {
        public int Id { get; } 
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool Completed {get; set; }


        public Assignment(int id, string description, DateTime deadline, bool completed)
        {
            Id = id;
            Description = description;
            Deadline = deadline;
            Completed = completed;
        }

        public void AddAssigment()
        { 
        
        }
    }
}
