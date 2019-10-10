using System;
using System.Collections.Generic;
using System.Text;

namespace KAHMOBILE
{
    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Created { get; set; }
        public ICollection<ComicAuthor> ComicAuthors { get; set; }
    }
}
