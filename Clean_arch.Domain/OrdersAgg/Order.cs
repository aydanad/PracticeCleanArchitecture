using Clean_arch.Domain.OrdersAgg;
using Clean_arch.Domain.OrdersAgg.Services;
using Clean_arch.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Orders
{
    public class Order
    {
        public long Id { get; private set; }
        public Guid ProductId { get; private set; }
        public int TotalItems { get; set; }
        public ICollection<OrderItem> Items { get;private set; }
        public bool IsFinally { get; private set; }
        public DateTime FinallyDate { get; private set; }
        public Order(Guid productId)
        {
            ProductId = productId;
        }
        public void Finally()
        {
            IsFinally = true;
            FinallyDate = DateTime.Now;
        }
        public void AddItem(Guid productId,int count,int price,IOrderDomainService orderDomainService)
        {
            if (orderDomainService.IsProductNotExist(productId))
                throw new Exception("");
            if (Items.Any(p => p.ProductId == productId))
                return;

            Items.Add(new OrderItem(Id, count, productId, Money.FromToman(price)));
            TotalItems += count;
        }
        public void RemoveItem(Guid ProductId)
        {
            var item = Items.FirstOrDefault(f => f.ProductId == ProductId);
            if (item == null)
                throw new Exception("");
            Items.Remove(item);
            TotalItems -= item.Count;
        }
    }
}
