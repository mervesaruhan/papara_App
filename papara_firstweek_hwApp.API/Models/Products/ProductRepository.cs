using Microsoft.EntityFrameworkCore;
using papara_firstweek_hwApp.API.Models.Shared;

namespace papara_firstweek_hwApp.API.Models.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Add(product);
            //_context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            // var product = new Product()
            // {
            // 	Name = "ayakkabı", Price = 800, Description = "kırmzı bot"
            // };
            //
            // var state1 = _context.Entry(product).State;
            //
            // _context.Products.Add(product);
            //
            // var state2 = _context.Entry(product).State;


            //var products= _context.Products.ToList();
            //
            // products[0].Name = "kazak3";

            //var currentState=	_context.Entry(products[0]).State;


            var products = _context.Products.ToList();


            _context.SaveChanges();


            return products;

        }

        public List<Product> GetAllProductsWithCategory()
        {
            return _context.Products.Include(p => p.Category).Include(p=>p.productFeatures).ToList();

        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                //_context.SaveChanges();
            }
        }

        public Product? GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Update(Product product)
        {
            _context.Update(product);
            //_context.SaveChanges();
        }
    }
}
