using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class BaseEntity
    {
         public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}