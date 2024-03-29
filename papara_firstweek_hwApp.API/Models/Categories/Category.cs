﻿using papara_firstweek_hwApp.API.Models.Products;

namespace papara_firstweek_hwApp.API.Models.Categories
{
    public class Category
    {
        public  int Id { get; set; }
        public string Name { get; set; } = default!;

        public List<Product>? Products { get; set; }

    }
}
