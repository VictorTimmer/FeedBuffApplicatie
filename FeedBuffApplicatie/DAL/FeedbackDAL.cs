using FeedBuffApplicatie.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBuffApplicatie.DAL
{
    public class FeedbackDAL
    {
        public List<Feedback> Feedbacks = new List<Feedback>();
        public string connectionString;
        public DALs dals;
        private string tableName = "FeedBack";

        public FeedbackDAL(string connectionString, DALs dals)
        {
            this.connectionString = connectionString;
            this.dals = dals;

            GetAll();
        }

        public void GetAll()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM " + tableName + " ORDER BY id", connection))
                {
                    using (SqlDataReader columns = command.ExecuteReader())
                    {
                        // Clear out the old list of assignment (have the new ones)
                        this.Feedbacks.Clear();

                        try
                        {
                            while (columns.Read())
                            {
                                // Add relation
                                var baseFeeditem = this.dals.feeditemDAL.Feeditems.Find(feeditem => feeditem.Id == Int32.Parse(columns[1].ToString()));

                                this.Feedbacks.Add(new Feedback(
                                    Int32.Parse(columns[0].ToString()),
                                    baseFeeditem.CreationDate,
                                    baseFeeditem.Completed,
                                    baseFeeditem.ApprovedBy,
                                    baseFeeditem.AssignmentId,
                                    baseFeeditem.SupervisorId,
                                    baseFeeditem.StudentId,
                                    baseFeeditem.Contents,
                                    Int32.Parse(columns[1].ToString()),
                                    columns[2].ToString()
                                ));
                            }
                        }
                        catch (SqlException error) { throw error; }
                        finally { connection.Dispose(); }
                    }
                }
            }
        }


        public void Insert(Feedback feedback, Boolean refreshData = false)
        {
            var feeditemId = dals.feeditemDAL.InsertAndReturnId(feedback, refreshData);
            feedback.FeeditemId = feeditemId;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO " + tableName + " VALUES(@feedItemId, @notes)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@feedItemId", feedback.FeeditemId);
                        command.Parameters.AddWithValue("@notes", feedback.Notes);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

            if (refreshData) GetAll();
        }



        public void Update(Feedback feedback, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE " + tableName + " SET feedItemId = @feedItemId, notes = @notes WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", feedback.Id);
                        command.Parameters.AddWithValue("@feedItemId", feedback.FeeditemId);
                        command.Parameters.AddWithValue("@notes", feedback.Notes);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }

        public void Delete(Feedback feedback, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + tableName + " WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", feedback.Id);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }
    }
}
