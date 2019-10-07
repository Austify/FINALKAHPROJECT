using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINALKAHPROJECT.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Created { get; set; }
        public ICollection<ComicAuthor> ComicAuthors { get; set; }
    }
}
