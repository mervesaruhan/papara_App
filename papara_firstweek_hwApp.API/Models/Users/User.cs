using papara_firstweek_hwApp.API.Models.Products;

namespace papara_firstweek_hwApp.API.Models.Users
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public int Age { get; set; }
        //public List<Product>? Products { get; set; } = new();
        public List<Product> Products { get; set; }


    }
}
