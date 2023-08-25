using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models;

namespace ShoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartInfoController : ControllerBase
    {
        CartInfo Cartobj  = new CartInfo();

        [HttpGet]
        [Route("/CartInfo/list")]
        public IActionResult GetAllProductCartInfo ()
        {
            var ProdResult = Cartobj.GetAllProductsCartInfo();
            return Ok(ProdResult);
        }
        [HttpGet]
        [Route("/CartInfo/id/{id}")]
        public IActionResult GetProductsByCartInfoId (int id)
        {
            try
            {
                var Prod = Cartobj.GetProductByCartInfoId (id);
                return Ok(Prod);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }

        }
        [HttpGet]
        [Route("/CartInfo/CustomerName/{CustomerName}")]
        public IActionResult GetProductByCustomerName(string CustomerName )
        {
            try
            {
                var Prod = Cartobj.getCartProductsByCustomerName(CustomerName);
                return Ok(Prod);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }

        }
        [HttpPost]
        [Route("/CartInfo/add")]
        public IActionResult AddNewProductCartInfo ([FromBody] CartInfo  newCartInfo )
        {
            var addMessage = Cartobj.AddNewProductCartInfo(newCartInfo);
            return Created("", addMessage);
        }

        [HttpPut]
        [Route("/CartInfo/edit")]
        public IActionResult UpdateProductCartInfo ([FromBody] CartInfo  changes)
        {
            var updateMessage = Cartobj.UpdateProductCartInfo(changes);
            return Accepted(updateMessage);
        }

        [HttpDelete]
        [Route("/CartInfo/delete/{CartInfoId}")]
        public IActionResult DeleteProduct(int CartInfoId)
        {
            try
            {
                var deleteMessage = Cartobj.DeleteProductCartInfo(CartInfoId);
                return Accepted(deleteMessage);
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }

    }
}
