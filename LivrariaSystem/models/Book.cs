using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int NumberPag { get; set; }
        public int count { get; set; }
        public string? Author { get; set; }
        public DateTime? Date { get; set; }
        public List<string>? Genres { get; set; } = new List<string>();



        public override string ToString()
        {
            string genres = Genres != null && Genres.Count > 0 ? string.Join(", ", Genres) : "None";
            return $"Livro -- Id: {Id},\n" +
                   $" Titulo: {Title},\n" +
                   $" Numero de Paginas: {NumberPag},\n" +
                   $" Quantidade: {count},\n" +
                   $" Autor: {Author},\n" +
                   $" Data de lancamento: {Date?.ToString("yyyy-MM-dd") ?? "N/A"},\n" +
                   $"Generos:\n" +
                   $" {genres}";
        }


    }
}
