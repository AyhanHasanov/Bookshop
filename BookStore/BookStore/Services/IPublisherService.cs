using BookStore.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface IPublisherService
    {
        Task<ICollection<Publisher>> GetAllPublisherAsync();
        Task<Publisher> GetPublisherByIdAsync(int publisherId);
        Task<Publisher> CreateAsync(Publisher publisher);
        Task<Publisher> UpdateAsync(Publisher publisher);
        Task<bool> DeleteAsync(int publisherId);
    }
}
