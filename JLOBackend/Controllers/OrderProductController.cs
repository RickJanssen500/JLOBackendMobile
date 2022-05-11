using Microsoft.AspNetCore.Mvc;
using Bll;
using Bll.ReturnObjects;

namespace JLOBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductController : ControllerBase
    {
        [HttpGet("Get/{id}")]
        public ActionResult<OrderProductRO> Get(int id)
        {
            OrderProducts orderProduct = new();
            OrderProductRO orderProductRO = orderProduct.Get(id);
            return Ok(orderProductRO);
        }

        [HttpPost("Add/{id}/{amount}")]
        public ActionResult Post(int id,int amount)
        {
            OrderProducts orderProduct = new();
            orderProduct.Add(id,amount);
            return Ok();
        }
    }
}
