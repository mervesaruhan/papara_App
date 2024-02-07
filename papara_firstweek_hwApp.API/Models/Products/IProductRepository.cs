namespace papara_firstweek_hwApp.API.Models.Products
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        List<Product> GetAll();
        List<Product> GetAllProductsWithCategory();
    }
}
