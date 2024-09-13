using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Application.Interfaces;
using Blog.Domain.Entities;

namespace Blog.Infraestructure.Repositories;

public class VacantRepository : IVacantRepository
{
    public Task<Vacant> AddAsync(Vacant vacant)
    {
        throw new NotImplementedException();
    }

    public Task<Vacant> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Vacant> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Vacant> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}