using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infraestructure.Context
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vacant>()
                .HasMany(v => v.Tags)
                .WithMany(t => t.Vacants)
                .UsingEntity(j => j.ToTable("PostTag"));

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Status)
                .WithMany(s => s.Posts)
                .HasForeignKey(p => p.StatusId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}