using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dotnet.Blog.Infraestructure.Context;

namespace api_dotnet.Blog.Infraestructure.Repositories
{
    public class Repository
    {
        protected readonly InMemoryContext _context;

        public Repository(InMemoryContext context)
        {
            _context = context;
        }
    }
}