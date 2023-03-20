using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
    public class BookCourrier
    {
        [Key]
        public int OrderID { get; set; }
        public int BookId { get; set; }
        public int CourrierId { get; set; }
        public Book Book { get;set; }
        public Courrier Courrier { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string CourrierPhoneNumber { get; set; }
    }
}
