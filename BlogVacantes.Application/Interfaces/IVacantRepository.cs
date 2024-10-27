using BlobVacantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobVacantes.Application.Interfaces
{
    public interface IVacantRepository
    {
        Task<Vacant> GetAllAsync();
        Task<Vacant> GetByIdAsync(int id);
        Task<Vacant> AddAsync(Vacant vacant);
        Task<Vacant> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
