using WebAPI_Produto.Models;

namespace WebAPI_Produto.Service
{
    public interface IOrderService
    {
        void CreateOrder(Order product);
    }
}