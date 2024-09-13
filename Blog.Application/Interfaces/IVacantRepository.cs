using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain.Entities;

namespace Blog.Application.Interfaces;

public interface IVacantRepository
{
    Task<Vacant> GetAllAsync();
    Task<Vacant> GetByIdAsync(int id);
    Task<Vacant> AddAsync(Vacant vacant);
    Task<Vacant> DeleteAsync(int id);
    Task<bool> ExistsAsync(int id);
}
