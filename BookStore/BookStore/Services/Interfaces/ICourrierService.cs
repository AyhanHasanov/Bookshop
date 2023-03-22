using BookStore.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services
{
    interface ICourrierService
    {
        Task<ICollection<Courrier>> GetAllCourriersAsync();
        Task<Courrier> GetCourrierByIdAsync(int courrierId);
        Task<Courrier> CreateAsync(Courrier courrier);
        Task<Courrier> UpdateAsync(Courrier courrier);
        Task<bool> DeleteAsync(int courrierId);
    }
}
