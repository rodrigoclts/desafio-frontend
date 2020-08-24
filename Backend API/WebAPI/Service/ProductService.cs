using System.Collections.Generic;
using WebAPI_Produto.Models;
using WebAPI_Produto.Repository;

namespace WebAPI_Produto.Service
{
    public class ProductService : IProductService
    {
        static readonly IProductRepository ProductRepository = new ProductRepository();

        public Product GetProduct(string name)
        {
            Product item = null;

            try
            {
                var product = ProductRepository.Get(name);

                item = product;
            }
            catch
            {
                return item;
            }
            return item;
        }

        public List<Product> GetProduct()
        {
            List<Product> products = new List<Product>();            

            try
            {
                products.AddRange(ProductRepository.GetAll());
            }
            catch
            {
                return products;
            }

            return products;
        }
        
        public void CreateProduct(Product product)
        {
            ProductRepository.Add(product);
        }

        public Product UpdateProduct(string name, Product product)
        {
            Product newProduct = null;
            try
            {
                newProduct = ProductRepository.Update(name, product);
            }
            catch
            {
                return newProduct;
            }
            return newProduct;
        }

        public bool RemoveProduct(string name)
        {                                 
            try
            {
                ProductRepository.Remove(name);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}