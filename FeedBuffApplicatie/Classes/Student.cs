using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.Classes
{
    public class Student
    {
        public int Id { get; }
        public string Firstname { get; set; } 
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int StudentNumber { get; set; }



        public Student(int id, string firstname, string lastname, string username, string password, int studentNumber)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            StudentNumber = studentNumber;
        }   

        public void AddStudent()
        { 
        
        }
    }
}
