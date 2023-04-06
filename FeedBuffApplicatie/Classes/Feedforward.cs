using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Feedforward : Feeditem
    {

        public int Id { get; set; }
        public string Description { get; set; } 

        public DateTime CreationTime { get; set; }
        public string CreatedBy { get; set; }

        public Feedforward(int id, string description, DateTime creationTime, string createdBy)
        {
            Id = id;
            Description = description;
            CreationTime = creationTime;
            CreatedBy = createdBy;
        }
        public Feedforward(int id, string description, DateTime creationTime, string createdBy) : base (id,description,creationTime, createdBy )
        {
          
        }


    }
}
