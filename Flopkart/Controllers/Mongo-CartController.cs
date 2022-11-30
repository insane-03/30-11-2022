

using Flopkart_Model;
using Flopkart_Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Flopkart.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        private readonly ILogger<CartController> _logger;
        public CartController(ICartService cartService, ILogger<CartController> logger)
        {
            
            _cartService = cartService;
            _logger = logger;
        }
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Ok("HEY I AM CART");
        }
               

        [HttpPut("BuyProduct")]

        public IActionResult BuyProduct([FromBody] ProductModel product)
        {
            try
            {
                if (product != null)
                {
                    return Ok(_cartService.SelectProduct(product));
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
