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
    public class FeedupDAL
    {
        public List<Feedup> Feedups = new List<Feedup>();
        public string connectionString;
        public DALs dals;
        private string tableName = "FeedUp";

        public FeedupDAL(string connectionString, DALs dals)
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
                        this.Feedups.Clear();

                        try
                        {
                            while (columns.Read())
                            {
                                // Add relation
                                var baseFeeditem = this.dals.feeditemDAL.Feeditems.Find(feeditem => feeditem.Id == Int32.Parse(columns[1].ToString()));

                                this.Feedups.Add(new Feedup(
                                    Int32.Parse(columns[0].ToString()),
                                    baseFeeditem.CreationDate,
                                    baseFeeditem.Completed,
                                    baseFeeditem.ApprovedBy,
                                    baseFeeditem.AssignmentId,
                                    baseFeeditem.SupervisorId,
                                    baseFeeditem.StudentId,
                                    baseFeeditem.Contents,
                                    Int32.Parse(columns[1].ToString()),
                                    Int32.Parse(columns[2].ToString()),
                                    columns[3].ToString()
                                ));
                            }
                        }
                        catch (SqlException error) { throw error; }
                        finally { connection.Dispose(); }
                    }
                }
            }
        }


        public void Insert(Feedup feedup, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO " + tableName + " VALUES(@feedItemId, @priority, @reflection)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@feedItemId", feedup.FeeditemId);
                        command.Parameters.AddWithValue("@priority", feedup.Priority);
                        command.Parameters.AddWithValue("@reflection", feedup.Reflection);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

            if (refreshData) GetAll();
        }



        public void Update(Feedup feedup, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE " + tableName + " SET feedItemId = @feedItemId, priority = @priority, reflection = @reflection WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", feedup.Id);
                        command.Parameters.AddWithValue("@feedItemId", feedup.FeeditemId);
                        command.Parameters.AddWithValue("@priority", feedup.Priority);
                        command.Parameters.AddWithValue("@reflection", feedup.Reflection);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }

        public void Delete(Feedup feedup, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + tableName + " WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", feedup.Id);
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
