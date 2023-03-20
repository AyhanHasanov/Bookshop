using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshop.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        [ForeignKey("PublisherId")]
        Publisher Publisher { get; set; }
        Courrier Courrier { get; set; }
    }
}
