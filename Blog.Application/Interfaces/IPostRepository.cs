using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dotnet.Blog.Domain.Enums;
using Blog.Domain.Entities;

namespace api_dotnet.Blog.Application.Interfaces;

public interface IPostRepository
{
    Task<IList<Post>> GetAllAsync();
    Task<Post> GetByIdAsync();
    Task<Post> AddAsync(Post post);
    Task<Post> UpdateAsync(int id, Post post);
    Task<Post> UpdateStatusAsync(int id, PostStatus status);
    Task<Post> DeleteAsync(int id);
    Task<bool> ExistsAsync(int id);
}
