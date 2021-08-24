using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
