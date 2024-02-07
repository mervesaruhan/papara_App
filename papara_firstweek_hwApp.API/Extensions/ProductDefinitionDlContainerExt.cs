using papara_firstweek_hwApp.API.Models.Product_Definitions;
using papara_firstweek_hwApp.API.Models.Users;

namespace papara_firstweek_hwApp.API.Extensions
{
    public static class ProductDefinitionDlContainerExt
    {
        public static void AddProductdefinitionDlContainer(this IServiceCollection services)
        {
            services.AddScoped<IProductDefinitionRepository, ProductDefinitionRepository>();
            services.AddScoped<IProductDefinitionService, ProductDefinitionService>();
        }
    }
}

