using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using papara_firstweek_hwApp.API.Exceptions;
using papara_firstweek_hwApp.API.Extensions;
using papara_firstweek_hwApp.API.Filters;
using papara_firstweek_hwApp.API.Models;
using papara_firstweek_hwApp.API.Models.Shared;
using papara_firstweek_hwApp.API.Models.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});

// Add services to the container.

//SOLID prenciplerini uygulanabilir hale getirmke için ekleme yapmamýz gerekiyor(Dl Container kullanacagýz)
//builder.Services.AddScoped<IUserRepository, UserRepository>(); //uygulamada herhangi bir yerde
//IUserRepository gördüðüm yere UserRepository'den nesne örneði üret diyoruz kendimiz new'lemiyoruz
//builder.Services.AddScoped<IUserService, UserService>();

//burada artýk ürettiðimiz ext. ile serviceleri tek bir satýrda ekliyoruz

builder.Services.AddUserDlContainer();
builder.Services.AddProductFeatureDlContainer();
builder.Services.AddProductDlContainer();
builder.Services.AddProductdefinitionDlContainer();
builder.Services.AddCategoryDlContainer();




builder.Services.AddScoped<NotFoundActionFilter>();
builder.Services.AddScoped<IUnitOfWork , UnitOfWork>();


builder.Services.AddControllers(x =>
{
    x.Filters.Add<NotFoundActionFilter>();
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Directory.GetCurrentDirectory()));

builder.Services.AddAutoMapper(typeof(Program)); 

var app = builder.Build();

app.AddExceptionMiddleWare();


app.AddDefaultMiddlewaresExt();