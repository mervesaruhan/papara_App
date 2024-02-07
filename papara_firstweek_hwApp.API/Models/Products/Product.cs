using Microsoft.EntityFrameworkCore;
using papara_firstweek_hwApp.API.Models.Categories;
using papara_firstweek_hwApp.API.Models.Products_Features;
using papara_firstweek_hwApp.API.Models.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace papara_firstweek_hwApp.API.Models.Products

/// <summary>
/// entity class for products
/// </summary>

{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        [Precision (18,2)]
        public decimal Price { get; set; }
        [ForeignKey("Category")] public int CategoryId { get; set; }
        public Category ? Category { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public ProductFeature? productFeatures { get; set; }
    }
}
