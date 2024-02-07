using Microsoft.AspNetCore.Mvc;
using papara_firstweek_hwApp.API.Models.Products;

namespace papara_firstweek_hwApp.API.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productservice;
        public ProductsController(IProductService productservice) => _productservice = productservice;

        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            var products = _productservice.GetAll();
            return Ok(products);
        }
        [HttpGet]
        public IActionResult Index()
        {
            var products = _productservice.GetAllProductsWithCategories();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = _productservice.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productservice.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _productservice.Update(product);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productservice.Delete(id);
            return NoContent();
        }
    }
}
