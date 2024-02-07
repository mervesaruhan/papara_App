using Microsoft.AspNetCore.Mvc;
using papara_firstweek_hwApp.API.Models.Product_Definitions;

namespace papara_firstweek_hwApp.API.Controllers
{
    public class ProductsDefinitionController : ControllerBase
    {
        private readonly IProductDefinitionService _productDefinitionService;
        public ProductsDefinitionController(IProductDefinitionService productDefinitionService)
        {
            _productDefinitionService = productDefinitionService;
        }


        [HttpGet("{id}")]
        public ActionResult<ProductDefinition> GetById(int id)
        {
            var productDefinition = _productDefinitionService.GetProductDefinitionById(id);
            if (productDefinition == null)
            {
                return NotFound();
            }
            return Ok(productDefinition);
        }

        [HttpPost]
        public IActionResult Create(ProductDefinition productDefinition)
        {
            var newProductDefinition = _productDefinitionService.AddProductDefinition(productDefinition);
            return CreatedAtAction(nameof(GetById), new { id = newProductDefinition.Id }, newProductDefinition);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStockCount(int id, int newStockCount)
        {
            _productDefinitionService.UpdateStockCount(id, newStockCount);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productDefinitionService.DeleteProductDefinition(id);
            return NoContent();
        }
    }


}

