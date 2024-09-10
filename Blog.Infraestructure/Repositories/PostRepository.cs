using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dotnet.Blog.Application.Interfaces;
using api_dotnet.Blog.Domain.Enums;
using Blog.Domain.Entities;

namespace api_dotnet.Blog.Infraestructure.Repositories;

public class PostRepository : IPostRepository
{
    public Task<Post> AddAsync(Post post)
    {
        throw new NotImplementedException();
    }

    public Task<Post> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Post>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Post> GetByIdAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Post> UpdateAsync(int id, Post post)
    {
        throw new NotImplementedException();
    }

    public Task<Post> UpdateStatusAsync(int id, PostStatus status)
    {
        throw new NotImplementedException();
    }
}
