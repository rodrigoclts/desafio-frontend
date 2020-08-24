using System.Collections.Generic;
using WebAPI_Produto.Models;

namespace WebAPI_Produto.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        void Add(Order item);
    }
}