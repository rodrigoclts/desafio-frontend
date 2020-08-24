using System.Collections.Generic;
using WebAPI_Produto.Models;

namespace WebAPI_Produto.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>();

        public void Add(Order item)
        {
            _orders.Add(item);
        }

        IEnumerable<Order> IOrderRepository.GetAll()
        {
            return _orders;
        }
    }
}