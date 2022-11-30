
using DnsClient.Internal;
using Flopkart_Model;
using Flopkart_Service.Implementation;
using Flopkart_Sql_Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Flopkart.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Sql_CartController : Controller
    {
        private readonly ISqlCartService _sql_cartService;

        private readonly ILogger<Sql_CartController> _logger;
        public Sql_CartController(ISqlCartService cartService, ILogger<Sql_CartController> logger)
        {

            _sql_cartService = cartService;
            _logger = logger;
        }



        [HttpGet("index")]
        public IActionResult Index()
        {
            return Ok("HEY I AM CART");
        }


        [HttpPut("BuyProduct")]

        public IActionResult Buy([FromBody] ProductModel product)
        {
            try
            {
                if (product != null)
                {
                    return Ok(_sql_cartService.Select(product));
                }
                return NotFound();

            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
                throw;
            }
        }
    }
}
