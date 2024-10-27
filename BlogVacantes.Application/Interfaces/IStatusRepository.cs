using BlobVacantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobVacantes.Application.Interfaces
{
    public interface IStatusRepository
    {
        Task<IEnumerable<Status>> GetAllAsync();
        Task<Status> GetByIdAsync(int id);
        Task<Status> AddAsync(Status role);
        Task<Status> RemoveAsync(int id);
        Task<bool> ExistsAsync(Status role);
    }
}
