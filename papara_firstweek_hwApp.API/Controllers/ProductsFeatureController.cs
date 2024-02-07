using Microsoft.AspNetCore.Mvc;
using papara_firstweek_hwApp.API.Models.Products_Features;

namespace papara_firstweek_hwApp.API.Controllers
{
    public class ProductsFeatureController : ControllerBase
    {
        private readonly IProductFeatureService _productFeatureService;
        public ProductsFeatureController(IProductFeatureService productFeatureService)
        {
            _productFeatureService=productFeatureService;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductFeature> GetProductFeatureById(int id)
        {
            var productFeature = _productFeatureService.GetById(id);
            if (productFeature == null)
            {
                return NotFound();
            }
            return Ok(productFeature);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductFeature productFeature)
        {
            if (id != productFeature.Id)
            {
                return BadRequest();
            }

            _productFeatureService.Update(productFeature);

            return NoContent();
        }

        

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productFeatureService.Delete(id);
            return NoContent();
        }
    }
}
