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
                                    columns[2].ToString(),
                                    columns[3].ToString(),
                                    columns[4].ToString()
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

                using (SqlCommand command = new SqlCommand("INSERT INTO User VALUES(@firstname, @lastname, @username, @password)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@firstname", user.Firstname);
                        command.Parameters.AddWithValue("@lastname", user.Lastname);
                        command.Parameters.AddWithValue("@username", user.Username);
                        command.Parameters.AddWithValue("@password", user.Password);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }

        public int InsertAndReturnId(User user, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO User OUTPUT INSERTED.ID VALUES(@firstname, @lastname, @username, @password)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@firstname", user.Firstname);
                        command.Parameters.AddWithValue("@lastname", user.Lastname);
                        command.Parameters.AddWithValue("@username", user.Username);
                        command.Parameters.AddWithValue("@password", user.Password);
                        int modified = (int)command.ExecuteScalar();
                        return modified;
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
                using (SqlCommand command = new SqlCommand("UPDATE User SET firstname = @firstname, lastname = @lastname, username = @username, password = @password WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", user.Id);
                        command.Parameters.AddWithValue("@firstname", user.Firstname);
                        command.Parameters.AddWithValue("@lastname", user.Lastname);
                        command.Parameters.AddWithValue("@username", user.Username);
                        command.Parameters.AddWithValue("@password", user.Password);
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
