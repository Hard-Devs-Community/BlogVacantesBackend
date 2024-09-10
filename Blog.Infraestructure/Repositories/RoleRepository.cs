using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dotnet.Blog.Application.Interfaces;
using Blog.Domain.Entities;

namespace api_dotnet.Blog.Infraestructure.Repositories;

public class RoleRepository : IRoleRepository
{
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