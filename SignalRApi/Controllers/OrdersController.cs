using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.OrderDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;
using System.Reflection.Metadata.Ecma335;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public IActionResult TotalOrderCount()
        {
            return Ok(_orderService.TOrderCount());
        }
        [HttpGet("OrderList")]
        public IActionResult OrderList()
        {
            return Ok(_orderService.TGetAll());

        }
        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            return Ok(_orderService.TActiveOrderCount());
        }
        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            return Ok(_orderService.TLastOrderPrice());
        }
        [HttpPut]
        public IActionResult OrderUpdate(UpdateOrderDto updateOrderDto)
        {
            _orderService.TUpdate(new Order()
            {
                OrderID = updateOrderDto.OrderID,   
                TableNumber = updateOrderDto.TableNumber,
                Description = updateOrderDto.Description,
                TotalPrice = updateOrderDto.TotalPrice,
                OrderDate=updateOrderDto.OrderDate,

            });
            return Ok("ürün  güncellendi");
        }
    }
}
