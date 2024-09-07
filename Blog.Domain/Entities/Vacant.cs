using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dotnet.Blog.Domain.Enums;

namespace Blog.Domain.Entities
{
    public class Vacant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public VacantStatus Status { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}