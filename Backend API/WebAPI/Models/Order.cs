using System.Collections.Generic;

namespace WebAPI_Produto.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string TimeToArrive { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string customerAditionalComments { get; set; }
        public IList<ProductsOrder> products { get; set; }
    }
}