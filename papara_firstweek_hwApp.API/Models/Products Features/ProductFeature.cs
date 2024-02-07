using papara_firstweek_hwApp.API.Models.Products;

namespace papara_firstweek_hwApp.API.Models.Products_Features
{
    public class ProductFeature
    {public int Id { get; set; }
        public int Height { get; set; } = default!;
        public int Width { get; set; } = default!;
        public string Color { get; set; } = default!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = default!;

    }
}
