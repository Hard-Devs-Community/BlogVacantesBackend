using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dotnet.Blog.Application.Interfaces;
using Blog.Domain.Entities;

namespace api_dotnet.Blog.Infraestructure.Repositories;

public class UserRepository : IUserRepository
{
    public Task<User> AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}