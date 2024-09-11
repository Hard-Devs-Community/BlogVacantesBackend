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
    Task<Post?> GetByIdAsync(int id);
    Task<Post?> GetByTitleAsync(string title);
    Task<Post?> AddAsync(Post postModel);
    Task<Post?> UpdateAsync(int id, Post postModel);
    Task<Post?> UpdateStatusAsync(int id, PostStatus status);
    Task<bool> DeleteAsync(int id);
    Task<bool> ExistsAsync(int id);
    Task<bool> ExistsByTitleAsync(string title);
}
