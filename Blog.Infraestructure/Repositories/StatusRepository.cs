using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Application.Interfaces;
using Blog.Domain.Entities;

namespace Blog.Infraestructure.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        public Task<Status> AddAsync(Status role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Status role)
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