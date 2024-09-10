using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain.Entities;

namespace api_dotnet.Blog.Application.Interfaces;

public interface IUserRepository
{
    Task<User> GetAllAsync();
    Task<User> GetByIdAsync(int id);
    Task<bool> ExistsAsync(int id);
    Task<User> DeleteAsync(int id);
    Task<User> AddAsync(User user);
}
