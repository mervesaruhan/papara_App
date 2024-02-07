namespace papara_firstweek_hwApp.API.Models.Categories
{
    public interface ICategoryRepository
    {
        Category GetById(int id);
        void Add(Category category);
        void UpdateCategoryProperties(int categoryId, string newName);
        void Delete(int id);
        List<Category> GetAllCategoriesWithProducts();
    }
}
