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
        [HttpGet]
        [Route("/Products/Category/{Category}")]
        public IActionResult GetProductByCategory (string Category )
        {
            try
            {
                var Prod  = Prodobj.GetProductByCategory(Category);
                return Ok(Prod);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }

        }
        [HttpGet]
        [Route("/Products/IsinStock/{IsinStock}")]
        public IActionResult GetProductbyIsinStock (string IsinStock)
        {
            var Prod   = Prodobj.GetProductIsinStock(IsinStock);
            return Ok(Prod);
        }

        [HttpPost]
        [Route("/Products/add")]
        public IActionResult AddNewProduct ([FromBody] Products  newProdobj )
        {
            var addMessage = Prodobj.AddNewProduct(newProdobj);
            return Created("", addMessage);
        }

        [HttpPut]
        [Route("/Products/edit")]
        public IActionResult UpdateProduct ([FromBody] Products  changes)
        {
            var updateMessage = Prodobj.UpdateProduct(changes);
            return Accepted(updateMessage);
        }

        [HttpDelete]
        [Route("/Products/delete/{Prodid}")]
        public IActionResult DeleteProduct (int Prodid )
        {
            try
            {
                var deleteMessage = Prodobj.DeleteProduct(Prodid);
                return Accepted(deleteMessage);
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }
    }
}
