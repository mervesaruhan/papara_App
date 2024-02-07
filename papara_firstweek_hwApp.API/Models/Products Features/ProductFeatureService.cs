using papara_firstweek_hwApp.API.Models.Products;

namespace papara_firstweek_hwApp.API.Models.Products_Features
{
    public class ProductFeatureService(IProductFeatureRepository productFeatureRepository) : IProductFeatureService
    {
        private readonly IProductFeatureRepository? _productFeatureRepository = productFeatureRepository;

        public void Add(ProductFeature productFeature)
        {
            _productFeatureRepository.Add(productFeature);
        }

        public void Delete(int id)
        {
            _productFeatureRepository?.Delete(id);
        }

        public ProductFeature GetById(int id)
        {
            return _productFeatureRepository.GetById(id);
        }

        public void Update(ProductFeature productFeature)
        {
            _productFeatureRepository.Update(productFeature);
        }

        public void UpdateProductFeature(int id, ProductFeature updatedFeature)
        {
            _productFeatureRepository.UpdateProductFeature(id, updatedFeature);
        }
    }
}
