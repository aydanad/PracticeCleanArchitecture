using Clean_arch.Application.Order;
using Clean_arch.Application.Product;
using Clean_arch.Contracts;
using Clean_arch.Domain.Orders.Repository;
using Clean_arch.Domain.Products.Repository;
using Clean_arch_Infrastructure;
using Clean_arch_Infrastructure.Persistend.Memory;
using Clean_arch_Infrastructure.Persistend.Memory.Order;
using Clean_arch_Infrastructure.Persistend.Memory.Product;
using Microsoft.Extensions.DependencyInjection;

namespace Clean_arch.Config
{
    public class ProjectBootStrapper
    {
        public static void Init(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISMSService, SMSServise>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
            serviceCollection.AddScoped<IProductService, ProductService>();
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
            serviceCollection.AddSingleton<Context>();
        }
    }
}
