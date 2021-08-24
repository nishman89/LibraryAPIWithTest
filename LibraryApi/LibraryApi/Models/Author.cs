using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
