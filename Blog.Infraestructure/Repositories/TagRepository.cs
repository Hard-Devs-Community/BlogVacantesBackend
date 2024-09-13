using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Application.Interfaces;
using Blog.Domain.Entities;

namespace Blog.Infraestructure.Repositories;

public class TagRepository : ITagRepository
{
    public Task<Tag> AddAsync(Tag tag)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Tag>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Tag> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tag>> GetByVacantIdAsync(int vacantId)
    {
        throw new NotImplementedException();
    }

    public Task<Tag> RemoveAsync(int id)
    {
        throw new NotImplementedException();
    }
}