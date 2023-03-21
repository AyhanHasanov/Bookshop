using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Data.Attributes;

namespace BookStore.Data.Models
{
    public class BookCourrier
    {
        [Key]
        public int OrderID { get; set; }
        [ForeignKey("BookId")]
        public int BookId { get; set; }
        [ForeignKey("CourrierId")]
        public int CourrierId { get; set; }
        public Book Book { get;set; }
        public Courrier Courrier { get; set; }
        public DateTime DeliveryDate { get; set; }

        [IsPhoneNumberValid]
        public string CourrierPhoneNumber { get; set; }
    }
}
