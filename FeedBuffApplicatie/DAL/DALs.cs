using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.DAL
{
    public class DALs
    {
        private static string computerName = "DESKTOP-KT5DRA5";

        public string connectionString = "Data Source=" + computerName + "\\SQLEXPRESS;Initial Catalog=Kassasysteem;Integrated Security=True";
        
        public AssignmentDAL assignmentDAL;
        public StudygoalDAL studygoalDAL;
        public UserDAL userDAL;
        public FeeditemDAL feeditemDAL;


        public DALs() 
        {
            this.assignmentDAL = new AssignmentDAL(connectionString, this);
            this.studygoalDAL = new StudygoalDAL(connectionString, this);
            this.userDAL = new UserDAL(connectionString, this);
            //this.feeditemDAL = new FeeditemDAL(connectionString, this);
        }
    }
}
