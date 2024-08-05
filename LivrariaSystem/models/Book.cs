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
        public DateTime? ReceivingDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public List<string>? Genres { get; set; } = new List<string>();



        public override string ToString()
        {
            string genres = Genres != null && Genres.Count > 0 ? string.Join(", ", Genres) : "None";
            return $"Book [Id: {Id},\n" +
                   $" Title: {Title},\n" +
                   $" Number of Pages: {NumberPag},\n" +
                   $" Count: {count},\n" +
                   $" Author: {Author},\n" +
                   $" Date: {Date?.ToString("yyyy-MM-dd") ?? "N/A"},\n" +
                   $" Receiving Date: {ReceivingDate?.ToString("yyyy-MM-dd") ?? "N/A"},\n" +
                   $" Return Date: {ReturnDate?.ToString("yyyy-MM-dd") ?? "N/A"}, \n" +
                   $"Genres:\n" +
                   $" {genres}]";
        }


    }
}
