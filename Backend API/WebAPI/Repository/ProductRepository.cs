using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_Produto.Models;

namespace WebAPI_Produto.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();
        
        public ProductRepository()
        {
            _products.Add(new Product() { productID = 4, name = "Chef Anton's Cajun Seasoning", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 5, name = "Chef Anton's Gumbo Mix", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 6, name = "Grandma's Boysenberry Spread", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 7, name = "Uncle Bob's Organic Dried Pears", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 8, name = "Northwoods Cranberry Sauce", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 9, name = "Mishi Kobe Niku", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 10, name = "CIkura", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 11, name = "Chang", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 12, name = "Aniseed Syrup", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 13, name = "Queso Cabrales", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 14, name = "Queso Manchego La Pastora", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 15, name = "Konbu", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 16, name = "Tofu", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 17, name = "Genen Shouyu", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 18, name = "Chai", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 19, name = "Pavlova", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 20, name = "Alice Mutton", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 21, name = "Carnarvon Tigers", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 22, name = "Teatime Chocolate Biscuits", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
            _products.Add(new Product() { productID = 23, name = "Sir Rodney's Marmalade", description = "", unitPrice = 22, unitsInStock = 53, image = "http://lorempixel.com/400/200/technics/" });
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Product não localizado.");

            }else if (_products.Any(x => x.name == item.name))
            {
                return null;
            }
            
            _products.Add(item);
            return item;
        }
        
        public Product Get(string name)
        {
            return _products.Find(p => p.name == name);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public void Remove(string name)
        {
            _products.RemoveAll(p => p.name == name);
        }

        public Product Update(string name, Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Pruduto não pode ser nulo.");
            }

            int index = _products.FindIndex(p => p.name == name);

            if (index == -1)
            {
                throw new ArgumentNullException("Product não localizado.");
            }
            _products.RemoveAt(index);
            _products.Add(item);
            return item;
        }
    }
}