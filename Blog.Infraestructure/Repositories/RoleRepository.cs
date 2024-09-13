using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Application.Interfaces;
using Blog.Infraestructure.Context;
using Blog.Domain.Entities;

namespace Blog.Infraestructure.Repositories;

public class RoleRepository : Repository, IRoleRepository
{
    public RoleRepository(DatabaseContext context) : base(context)
    {
    }
    public Task<Role> AddAsync(Role role)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Exists(Role role)
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