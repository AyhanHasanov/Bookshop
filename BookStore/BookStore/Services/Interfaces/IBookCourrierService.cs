using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface IBookCourrierService
    {
        Task<ICollection<BookCourrier>> GetAllBookCourriersAsync();
        Task<BookCourrier> GetBookCourrierByIdAsync(int bookCourrierId);
        Task<BookCourrier> CreateAsync(BookCourrier bc);
        Task<BookCourrier> UpdateAsync(BookCourrier bc);
        Task<bool> DeleteAsync(int bookCourrierId);
    }
}
