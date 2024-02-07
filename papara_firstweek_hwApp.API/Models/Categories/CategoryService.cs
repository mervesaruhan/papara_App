namespace papara_firstweek_hwApp.API.Models.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Add(Category category)
        {
             _categoryRepository.Add(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public List<Category> GetAllCategoriesWithProducts()
        {
            return _categoryRepository.GetAllCategoriesWithProducts();
        }


        public void Update(int categoryId, string newName)
        {
            _categoryRepository.UpdateCategoryProperties(categoryId, newName);
        }

        public void UpdateCategoryProperties(int categoryId, string newName)
        {
            _categoryRepository.UpdateCategoryProperties(categoryId,newName);
        }
    }
}
