﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
   public class Courrier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookCourrier> bookCourriers { get; set; }
    }
}
