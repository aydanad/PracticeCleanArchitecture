using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch_Infrastructure.Persistend.Memory
{
    public class Context
    {
        public List<Clean_arch.Domain.Products.Product> Products { get; set; }
        public List<Clean_arch.Domain.Orders.Order> Orders { get; set; } = new List<Clean_arch.Domain.Orders.Order>() { new Clean_arch.Domain.Orders.Order(Guid.NewGuid(), 1, 100) };
    }
}
