using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Products";
        }
    }
}
