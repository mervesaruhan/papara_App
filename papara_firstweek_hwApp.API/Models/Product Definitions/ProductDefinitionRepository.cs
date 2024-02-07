using papara_firstweek_hwApp.API.Models.Shared;

namespace papara_firstweek_hwApp.API.Models.Product_Definitions
{
    public class ProductDefinitionRepository(AppDbContext context) : IProductDefinitionRepository
    {
        private readonly AppDbContext _context = context;

        public ProductDefinition Add(ProductDefinition productDefinition)
        {
            _context.ProductDefinitions.Add(productDefinition);
            //_context.SaveChanges();
            return productDefinition;
        }

        public ProductDefinition? GetById(int id)
        {
            return _context.ProductDefinitions.Find(id);
        }

        public void Delete(int id)
        {
            var productDefinition = GetById(id);
            if (productDefinition != null)
            {
                _context.ProductDefinitions.Remove(productDefinition);
                //_context.SaveChanges();
            }
        }
        public void UpdateStockCount(int id, int newStockCount)
        {

            var productDefinition = GetById(id);
            if (productDefinition != null)
            {
                productDefinition.StockCount = newStockCount;
                //_context.SaveChanges();
            }


        }
    }
}

