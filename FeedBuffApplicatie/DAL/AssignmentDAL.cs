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
    public class AssignmentDAL
    {
        public List<Assignment> Assignments = new List<Assignment>();
        public string connectionString;
        public DALs dals;

        public AssignmentDAL(string connectionString, DALs dals)
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM Assignment ORDER BY id", connection))
                {
                    using (SqlDataReader columns = command.ExecuteReader())
                    {
                        // Clear out the old list of assignment (have the new ones)
                        this.Assignments.Clear();

                        try
                        {
                            while (columns.Read())
                            {
                                this.Assignments.Add(new Assignment(
                                    Int32.Parse(columns[0].ToString()),
                                    columns[1].ToString(),
                                    DateTime.Parse(columns[2].ToString()),
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


        public void Insert(Assignment assignment, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Assignment VALUES(@description, @deadline, @completed)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@description", assignment.Description);
                        command.Parameters.AddWithValue("@deadline", assignment.Deadline);
                        command.Parameters.AddWithValue("@completed", assignment.Completed);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

            if (refreshData) GetAll();
        }



        public void Update(Assignment assignment, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Assignment SET description = @description, deadline = @deadline, completed = @completed WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", assignment.Id);
                        command.Parameters.AddWithValue("@description", assignment.Description);
                        command.Parameters.AddWithValue("@deadline", assignment.Deadline);
                        command.Parameters.AddWithValue("@completed", assignment.Completed);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }

        public void Delete(Assignment assignment, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Assignment WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", assignment.Id);
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
