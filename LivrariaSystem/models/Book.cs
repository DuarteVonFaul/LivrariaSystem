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
        public string? Author { get; set; }
        public DateTime? Date { get; set; }
        public List<Genre>? Genres { get; set; }


    }
}
