using Clean_arch.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.OrdersAgg.Events
{
    public class OrderFinalized:BaseDomainEvent
    {
        public OrderFinalized(long orderId, long userId)
        {
            OrderId = orderId;
            UserId = userId;
        }

        public long OrderId { get;private set; }
        public long UserId { get;private set; }
    }
}
