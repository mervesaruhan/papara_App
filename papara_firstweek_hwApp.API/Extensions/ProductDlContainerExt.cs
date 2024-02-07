using papara_firstweek_hwApp.API.Models.Products;
using papara_firstweek_hwApp.API.Models.Users;

namespace papara_firstweek_hwApp.API.Extensions
{
    public static class ProductDlContainerExt
    {
        public static void AddProductDlContainer(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}

