using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface IPublisherService
    {
        Task<ICollection<Publisher>> GetAllPublisherAsync();
        Task<Publisher> GetPublisherByNameAsync(string publisherName);
        Task<Publisher> GetPublisherByIdAsync(int publisherId);
        Task<Publisher> CreateAsync(Publisher publisher);
        Task<Publisher> UpdateAsync(Publisher publisher);
        Task<Publisher> DeleteAsync(int publisherId);
    }
}
