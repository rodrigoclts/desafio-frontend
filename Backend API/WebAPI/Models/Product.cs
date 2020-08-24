namespace WebAPI_Produto.Models
{
    public class Product
    {
        public int productID { get; set; }
        public double unitPrice { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public double unitsInStock { get; set; }
        public string description { get; set; }

    }
}