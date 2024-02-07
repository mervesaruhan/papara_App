using Microsoft.EntityFrameworkCore;
using papara_firstweek_hwApp.API.Models.Categories;
using papara_firstweek_hwApp.API.Models.Product_Definitions;
using papara_firstweek_hwApp.API.Models.Products;
using papara_firstweek_hwApp.API.Models.Products_Features;
using papara_firstweek_hwApp.API.Models.Users;

namespace papara_firstweek_hwApp.API.Models.Shared;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }


    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }
    public DbSet<ProductDefinition> ProductDefinitions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("SqlServer");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p=>p.CategoryId);
        //modelBuilder.Entity<User>().HasMany( u => u.Products).WithOne(p => p.User).HasForeignKey(p=>p.UserId);
        //modelBuilder.Entity<Product>().HasKey(p => p.Id);
        base.OnModelCreating(modelBuilder);
    }
}
