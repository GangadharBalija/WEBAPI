using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models;

namespace ShoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Products Prodobj = new Products();

        [HttpGet]
        [Route("/Products/list")]
        public IActionResult GetAllProduct ()
        {
            var ProdResult = Prodobj.GetAllProducts();
            return Ok(ProdResult);
        }
        [HttpGet]
        [Route("/Products/id/{id}")]
        public IActionResult GetProductsById (int id)
        {
            try
            {
                var Prod = Prodobj.GetProductById(id);
                return Ok(Prod);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }

        }
    }
}
