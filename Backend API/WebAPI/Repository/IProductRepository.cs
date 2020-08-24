using System.Collections.Generic;
using WebAPI_Produto.Models;

namespace WebAPI_Produto.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(string name);
        Product Add(Product item);
        void Remove(string name);
        Product Update(string name, Product item);
    }
}
