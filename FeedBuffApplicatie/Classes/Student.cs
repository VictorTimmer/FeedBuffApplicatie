using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Student : User
    {
        public new int Id { get; }
        public int UserId { get; set; }
        public string StudentNumber { get; set; }

        public Student(int id, string firstname, string lastname, string username, string password, int userId, string studentNumber) : base(userId, firstname, lastname, username, password)
        {
            Id = id;
            UserId = userId;
            StudentNumber = studentNumber;
        }


        public void AddStudent()
        { 
        
        }
    }
}
