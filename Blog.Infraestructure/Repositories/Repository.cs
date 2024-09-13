using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Infraestructure.Context;

namespace Blog.Infraestructure.Repositories
{
    public class Repository
    {
        protected readonly DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }
    }
}