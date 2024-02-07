using Microsoft.AspNetCore.Mvc;
using papara_firstweek_hwApp.API.Models.Categories;

namespace papara_firstweek_hwApp.API.Controllers
{
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService=categoryService;
        }


        [HttpGet("{id}")]
        public ActionResult<Category> GetById(int id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        public List<Category> GetAllCategoriesWithProducts()
        {
            return _categoryService.GetAllCategoriesWithProducts();
        }




        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryService.Add(category);
            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
        }

        
        [HttpPut("{id}")]
        public IActionResult Update(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            _categoryService.UpdateCategoryProperties(categoryId: id, newName: category.Name);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return NoContent();
        }

    }
}
