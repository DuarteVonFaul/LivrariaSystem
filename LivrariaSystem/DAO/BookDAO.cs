using LivrariaSystem.database;
using LivrariaSystem.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LivrariaSystem.DAO
{
    public class BookDAO
    {
        public void InsertBook(Book book)
        {
            using (var connection = new MySqlConnection(DatabaseInitializer.connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT INTO Books (Title, NumberPag, Count, Author, Date, Genres)
            VALUES (@Title, @NumberPag, @Count, @Author, @Date, @Genres);";

                using (var command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@NumberPag", book.NumberPag);
                    command.Parameters.AddWithValue("@Count", book.count);
                    command.Parameters.AddWithValue("@Author", book.Author);
                    command.Parameters.AddWithValue("@Date", book.Date?.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Genres", string.Join(",", book.Genres ?? new List<string>()));

                    command.ExecuteNonQuery();
                }
            }
        }


        public Book? GetBookById(int id)
        {
            Book? book = null;

            using (var connection = new MySqlConnection(DatabaseInitializer.connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Books WHERE Id = @Id;";

                using (var command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = new Book
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = reader["Title"].ToString(),
                                NumberPag = Convert.ToInt32(reader["NumberPag"]),
                                count = Convert.ToInt32(reader["Count"]),
                                Author = reader["Author"].ToString(),
                                Date = reader["Date"] != DBNull.Value ? DateTime.Parse(reader["Date"].ToString()) : null,
                                Genres = reader["Genres"].ToString()?.Split(',').ToList()
                            };
                        }
                    }
                }
            }

            return book;
        }



    }
}
