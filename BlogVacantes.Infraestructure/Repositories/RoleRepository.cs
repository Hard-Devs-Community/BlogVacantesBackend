using BlobVacantes.Application.Interfaces;
using BlobVacantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogVacantes.Infraestructure.Repositories
{
    public class RoleRepository : Repository, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
        }
        public Task<Role> AddAsync(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Role> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
