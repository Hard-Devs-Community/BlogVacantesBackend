using BlobVacantes.Application.Interfaces;
using BlobVacantes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogVacantes.Infraestructure.Repositories
{
    public class TagRepository : Repository, ITagRepository
    {
        public TagRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Tag?> AddAsync(Tag tag)
        {
            Tag? tagModel = await _context.Tags.FirstOrDefaultAsync(t => t.Name == tag.Name);
            if (tagModel == null)
                return null;

            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();

            return await _context.Tags.FirstOrDefaultAsync(t => t.Name == tag.Name);
        }

        public async Task<IList<Tag>> GetAllAsync()
        {
            return await _context.Tags.ToListAsync();
        }

        public async Task<Tag?> GetById(int id)
        {
            return await _context.Tags.FindAsync(id);
        }

        public async Task<IEnumerable<Tag>> GetByVacantIdAsync(int vacantId)
        {
            var filteredTags = _context.Tags.Where(t => t.VacantId == vacantId);
            return await filteredTags.ToListAsync();
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var task = await _context.Tags.FindAsync(id);
            if (task == null)
                return false;

            _context.Tags.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
