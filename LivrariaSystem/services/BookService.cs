﻿using LivrariaSystem.DAO;
using LivrariaSystem.database;
using LivrariaSystem.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LivrariaSystem.services
{
    public class BookService
    {
        BookDAO bookDAO = new BookDAO();


        public void register(Book book)
        {
            bookDAO.InsertBook(book);
        }


        public Book? searchById(string id)
        {
            return bookDAO.GetBookById(Convert.ToInt32(id));
        }

        public Book searchByName(string name)
        {
            Book? foundBook = DataBase.books.Find(book => book.Title != null && book.Title.Equals(name, StringComparison.OrdinalIgnoreCase));


            if (foundBook != null && foundBook.count > 0)
            {
                MessageBox.Show($"Livro encontrado: {foundBook.ToString()}", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Livro não encontrado no Acervo", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return foundBook;
        }
    }
}
