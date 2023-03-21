using BookStore.Data;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class CourrierService : ICourrierService
    {
        private readonly ApplicationDbContext _context;

        public CourrierService()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<Courrier> CreateAsync(Courrier courrier)
        {
            _context.Courriers.Add(courrier);
            await _context.SaveChangesAsync();
            return courrier;
        }

        public async Task<bool> DeleteAsync(int courrierId)
        {
            try
            {
                _context.Courriers.Remove(await GetCourrierByIdAsync(courrierId));
                await _context.SaveChangesAsync();
                return true;    
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ICollection<Courrier>> GetAllCourriersAsync()
        {
            return await _context.Courriers.AsQueryable().ToListAsync();
        }

        public async Task<Courrier> GetCourrierByIdAsync(int courrierId)
        {
            return await _context.Courriers.FindAsync(courrierId);
        }

        public async Task<Courrier> UpdateAsync(Courrier courrier)
        {
            _context.Courriers.Update(courrier);
            await _context.SaveChangesAsync();
            return courrier;
        }
    }
}
