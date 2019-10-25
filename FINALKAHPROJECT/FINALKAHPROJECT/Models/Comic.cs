using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FINALKAHPROJECT.Models;

namespace FINALKAHPROJECT.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ComicImageUrl { get; set; }
        public DateTime Date_Created { get; set; }

        public ICollection<ComicAuthor> ComicAuthors{ get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    

    }
}
