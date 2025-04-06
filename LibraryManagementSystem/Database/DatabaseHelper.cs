using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace LibraryManagementSystem.Database
{
    public class DatabaseHelper
    {
        private string _connectionString;

        public DatabaseHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;
        }

        public List<string> GetBooks()
        {
            List<string> books = new List<string>();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT title FROM books", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(reader.GetString(0));  // Read the book title
                    }
                }
            }

            return books;
        }
    }
}
