using papara_firstweek_hwApp.API.Models.Products_Features;

namespace papara_firstweek_hwApp.API.Extensions
{
    public static class ProductFeatureDlContainerExt
    {
 public static void AddProductFeatureDlContainer(this IServiceCollection services)
        {
            services.AddScoped<IProductFeatureRepository, ProductFeatureRepository>();
            services.AddScoped<IProductFeatureService, ProductFeatureService>();
        }
    }
}
 
