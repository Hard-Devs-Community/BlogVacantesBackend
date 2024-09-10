using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain.Entities;

namespace api_dotnet.Blog.Application.Interfaces;

public interface ITagRepository
{
    Task<IList<Tag>> GetAllAsync();
    Task<Tag> GetById(int id);
    Task<IEnumerable<Tag>> GetByVacantIdAsync(int vacantId);
    Task<Tag> AddAsync(Tag tag);
    Task<Tag> RemoveAsync(int id);
}
