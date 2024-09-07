using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_dotnet.Blog.Infraestructure.Context
{
    public class InMemoryContext : DbContext
    {
        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Vacant> Vacants { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}