using BlobVacantes.Application.Interfaces;
using BlobVacantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogVacantes.Infraestructure.Repositories
{
    public class VacantRepository : Repository, IVacantRepository
    {
        public VacantRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<Vacant> AddAsync(Vacant vacant)
        {
            throw new NotImplementedException();
        }

        public Task<Vacant> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Vacant> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Vacant> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
