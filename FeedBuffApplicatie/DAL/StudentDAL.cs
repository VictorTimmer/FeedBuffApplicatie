﻿using FeedBuffApplicatie.Classes;
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

            GetAll();
        }

        public void GetAll()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Student ORDER BY id", connection))
                {
                    using (SqlDataReader columns = command.ExecuteReader())
                    {
                        // Clear out the old list of students (have the new ones)
                        this.Students.Clear();

                        try
                        {
                            while (columns.Read())
                            {
                                // Add relation
                                var baseFeeditem = this.dals.userDAL.Users.Find(user => user.Id == Int32.Parse(columns[1].ToString()));

                                this.Students.Add(new Student(
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


        public void Insert(Student student, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Student VALUES(@userId, @studentnumber)", connection))
                {

                    // Make sure to add the base user so that the STUDENT row can refer to it
                    student.UserId = this.dals.userDAL.InsertAndReturnId(student);

                    try
                    {
                        command.Parameters.AddWithValue("@userId", student.UserId);
                        command.Parameters.AddWithValue("@studetnumber", student.StudentNumber);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

            if (refreshData) GetAll();
        }


        public void Update(Student student, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Student SET userId = @userId, studentnumber = @studentnumber WHERE id = @id", connection))
                {
                    this.dals.userDAL.Update(student);

                    try
                    {
                        command.Parameters.AddWithValue("@id", student.Id);
                        command.Parameters.AddWithValue("@userId", student.UserId);
                        command.Parameters.AddWithValue("@studetnumber", student.StudentNumber);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            if (refreshData) GetAll();
        }


        public void Delete(Student student, Boolean refreshData = false)
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
            if (refreshData) GetAll();
        }

    }
}
