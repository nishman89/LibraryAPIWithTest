﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class AuthorDTO
    {
        public AuthorDTO()
        {
            Books = new HashSet<string>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public ICollection<string> Books { get; set; }
    }
}