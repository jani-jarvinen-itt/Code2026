using AspNetWebApiDemo1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Hello World!";

        [HttpPost]
        public string Post() => "Hello, I'm a POST!";

        [HttpGet]
        [Route("person")]
        public Person GetPerson() => new()
        {
            Id = 1,
            Name = "John Doe",
            Birthday = "1990-01-01"
        };
    }
}
