using FeedBuffApplicatie.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.DAL
{
    public class UserDAL
    {
        public List<User> Users = new List<User>();
        public string connectionString;
        public DALs dals;

        public UserDAL(string connectionString, DALs dals)
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM User ORDER BY id", connection))
                {
                    using (SqlDataReader columns = command.ExecuteReader())
                    {
                        // Clear out the old list of assignment (have the new ones)
                        this.Users.Clear();

                        try
                        {
                            {
                                this.Users.Add(new User(
                                    Int32.Parse(columns[0].ToString()),
                                    columns[1].ToString(),
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


        public void Insert(User user, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO User VALUES(@firstname, @creationTime, @reflection, @priority, @completed, @supergoal)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@firstname", user.Firstname);
                        command.Parameters.AddWithValue("@Lastname", user.Lastname);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }



        public void Update(User user, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Studygoal SET firstname = @firstname, lastname = @lastname WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", user.Id);
                        command.Parameters.AddWithValue("@description", user.Firstname);
                        command.Parameters.AddWithValue("@deadline", user.Lastname);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }

        public void Delete(User user, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM User WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", user.Id);
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
