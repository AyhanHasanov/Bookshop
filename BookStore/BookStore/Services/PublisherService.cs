﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly ApplicationDbContext _context;

        public PublisherService()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<Publisher> CreateAsync(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            await _context.SaveChangesAsync();
            return publisher;
        }

        public Task<Publisher> DeleteAsync(int publisherId)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Publisher>> GetAllPublisherAsync()
        {
            return await _context.Publishers.AsQueryable().ToListAsync();
        }

        public async Task<Publisher> GetPublisherByIdAsync(int publisherId)
        {
            return await _context.FindAsync<Publisher>(publisherId);
        }

        public async Task<Publisher> GetPublisherByNameAsync(string publisherName)
        {
            return await _context.FindAsync<Publisher>(publisherName);
        }

        public Task<Publisher> UpdateAsync(Publisher publisher)
        {
            throw new NotImplementedException();
        }
    }
}