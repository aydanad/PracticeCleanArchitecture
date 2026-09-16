using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Order.DTOs
{
    public class OrderDto
    {
        public long Id { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
    public class FinallyOrderDto
    {
        public long OrderId { get; set; }
    }
    public class AddOrderDto
    {
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
