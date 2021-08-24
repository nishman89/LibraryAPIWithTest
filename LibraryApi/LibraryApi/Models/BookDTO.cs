using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class BookDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
