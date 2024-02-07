using papara_firstweek_hwApp.API.Models.Products;

namespace papara_firstweek_hwApp.API.Models.Product_Definitions
{
    public class ProductDefinition
    {
        public int Id { get; set; }

        public int StockCount { get; set; }

        public int ProductId { get; set; }

        public Product Products { get; set; } = default!;
    }
}
