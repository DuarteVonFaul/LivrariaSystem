using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.database
{
    public class DatabaseInitializer
    {
        public const string connectionString = "Server=localhost;Database=db;User ID=root;Password=root;Pooling=true;";

        public static void InitializeDatabase()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Books (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    Title VARCHAR(255),
                    NumberPag INT,
                    Count INT,
                    Author VARCHAR(255),
                    Date DATE,
                    Genres VARCHAR(255)
                );
                
                CREATE TABLE IF NOT EXISTS Addresses (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    Street VARCHAR(255),
                    City VARCHAR(255),
                    Country VARCHAR(255),
                    State VARCHAR(255),
                    PostalCode VARCHAR(20),
                    Number VARCHAR(20)
                );

                CREATE TABLE IF NOT EXISTS Users (
                    Id VARCHAR(36) PRIMARY KEY,
                    Password VARCHAR(255),
                    Name VARCHAR(255),
                    PhoneNumber VARCHAR(20),
                    Email VARCHAR(255),
                    AddressId INT,
                    FOREIGN KEY (AddressId) REFERENCES Addresses(Id)
                );";

                using (var command = new MySqlCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}
