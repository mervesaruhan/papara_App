using Microsoft.Extensions.FileProviders;
using papara_firstweek_hwApp.API.Extensions;
using papara_firstweek_hwApp.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//SOLID prenciplerini uygulanabilir hale getirmke i�in ekleme yapmam�z gerekiyor(Dl Container kullanacag�z)
//builder.Services.AddScoped<IUserRepository, UserRepository>(); //uygulamada herhangi bir yerde IUserRepository g�rd���m yere UserRepository'den nesne �rne�i �ret diyoruz kendimiz new'lemiyoruz
//builder.Services.AddScoped<IUserService, UserService>();

//burada art�k �retti�imiz ext. ile serviceleri tek bir sat�rda ekliyoruz

builder.Services.AddUserDlContainer();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Directory.GetCurrentDirectory()));

builder.Services.AddAutoMapper(typeof(Program)); 

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
// app.UseSwagger();
// app.UseSwaggerUI();
//}

//app.UseStaticFiles();
//app.UseHttpsRedirection();
//app.UseAuthorization();
//app.MapControllers();
//app.Run();

app.AddDefaultMiddlewaresExt();