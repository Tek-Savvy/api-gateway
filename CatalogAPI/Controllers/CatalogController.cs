using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CatalogAPI.Controllers {

    [Route("api/catalog")]
    [ApiController]
    public class CatalogController : ControllerBase {
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            Order o1 = new Order() { OrderId = 1, OrderName = "Ice Cream" };
            Order o2 = new Order() { OrderId = 2, OrderName = "Cheese Burger" };
            return Ok(new List<Order> {o1, o2 });
        }

    }

    public class Order {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
    }
}
