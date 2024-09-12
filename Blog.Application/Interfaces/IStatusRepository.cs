using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dotnet.Blog.Domain.Entities;

namespace api_dotnet.Blog.Application.Interfaces
{
    public interface IStatusRepository
    {
        Task<IEnumerable<Status>> GetAllAsync();
        Task<Status> GetByIdAsync(int id);
        Task<Status> AddAsync(Status role);
        Task<Status> RemoveAsync(int id);
        Task<bool> Exists(Status role);
    }
}