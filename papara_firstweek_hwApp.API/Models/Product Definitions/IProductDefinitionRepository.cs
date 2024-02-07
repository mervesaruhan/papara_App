namespace papara_firstweek_hwApp.API.Models.Product_Definitions
{
    public interface IProductDefinitionRepository
    {
        ProductDefinition Add(ProductDefinition productDefinition);
        ProductDefinition? GetById(int id);
        void Delete(int id);
        void UpdateStockCount(int id, int newStockCount);
    }
}
