using Azure.Core;
using papara_firstweek_hwApp.API.Models.DTOs;
using papara_firstweek_hwApp.API.Models.Product_Definitions;
using papara_firstweek_hwApp.API.Models.Shared;
using papara_firstweek_hwApp.API.Models.UnitOfWorks;

namespace papara_firstweek_hwApp.API.Models.Products
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly ProductDefinitionRepository _productDefinitionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductService(ProductDefinitionRepository productDefinitionRepository)
        {
            _productDefinitionRepository = productDefinitionRepository;
        }

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        //public ResponseDto<int> Add(ProductAddDtoRequest request)
        //{
            //var id = new Random().Next(1, 1000);


            //var product = new Product
            //{
                //Id = id,
                //Name = request.Name,
                //Price = request.Price!.Value
            //};

            //_productRepository.Add(product);
            //return ResponseDto<int>.Success(id);
        //}


        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }



        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }



        public Product GetById(int id)
        {
            return _productRepository.GetById(id);

        }

        public List<Product> GetAllProductsWithCategories()
        {
            return _productRepository.GetAllProductsWithCategory();
        }



        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }



        public ResponseDto<int> Add(ProductAddDtoRequest request)
        {
        using var transaction = _unitOfWork.BeginTransaction();
        var product = new Product
        {
        Name = request.Name,
        Price = request.Price!.Value,
        Description = request.Description,
        CategoryId = request.CategoryId
        };

        _productRepository.Add(product);
        _unitOfWork.Commit();
        var productDefinition = new ProductDefinition
        {
        StockCount = 800,
        ProductId = product.Id
        };
        _productDefinitionRepository.Add(productDefinition);


        _unitOfWork.Commit();
        transaction.Commit();
        return ResponseDto<int>.Success(product.Id);
        }
    }
}
