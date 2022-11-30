
using Flopkart_Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using Flopkart_Model;

using Microsoft.Extensions.Logging;
using Flopkart_Sql_Service.Interface;

namespace Flopkart.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class Sql_InventoryController : ControllerBase
    {
        private readonly ISqlProductService _sql_productService;

        private readonly ILogger<Sql_InventoryController> _logger;
        public Sql_InventoryController(ISqlProductService productService, ILogger<Sql_InventoryController> logger)
        {
            _logger = logger;
            _sql_productService = productService;
        }


        [HttpGet("GetAllProducts")]

        public List<ProductModel> GetProducts()
        {
            try
            {


                return _sql_productService.Get();

            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
                throw;
            }
        }

        [HttpGet("GetProduct/{ProductId}")]

        public IActionResult GetProduct(int ProductId)
        {
            try
            {
                if (ProductId != null)
                {
                    return Ok(_sql_productService.GetOne(ProductId));
                }
                return NotFound();


            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
                throw;
            }
        }

        [HttpPost("PostProduct")]

        public IActionResult PostProduct([FromBody] ProductModel product)
        {
            try
            {
                if (product != null)
                {
                    return Ok(_sql_productService.Add(product));
                }
                return NotFound();


            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
                throw;
            }
        }

        [HttpGet("CountProducts")]

        public string CountOfProducts()
        {
            try
            {


                return ($"No of Product in the Databse :{_sql_productService.NoOf()}");

            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
                throw;
            }
        }

        [HttpPut("UpdateProduct/{ProductId}")]

        public IActionResult UpdateProduct([FromBody] ProductModel product, int ProductId)
        {
            try
            {
                if (product != null)
                {
                    return Ok(_sql_productService.Change(product, ProductId));
                }
                return NotFound();


            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
                throw;
            }
        }

        [HttpDelete("DeleteProduct/{ProductId}")]

        public IActionResult DeleteProduct(int ProductId)
        {
            try
            {
                if (ProductId != null)
                {
                    return Ok(_sql_productService.Delete(ProductId));
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
