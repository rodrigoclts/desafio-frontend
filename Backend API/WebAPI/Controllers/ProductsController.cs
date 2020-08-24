using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI_Produto.Models;
using WebAPI_Produto.Service;

namespace WebAPI_Produto.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductService _productService;

        public ProductsController()
        {
            _productService = new ProductService();
        }

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            var product = _productService.GetProduct();

            return Request.CreateResponse(product);
        }

        [HttpGet]
        public HttpResponseMessage Get(string name)
        {
            Product item = _productService.GetProduct(name);
            if (item == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, item);
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Post()
        {
            string order = await Request.Content.ReadAsStringAsync();

            Product item = JsonConvert.DeserializeObject<Product>(order);

            _productService.CreateProduct(item);

            return Request.CreateResponse(HttpStatusCode.Created, item);
        }

        [HttpPut]
        public async Task<HttpResponseMessage> Put(string name)
        {
            string result = await Request.Content.ReadAsStringAsync();

            Product item = JsonConvert.DeserializeObject<Product>(result);

            item = _productService.UpdateProduct(name, item);

            if (item == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, item);
        }

        [HttpDelete]
        public HttpResponseMessage Delete(string name)
        {
            Product item = _productService.GetProduct(name);

            if (item == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            if (!_productService.RemoveProduct(name)){

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}

