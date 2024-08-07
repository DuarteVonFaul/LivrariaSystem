using LivrariaSystem.models;
using LivrariaSystem.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.controllers
{
    public class BookController
    {
        public BookService service = new BookService();

        public void createBook(Book book)
        {
            service.register(book);
        }


        public Book? GetBookById(string id)
        {
            return service.searchById(id);
        }

        public Book? GetBookByName(string name)
        {
            return service.searchByName(name);
        }
    }
}
