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

    }
}
