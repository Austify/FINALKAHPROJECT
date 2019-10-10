using System;
using System.Collections.Generic;
using System.Text;

namespace KAHMOBILE
{
    class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ComicImage { get; set; }
        public DateTime Date_Created { get; set; }

        public ICollection<ComicAuthor> ComicAuthors { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
