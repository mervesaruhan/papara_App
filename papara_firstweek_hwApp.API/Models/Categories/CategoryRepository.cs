using Microsoft.EntityFrameworkCore;
using papara_firstweek_hwApp.API.Models.Products;
using papara_firstweek_hwApp.API.Models.Shared;

namespace papara_firstweek_hwApp.API.Models.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }
            _context.SaveChanges();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);  

        }

        public List<Category> GetAllCategoriesWithProducts()
        {
            var categories = _context.Categories.ToList();

            foreach (var category in categories)
            {
                _context.Entry(category)
                    .Collection(c => c.Products!)
                    .Load();
            }

            return categories;
        }

        public void UpdateCategoryProperties(int categoryId, string newName)
        {
            var category = _context.Categories.Find(categoryId);
            if (category != null)
            {
                category.Name = newName;
                _context.Categories.Update(category);
                _context.SaveChanges();
            }
        }
    }
}
