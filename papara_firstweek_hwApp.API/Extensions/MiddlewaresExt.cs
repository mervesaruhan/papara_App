using Microsoft.AspNetCore.Diagnostics;
using papara_firstweek_hwApp.API.Exceptions;
using papara_firstweek_hwApp.API.Models.Shared;

namespace papara_firstweek_hwApp.API.Extensions
{
    public static class MiddlewaresExt
    {
        public static void AddDefaultMiddlewaresExt(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();


        }

        public static void AddExceptionMiddleWare(this WebApplication app)
        {
            app.UseExceptionHandler(innerapp =>
            {
                app.Run(async context =>
                {
                    Exception? exception = context.Features.Get<IExceptionHandlerPathFeature>()?.Error;

                    if (exception is null) return;
                    var responseDto = ResponseDto<object>.Fail(exception.Message);
                    context.Response.StatusCode = exception is ClientValidationError ? 400 : 500;

                    await context.Response.WriteAsJsonAsync(responseDto);

                });

            });

        }
    }
}
