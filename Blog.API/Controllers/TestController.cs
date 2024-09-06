using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_dotnet.Blog.API.Controllers;

[ApiController]
[Route("api/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Test() {
        return Ok("this workds");
    }
}
