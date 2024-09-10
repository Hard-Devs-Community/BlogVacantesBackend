using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int VacantId { get; set; }
        public Vacant Vacant { get; set; }
    }
}