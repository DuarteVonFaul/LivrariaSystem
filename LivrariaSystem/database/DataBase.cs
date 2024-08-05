using LivrariaSystem.models;
using LivrariaSystem.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LivrariaSystem.database
{
    public static class DataBase
    {


        public static List<Librarian> librarians = new List<Librarian>();
        public static List<Reader> readers = new List<Reader>();
        public static List<Book> books = new List<Book>();

        public static List<string> geners = new List<string> { "Ação", "Aventura", "Romance", "Ficção Cientifica", "Drama", "Suspense", "Fantasia" };

        public static Client client =  new Client();

    }
}
