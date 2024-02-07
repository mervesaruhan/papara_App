using papara_firstweek_hwApp.API.Models.Categories;
using papara_firstweek_hwApp.API.Models.Users;

namespace papara_firstweek_hwApp.API.Extensions
{
    public static class CategoryDlContainerExt
    {
        public static void AddCategoryDlContainer(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
