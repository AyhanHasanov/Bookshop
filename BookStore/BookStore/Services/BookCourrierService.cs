using BookStore.Data;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookCourrierService : IBookCourrierService
    {
        private readonly ApplicationDbContext _context;
        public BookCourrierService()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<BookCourrier> CreateAsync(BookCourrier bc)
        {
            _context.BookCourriers.Add(bc);
            await _context.SaveChangesAsync();
            return bc;
        }

        public async Task<bool> DeleteAsync(int bookCourrierId)
        {
            try
            {
                _context.BookCourriers.Remove(await GetBookCourrierByIdAsync(bookCourrierId));
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ICollection<BookCourrier>> GetAllBookCourriersAsync()
        {
            return await _context.BookCourriers.AsQueryable().ToListAsync();
        }

        public async Task<BookCourrier> GetBookCourrierByIdAsync(int bookCourrierId)
        {
            return await _context.BookCourriers.FindAsync(bookCourrierId);
        }

        public async Task<BookCourrier> UpdateAsync(BookCourrier bc)
        {
            _context.BookCourriers.Update(bc);
            await _context.SaveChangesAsync();
            return bc;
        }
    }
}
