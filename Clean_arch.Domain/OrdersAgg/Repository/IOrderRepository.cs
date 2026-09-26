using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Orders.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetLists();
        Order GetById(long Id);
        void Add(Order order);
        void Update(Order order);
        void SaveChanges();
    }
}
