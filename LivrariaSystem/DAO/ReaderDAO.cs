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
    public class ReaderDAO
    {
        public void InsertUser(User user)
        {
            using (var connection = new MySqlConnection(DatabaseInitializer.connectionString))
            {
                connection.Open();

                // Inserir Address
                string insertAddressQuery = @"
            INSERT INTO Addresses (Street, City, Country, State, PostalCode, Number)
            VALUES (@Street, @City, @Country, @State, @PostalCode, @Number);";

                MySqlCommand command;

                using (command = new MySqlCommand(insertAddressQuery, connection))
                {
                    command.Parameters.AddWithValue("@Street", user.Address.Street);
                    command.Parameters.AddWithValue("@City", user.Address.City);
                    command.Parameters.AddWithValue("@Country", user.Address.Country);
                    command.Parameters.AddWithValue("@State", user.Address.State);
                    command.Parameters.AddWithValue("@PostalCode", user.Address.PostalCode);
                    command.Parameters.AddWithValue("@Number", user.Address.Number);
                    command.ExecuteNonQuery();
                }

                long addressId = command.LastInsertedId;  // Recupera o ID do endereço inserido

                // Inserir User
                string insertUserQuery = @"
            INSERT INTO Users (Id, Password, Name, PhoneNumber, Email, AddressId)
            VALUES (@Id, @Password, @Name, @PhoneNumber, @Email, @AddressId);";

                using (command = new MySqlCommand(insertUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", user.Id);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@AddressId", addressId);

                    command.ExecuteNonQuery();
                }
            }
        }


        public User? GetUserById(string id)
        {
            User? user = null;

            using (var connection = new MySqlConnection(DatabaseInitializer.connectionString))
            {
                connection.Open();

                string selectQuery = @"
            SELECT u.Id, u.Password, u.Name, u.PhoneNumber, u.Email,
                   a.Street, a.City, a.Country, a.State, a.PostalCode, a.Number
            FROM Users u
            JOIN Addresses a ON u.AddressId = a.Id
            WHERE u.Id = @Id;";

                using (var command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                Id = reader["Id"].ToString(),
                                Password = reader["Password"].ToString(),
                                Name = reader["Name"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = new Address
                                {
                                    Street = reader["Street"].ToString(),
                                    City = reader["City"].ToString(),
                                    Country = reader["Country"].ToString(),
                                    State = reader["State"].ToString(),
                                    PostalCode = reader["PostalCode"].ToString(),
                                    Number = reader["Number"].ToString()
                                }
                            };
                        }
                    }
                }
            }

            return user;
        }

    }
}
