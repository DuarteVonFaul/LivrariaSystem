
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.models
{
    public class Reader : User
    {
        public List<BookRent> booksReceived = new List<BookRent>();


        public override string ToString()
        {
            string booksInfo = string.Join("\n", booksReceived);
            return $"{base.ToString()}\n Livros Recebidos: \n{booksInfo}";

        }
    }
}
