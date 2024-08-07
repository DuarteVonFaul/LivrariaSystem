using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.models
{
    public class BookRent
    {
        public Book book {  get; set; }
        public DateTime? ReceivingDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public override string ToString()
        {
            return book.ToString() + "\n" +
                   $" Data do aluguel: {ReceivingDate?.ToString("yyyy-MM-dd") ?? "N/A"}, \n"+
                   $" Data de Entrega: {ReturnDate?.ToString("yyyy-MM-dd") ?? "N/A"}, \n";
        }
    }
}
