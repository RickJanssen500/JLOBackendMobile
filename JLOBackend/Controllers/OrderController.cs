using Microsoft.AspNetCore.Mvc;
using Bll;
using Bll.ReturnObjects;


namespace JLOBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<OrderRO>> Get()
        {
            Orders order = new Orders();
            IEnumerable<OrderRO> orders = order.GetAllOrders();
            return Ok(orders);
        }

        [HttpPost("Complete/{id}")]
        public ActionResult Post(int id)
        {
            Orders order = new();
            order.CompleteOrder(id);
            return Ok();
        }
    }
}
