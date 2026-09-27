using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.OrdersAgg.Services
{
    public interface IOrderDomainService
    {
        bool IsProductNotExist(Guid productId);
    }
}
