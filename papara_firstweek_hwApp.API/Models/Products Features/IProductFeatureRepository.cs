namespace papara_firstweek_hwApp.API.Models.Products_Features
{
    public interface IProductFeatureRepository
    {
        ProductFeature GetById(int id);
        void Add(ProductFeature productFeature);
        void Update(ProductFeature productFeature);
        void Delete(int id);
        void UpdateProductFeature(int id, ProductFeature updatedFeature);
    }
}
