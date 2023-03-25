using BookStore.Data;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;

        public BookService()
        {
            _context = new ApplicationDbContext();
            _context.EnsureDatabaseCreated();
        }

        public async Task<Book> CreateAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteAsync(int bookId)
        {
            try
            {
                _context.Books.Remove(await GetBookByIdAsync(bookId));
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ICollection<Book>> GetAllBookAsync()
        {
            return await _context.Books.AsQueryable().ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int bookId)
        {
            return await _context.Books.FindAsync(bookId);
        }

        public async Task<Book> GetBookByTitleAsync(string title)
        {
            foreach (var book in _context.Books)
            {
                if (book.Title.Equals(title))
                    return book;
            }

            return null;
        }
        public async Task<Book> UpdateAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }
    }
}
