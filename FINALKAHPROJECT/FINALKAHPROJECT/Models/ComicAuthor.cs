using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINALKAHPROJECT.Models
{
    public class ComicAuthor
    {
        public int Id { get; set; }
        public int ComicId { get; set; }
        public Comic Comic { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
