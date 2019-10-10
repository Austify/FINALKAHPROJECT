using System;
using System.Collections.Generic;
using System.Text;

namespace KAHMOBILE
{
    class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date_Created { get; set; }

        public ICollection<Comic> Comics { get; set; }
    }
}
