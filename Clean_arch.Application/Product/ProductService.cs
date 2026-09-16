using Clean_arch.Application.Order.DTOs;
using Clean_arch.Application.Product.DTOs;
using Clean_arch.Domain.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Product
{
    public interface IProductService
    {
        void AddProduct(AddProductDto addProductDto);
        void EditProduct(EditProductDto editProductDto);
        ProductDto GetProductById(Guid productId);
        List<ProductDto> GetProducts();
    }
    public class ProductService:IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(AddProductDto addProductDto)
        {
            _repository.Add(new Clean_arch.Domain.Products.Product(addProductDto.Title, addProductDto.Price));
            _repository.SaveChanges();
        }

        public void EditProduct(EditProductDto editProductDto)
        {
            var product = _repository.GetById(editProductDto.Id);
            product.Edit(editProductDto.Title, editProductDto.Price);

            _repository.Update(product);
            _repository.SaveChanges();
        }

        public ProductDto GetProductById(Guid productId)
        {
            var product = _repository.GetById(productId);
            return new ProductDto()
            {
                Price = product.Price,
                Id = productId,
                Title = product.Title
            };
        }

        public List<ProductDto> GetProducts()
        {
            return _repository.GetLists().Select(product => new ProductDto()
            {
                Price = product.Price,
                Id = product.Id,
                Title = product.Title
            }).ToList();

        }
    }
}
