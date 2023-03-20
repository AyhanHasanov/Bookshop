using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshop.Models
{
    public class Courrier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> books { get; set; }
    }
}
