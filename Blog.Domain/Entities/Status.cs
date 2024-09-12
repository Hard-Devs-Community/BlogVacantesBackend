using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_dotnet.Blog.Domain.Entities
{
    public class Status
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}