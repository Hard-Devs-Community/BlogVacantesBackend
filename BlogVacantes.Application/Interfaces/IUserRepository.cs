using BlobVacantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobVacantes.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<User> DeleteAsync(int id);
        Task<User> AddAsync(User user);
    }
}
