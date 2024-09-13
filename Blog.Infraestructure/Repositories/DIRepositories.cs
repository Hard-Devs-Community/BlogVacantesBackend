using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Application.Interfaces;

namespace Blog.Infraestructure.Repositories
{
    // Dependency Injection for the repositories
    public static class DIRepositories
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<IVacantRepository, VacantRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}