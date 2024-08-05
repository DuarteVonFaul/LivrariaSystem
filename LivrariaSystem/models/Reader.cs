using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.models
{
    public class Reader: User
    {
        public List<Book> booksReceived = new List<Book>();
    }
}
