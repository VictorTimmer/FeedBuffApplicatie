using FeedBuffApplicatie.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuffApplicatie.DAL
{
    public class StudentDAL
    {
        public List<Student> Students = new List<Student>();
        public string connectionString;
        public DALs dals;

        public StudentDAL(string connectionString, DALs dals)
        {
            this.connectionString = connectionString;
            this.dals = dals;

            GetAllStudents();
        }

        public void GetAllStudents()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Student ORDER BY id", connection))
                {
                    using (SqlDataReader columns = command.ExecuteReader())
                    {
                        // Clear out the old list of assignment (have the new ones)
                        this.Students.Clear();

                        try
                        {
                            while (columns.Read())
                            {
                                this.Students.Add(new Student(
                                    Int32.Parse(columns[0].ToString()),
                                    columns[1].ToString(),
                                    columns[2].ToString(),
                                    columns[3].ToString(),
                                    columns[5].ToString(),
                                    Int32.Parse(columns[6].ToString())
                                ));
                            }
                        }
                        catch (SqlException error) { throw error; }
                        finally { connection.Dispose(); }
                    }
                }
            }
        }


        public void InsertStudent(Student student, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Student VALUES(@firstname, @lastname, @username, @password, @studentnumber)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@firstname", student.Firstname);
                        command.Parameters.AddWithValue("@lastname", student.Lastname);
                        command.Parameters.AddWithValue("@username", student.Username);
                        command.Parameters.AddWithValue("@password", student.Password);
                        command.Parameters.AddWithValue("@studetnumber", student.StudentNumber);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

            if (refreshData) GetAllStudents();
        }


        public void UpdateStudent(Student student, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Student SET firstname = @firstname, lastname = @lastname, username = @username password = @password, studentnumber = @studentnumber WHERE id = @id", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", student.Id);
                        command.Parameters.AddWithValue("@Firstname", student.Firstname);
                        command.Parameters.AddWithValue("@Lastname", student.Lastname);
                        command.Parameters.AddWithValue("@Username", student.Username);
                        command.Parameters.AddWithValue("@Password", student.Password);
                        command.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAllStudents();
        }


        public void DeleteStudent(Student student, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Student WHERE id = @id", connection))
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
            if (refreshData) GetAllStudents();
        }

    }
}
