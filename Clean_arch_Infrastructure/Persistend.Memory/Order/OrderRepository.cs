using Clean_arch.Domain.Orders.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch_Infrastructure.Persistend.Memory.Order
{
    public class OrderRepository : IOrderRepository
    {
        private Context _context;

        public OrderRepository(Context context)
        {
            _context = context;
        }

        public void Add(Clean_arch.Domain.Orders.Order order)
        {
            _context.Orders.Add(order);
        }

        public Clean_arch.Domain.Orders.Order GetById(long Id)
        {
            return _context.Orders.FirstOrDefault(c => c.Id == Id);
        }

        public List<Clean_arch.Domain.Orders.Order> GetLists()
        {
            return _context.Orders;
        }

        public void SaveChanges()
        {
            //
        }

        public void Update(Clean_arch.Domain.Orders.Order order)
        {
            var oldOrder = GetById(order.Id);
            _context.Orders.Remove(oldOrder);
            Add(order);
        }
    }
}
