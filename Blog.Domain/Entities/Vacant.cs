using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain.Enums;

namespace Blog.Domain.Entities
{
    public class Vacant : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public VacantStatus Status { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}