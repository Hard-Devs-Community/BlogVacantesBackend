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
    public class PostRepository : Repository, IPostRepository
    {
        public PostRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Post?> AddAsync(Post postModel)
        {
            await _context.Posts.AddAsync(postModel);
            await _context.SaveChangesAsync();

            var post = await _context.Posts.FirstOrDefaultAsync(post => post.Title == postModel.Title);

            return post;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var post = await GetByIdAsync(id);
            if (post == null)
                return false;

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            return post != null;
        }

        public async Task<bool> ExistsByTitleAsync(string title)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(p => p.Title == title);
            return post != null;
        }

        public async Task<IList<Post>> GetAllAsync()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<Post?> GetByIdAsync(int id)
        {
            return await _context.Posts.FindAsync(id);
        }

        public async Task<Post?> GetByTitleAsync(string title)
        {
            return await _context.Posts.FirstOrDefaultAsync(p => p.Title == title);
        }

        public async Task<Post?> UpdateAsync(int id, Post postModel)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
                return null;

            post.Title = postModel.Title;
            post.Description = postModel.Description;
            post.Name = postModel.Name;
            post.Email = postModel.Email;

            await _context.SaveChangesAsync();

            return post;
        }

        public async Task<Post?> UpdateStatusAsync(int id, Status status)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
                return null;

            post.StatusId = status.Id;
            post.Status = status;
            await _context.SaveChangesAsync();

            return post;
        }
    }
}
