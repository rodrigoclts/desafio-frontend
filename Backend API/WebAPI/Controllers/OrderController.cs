using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using WebAPI_Produto.Models;
using WebAPI_Produto.Service;

namespace WebAPI_Produto.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;

        public OrderController()
        {
            _orderService = new OrderService();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Post()
        {
            string order = await Request.Content.ReadAsStringAsync();

            Order item = JsonConvert.DeserializeObject<Order>(order);

            _orderService.CreateOrder(item);

            return Request.CreateResponse(HttpStatusCode.Created, item);
        }
    }
}
