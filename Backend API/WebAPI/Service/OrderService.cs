using System;
using WebAPI_Produto.Models;
using WebAPI_Produto.Repository;

namespace WebAPI_Produto.Service
{
    public class OrderService : IOrderService
    {
        static readonly IOrderRepository OrderRepository = new OrderRepository();

        public void CreateOrder(Order customerOrder)
        {
            Order order = null;

            try
            {
                OrderRepository.Add(customerOrder);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}