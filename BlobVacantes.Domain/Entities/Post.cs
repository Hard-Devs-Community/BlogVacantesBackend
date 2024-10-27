using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobVacantes.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime PublishDate { get; set; }
        public string? Image { get; set; }
        public int StatusId { get; set; }
        public Status? Status { get; set; }
    }
}
