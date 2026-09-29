using Clean_arch.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.OrdersAgg
{
    public class OrderItem:BaseEntity
    {
        public OrderItem(long orderId, int count, Guid productId, Money price)
        {
            OrderId = orderId;
            Count = count;
            ProductId = productId;
            Price = price;
        }

        public long Id { get;private set; }
        public long OrderId { get;protected set; }
        public int Count { get; private set; }
        public Guid ProductId { get; private set; }
        public Money Price { get; private set; }
    }
}
