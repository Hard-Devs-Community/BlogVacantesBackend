using BlobVacantes.Application.Interfaces;
using BlobVacantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogVacantes.Infraestructure.Repositories
{
    public class StatusRepository : Repository, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<Status> AddAsync(Status role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Status role)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Status>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Status> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Status> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
