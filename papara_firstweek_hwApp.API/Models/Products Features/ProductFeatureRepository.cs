using papara_firstweek_hwApp.API.Models.Shared;
using papara_firstweek_hwApp.API.Models.Users;

namespace papara_firstweek_hwApp.API.Models.Products_Features
{
    public class ProductFeatureRepository : IProductFeatureRepository
    {
        private readonly AppDbContext _context;
        public ProductFeatureRepository(AppDbContext context)
        {
            _context = context;
        }


        public void Add(ProductFeature productFeature)
        {
            _context.ProductFeatures.Add(productFeature);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productFeature = GetById(id);
            if (productFeature != null)
            {
                _context.ProductFeatures.Remove(productFeature);
                _context.SaveChanges();
            }
        }

        public ProductFeature GetById(int id)
        {
            var feature = _context.ProductFeatures.SingleOrDefault(pf => pf.Id == id);
            if (feature == null)
            {
                throw new Exception("Belirtilen ID ile ürün özelliği bulunamadı.");
                
            }
            return feature;
        }
        public void UpdateProductFeature(int id, ProductFeature updatedFeature)
        {
            var existingFeature = _context.ProductFeatures.Find(id);

            if (existingFeature != null)
            {
                
                existingFeature.Height = updatedFeature.Height;
                existingFeature.Width = updatedFeature.Width;
                existingFeature.Color = updatedFeature.Color;
                

                _context.ProductFeatures.Update(existingFeature);
                _context.SaveChanges();
            }
        }

        public void Update(ProductFeature productFeature)
        {
            _context.ProductFeatures.Update(productFeature);
            _context.SaveChanges();
        }
    }
}
