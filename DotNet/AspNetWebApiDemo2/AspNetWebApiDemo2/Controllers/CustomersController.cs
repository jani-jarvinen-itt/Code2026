using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController(NorthwindContext ctx) : ControllerBase
    {
        public List<Customer> GetCustomers()
        {
            return [.. ctx.Customers];
        }
    }

    /*
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public List<Customer> GetCustomers()
        {
            using NorthwindContext ctx = new();
            return [.. ctx.Customers];
        }
    }
    */
}
