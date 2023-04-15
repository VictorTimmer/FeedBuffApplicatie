using FeedBuffApplicatie.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.DAL
{
    public class SupervisorDAL
    {
        public List<Supervisor> Supervisors = new List<Supervisor>();
        public string connectionString;
        public DALs dals;
        private string tableName = "Supervisor";

        public SupervisorDAL(string connectionString, DALs dals)
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
                        // Clear out the old list of students (have the new ones)
                        this.Supervisors.Clear();

                        try
                        {
                            while (columns.Read())
                            {
                                // Add relation
                                var baseFeeditem = this.dals.userDAL.Users.Find(user => user.Id == Int32.Parse(columns[1].ToString()));

                                this.Supervisors.Add(new Supervisor(
                                    Int32.Parse(columns[0].ToString()),
                                    baseFeeditem.Firstname,
                                    baseFeeditem.Lastname,
                                    baseFeeditem.Username,
                                    baseFeeditem.Password,
                                    baseFeeditem.Id,
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


        public void Insert(Supervisor supervisor, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO " + tableName + " VALUES(@userId, @workNumber)", connection))
                {

                    // Make sure to add the base user so that the STUDENT row can refer to it
                    supervisor.UserId = this.dals.userDAL.InsertAndReturnId(supervisor);

                    try
                    {
                        command.Parameters.AddWithValue("@userId", supervisor.UserId);
                        command.Parameters.AddWithValue("@workNumber", supervisor.WorkNumber);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

            if (refreshData) GetAll();
        }


        public void Update(Supervisor supervisor, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE " + tableName + " SET userId = @userId, workNumber = @workNumber WHERE id = @id", connection))
                {
                    this.dals.userDAL.Update(supervisor);

                    try
                    {
                        command.Parameters.AddWithValue("@id", supervisor.Id);
                        command.Parameters.AddWithValue("@userId", supervisor.UserId);
                        command.Parameters.AddWithValue("@workNumber", supervisor.WorkNumber);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }


        public void Delete(Supervisor student, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + tableName + " WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", student.Id);
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
