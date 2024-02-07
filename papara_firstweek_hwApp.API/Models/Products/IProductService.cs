using papara_firstweek_hwApp.API.Models.DTOs;
using papara_firstweek_hwApp.API.Models.Shared;

namespace papara_firstweek_hwApp.API.Models.Products
{
    public interface IProductService
    {
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        List<Product> GetAll();
        ResponseDto<int> Add(ProductAddDtoRequest request);
        List<Product> GetAllProductsWithCategories();
    }
}
