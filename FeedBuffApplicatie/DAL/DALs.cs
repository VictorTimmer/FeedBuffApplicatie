using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.DAL
{
    public class DALs
    {
        private static string computerName = "DESKTOP-KT5DRA5";

        public string connectionString = "Data Source=" + computerName + "\\SQLEXPRESS;Initial Catalog=FeedBUFF;Integrated Security=True";
        
        //public AssignmentDAL assignmentDAL;
        //public UserDAL userDAL;
        //public StudentDAL studentDAL;


        public FeeditemDAL feeditemDAL;

        public FeedforwardDAL feedforwardDAL;
        public FeedbackDAL feedbackDAL;
        public FeedupDAL feedupDAL;



        public DALs() 
        {
            //this.assignmentDAL = new AssignmentDAL(connectionString, this);
            //this.userDAL = new UserDAL(connectionString, this);
            //this.studentDAL = new StudentDAL(connectionString, this);

            this.feeditemDAL = new FeeditemDAL(connectionString, this);
            this.feedforwardDAL = new FeedforwardDAL(connectionString, this);
            this.feedbackDAL = new FeedbackDAL(connectionString, this);
            this.feedupDAL = new FeedupDAL(connectionString, this);
        }
    }
}
