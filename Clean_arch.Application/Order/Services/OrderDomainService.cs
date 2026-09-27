using Clean_arch.Domain.OrdersAgg.Services;
using Clean_arch.Domain.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Order.Services
{
    public class OrderDomainService : IOrderDomainService
    {
        private readonly IProductRepository _productRepository;

        public OrderDomainService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool IsProductNotExist(Guid productId)
        {
            var productIsExsit = _productRepository.IsProductExsit(productId);
            return !productIsExsit;
        }
    }
}
