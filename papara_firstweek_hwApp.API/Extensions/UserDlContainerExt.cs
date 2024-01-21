using papara_firstweek_hwApp.API.Models;

namespace papara_firstweek_hwApp.API.Extensions
{
    public static class UserDlContainerExt
    {
public static void  AddUserDlContainer(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
