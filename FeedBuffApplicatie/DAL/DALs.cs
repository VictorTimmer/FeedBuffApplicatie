﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.DAL
{
    public class DALs
    {
        private static string computerName = "MSI";

        public string connectionString = "Data Source=.;Initial Catalog=FeedBUFF;Integrated Security=True";
        
        public AssignmentDAL assignmentDAL;
        public UserDAL userDAL;
        public StudentDAL studentDAL;
        public SupervisorDAL supervisorDAL;

        public FeeditemDAL feeditemDAL;

        public FeedforwardDAL feedforwardDAL;
        public FeedbackDAL feedbackDAL;
        public FeedupDAL feedupDAL;



        public DALs() 
        {
            // THE ORDER MATTERS HERE - PLEASE DONT EDIT (only add to the list)
            this.assignmentDAL = new AssignmentDAL(connectionString, this);

            this.userDAL = new UserDAL(connectionString, this);
            this.studentDAL = new StudentDAL(connectionString, this);
            this.supervisorDAL = new SupervisorDAL(connectionString, this);

            this.feeditemDAL = new FeeditemDAL(connectionString, this);
            this.feedforwardDAL = new FeedforwardDAL(connectionString, this);
            this.feedbackDAL = new FeedbackDAL(connectionString, this);
            this.feedupDAL = new FeedupDAL(connectionString, this);
        }
    }
}
