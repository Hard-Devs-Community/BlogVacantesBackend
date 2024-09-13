using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Blog.Domain.Enums;

namespace Blog.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime PublishDate { get; set; }
        public string Image { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}