using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Studygoal
    {
        public int Id { get; }
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
        
        public string Reflection { get; set; }
        public int Priority { get; set; }
        public string Completed { get; set; }
        public string Supergoal { get; set; }

        public Studygoal(int id, string description, DateTime creationTime, string reflection, int priority, string completed, string supergoal)
        {
            Id = id;
            Description = description;
            CreationTime = creationTime;
            Reflection = reflection;
            Priority = priority;
            Completed = completed;
            Supergoal = supergoal;
        }

        public void AddStudygoal()
        { 
        }
    }
}
