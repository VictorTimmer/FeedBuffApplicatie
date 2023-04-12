using FeedBuffApplicatie.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.DAL
{
    public class StudygoalDAL
    {
        public List<Studygoal> Studygoals = new List<Studygoal>();
        public string connectionString;
        public DALs dals;

        public StudygoalDAL(string connectionString, DALs dals)
        {
            this.connectionString = connectionString;
            this.dals = dals;

            GetAllStudygoals();
        }

        public void GetAllStudygoals()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Studygoal ORDER BY id", connection))
                {
                    using (SqlDataReader columns = command.ExecuteReader())
                    {
                        // Clear out the old list of assignment (have the new ones)
                        this.Studygoals.Clear();

                        try
                        {
                            while (columns.Read())
                            {
                                this.Studygoals.Add(new Studygoal(
                                    Int32.Parse(columns[0].ToString()),
                                    columns[1].ToString(),
                                    DateTime.Parse(columns[2].ToString()),
                                    columns[3].ToString(),
                                    Int32.Parse(columns[4].ToString()),
                                    columns[5].ToString(),
                                    columns[6].ToString()
                                ));
                            }
                        }
                        catch (SqlException error) { throw error; }
                        finally { connection.Dispose(); }
                    }
                }
            }
        }


        public void InsertStudygoal(Studygoal studygoal, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Studygoal VALUES(@description, @creationTime, @reflection, @priority, @completed, @supergoal)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@description", studygoal.Description);
                        command.Parameters.AddWithValue("@creationTime", studygoal.CreationTime);
                        command.Parameters.AddWithValue("@reflection", studygoal.Reflection);
                        command.Parameters.AddWithValue("@priority", studygoal.Priority);
                        command.Parameters.AddWithValue("@completed", studygoal.Completed);
                        command.Parameters.AddWithValue("@supergoal", studygoal.Supergoal);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAllStudygoals();
        }



        public void UpdateStudygoal(Studygoal studygoal, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Studygoal SET description = @description, creationTime = @creationTime, reflection = @reflection, completed = @completed, supergoal = @supergoal WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@description", studygoal.Description);
                        command.Parameters.AddWithValue("@creationTime", studygoal.CreationTime);
                        command.Parameters.AddWithValue("@reflection", studygoal.Reflection);
                        command.Parameters.AddWithValue("@priority", studygoal.Priority);
                        command.Parameters.AddWithValue("@completed", studygoal.Completed);
                        command.Parameters.AddWithValue("@supergoal", studygoal.Supergoal);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAllStudygoals();
        }

        public void DeleteStudygoal(Studygoal studygoal, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Studygoal WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", studygoal.Id);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAllStudygoals();
        }
    }
}
