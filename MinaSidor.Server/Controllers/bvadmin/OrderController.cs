
using Core.DataCore;
using Microsoft.AspNetCore.Mvc;
using Service.Bvadmin.Interfaces;

namespace MinaSidor.Server.Controllers.bvadmin
    {
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
        {
        private readonly IOrder _orderService;

        public OrderController(IOrder orderService)
            {
            _orderService = orderService;
            }

        [HttpGet("GetOrder/{orderId}")]
        public async Task<ActionResult<Orderitem>> GetOrder(int orderId)
            {
            var order = await _orderService.getOrder(orderId);
            if (order == null)
                {
                return NotFound();
                }
            return order;
            }
        [HttpGet("getOrders/{CustumerId}")]
        public async Task<ActionResult<List<Orderitem>>> Orders(int CustumerId)
            {
            var order = await _orderService.getOrders(CustumerId);
            if (order == null)
                {
                return NotFound();
                }
            return order;
            }
        [HttpPost]
        public async Task<ActionResult<bool>> CreateOrder(Orderitem order)
            {
            var result = await _orderService.createOrder(order);
            if (result)
                {
                return Ok(true);
                }
            return BadRequest();
            }

        [HttpPut("{orderId}")]
        public async Task<ActionResult<bool>> UpdateOrder(int orderId, Orderitem order)
            {
            if (orderId != order.Id)
                {
                return BadRequest();
                }

            var result = await _orderService.updateOrder(order);
            if (result)
                {
                return Ok(true);
                }
            return NotFound();
            }

        [HttpDelete("{orderId}")]
        public async Task<ActionResult<bool>> DeleteOrder(int orderId)
            {
            var result = await _orderService.deleteOrder(orderId);
            if (result)
                {
                return Ok(true);
                }
            return NotFound();
            }
        }
    }
