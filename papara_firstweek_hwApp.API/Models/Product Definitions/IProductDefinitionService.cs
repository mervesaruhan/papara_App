namespace papara_firstweek_hwApp.API.Models.Product_Definitions
{
    public interface IProductDefinitionService
    {
        ProductDefinition AddProductDefinition(ProductDefinition productDefinition);
        ProductDefinition GetProductDefinitionById(int id);
        void DeleteProductDefinition(int id);
        void UpdateStockCount(int id, int newStockCount);
    }
}
