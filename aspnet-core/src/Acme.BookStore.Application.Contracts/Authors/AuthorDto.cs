using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Authors
{
    public class AuthorDto
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }
    }
}
