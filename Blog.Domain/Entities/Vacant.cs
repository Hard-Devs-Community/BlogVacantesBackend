using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Vacant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Tag Tag { get; set; }
    }
}