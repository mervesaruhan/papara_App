namespace papara_firstweek_hwApp.API.Models.Product_Definitions
{
    public class ProductDefinitionService : IProductDefinitionService

    {
        private readonly IProductDefinitionRepository _productDefinitionRepository;
        public ProductDefinitionService(IProductDefinitionRepository productDefinitionRepository)
        {
            _productDefinitionRepository = productDefinitionRepository;
        }

        public ProductDefinition AddProductDefinition(ProductDefinition productDefinition)
        {
            return _productDefinitionRepository.Add(productDefinition);
        }

        public void DeleteProductDefinition(int id)
        {
            _productDefinitionRepository.Delete(id);
        }

        public ProductDefinition GetProductDefinitionById(int id)
        {
            return _productDefinitionRepository.GetById(id);
        }
        public void UpdateStockCount(int id, int newStockCount)
        {
            _productDefinitionRepository.UpdateStockCount(id, newStockCount);
        }
    }
}
