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
    public class FeeditemDAL
    {
        public List<Feeditem> Feeditems = new List<Feeditem>();
        public string connectionString;
        private DALs dals;
        private string tableName = "FeedItem";

        public FeeditemDAL(string connectionString, DALs dals)
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
                        this.Feeditems.Clear();

                        try
                        {
                            while (columns.Read())
                            {
                                this.Feeditems.Add(new Feeditem(
                                    Int32.Parse(columns[0].ToString()),
                                    DateTime.Parse(columns[1].ToString()),
                                    Boolean.Parse(columns[2].ToString()),
                                    Int32.Parse(columns[3].ToString()),
                                    Int32.Parse(columns[4].ToString()),
                                    Int32.Parse(columns[5].ToString()),
                                    Int32.Parse(columns[6].ToString()),
                                    columns[7].ToString()
                                ));
                            }
                        }
                        catch (SqlException error) { throw error; }
                        finally { connection.Dispose(); }
                    }
                }
            }
        }


        public void Insert(Feeditem feeditem, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO " + tableName + " VALUES(@creationDate, @completed, @approvedBy, @assignmentId, @supervisorId, @studentId, @contents)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@creationDate", feeditem.CreationDate);
                        command.Parameters.AddWithValue("@completed", feeditem.Completed);
                        command.Parameters.AddWithValue("@approvedBy", feeditem.ApprovedBy);
                        command.Parameters.AddWithValue("@assignmentId", feeditem.AssignmentId);
                        command.Parameters.AddWithValue("@supervisorId", feeditem.SupervisorId);
                        command.Parameters.AddWithValue("@studentId", feeditem.StudentId);
                        command.Parameters.AddWithValue("@contents", feeditem.Contents);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

            if (refreshData) GetAll();
        }

        public int InsertAndReturnId(Feeditem feeditem, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO " + tableName + " OUTPUT INSERTED.ID VALUES(@creationDate, @completed, @approvedBy, @assignmentId, @supervisorId, @studentId, @contents)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@creationDate", feeditem.CreationDate);
                        command.Parameters.AddWithValue("@completed", feeditem.Completed);
                        command.Parameters.AddWithValue("@approvedBy", feeditem.ApprovedBy);
                        command.Parameters.AddWithValue("@assignmentId", feeditem.AssignmentId);
                        command.Parameters.AddWithValue("@supervisorId", feeditem.SupervisorId);
                        command.Parameters.AddWithValue("@studentId", feeditem.StudentId);
                        command.Parameters.AddWithValue("@contents", feeditem.Contents);
                        int modified = (int)command.ExecuteScalar();
                        return modified;
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }



        public void Update(Feeditem feeditem, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE " + tableName + " SET creationDate = @creationDate, completed = @completed, approvedBy = @approvedBy, assignmentId = @assignmentId, supervisorId = @supervisorId, studentId = @studentId, contents = @contents WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", feeditem.Id);
                        command.Parameters.AddWithValue("@creationDate", feeditem.CreationDate);
                        command.Parameters.AddWithValue("@completed", feeditem.Completed);
                        command.Parameters.AddWithValue("@approvedBy", feeditem.ApprovedBy);
                        command.Parameters.AddWithValue("@assignmentId", feeditem.AssignmentId);
                        command.Parameters.AddWithValue("@supervisorId", feeditem.SupervisorId);
                        command.Parameters.AddWithValue("@studentId", feeditem.StudentId);
                        command.Parameters.AddWithValue("@contents", feeditem.Contents);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }

        public void Delete(Feeditem feeditem, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + tableName + " WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", feeditem.Id);
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
