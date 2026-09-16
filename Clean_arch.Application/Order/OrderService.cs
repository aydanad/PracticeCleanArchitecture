using Clean_arch.Application.Order.DTOs;
using Clean_arch.Contracts;
using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Orders.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Order
{
    public interface IOrderService
    {
        void AddOrder(AddOrderDto addOrderDto);
        void FinallyOrder(FinallyOrderDto finallyOrderDto);
        OrderDto GetOrderById(long id);
        List<OrderDto> GetOrders();
    }
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private ISMSService _smsService;

        public OrderService(IOrderRepository repository, ISMSService smsService)
        {
            _repository = repository;
            _smsService = smsService;
        }

        public void AddOrder(AddOrderDto addOrderDto)
        {
            var order = new Clean_arch.Domain.Orders.Order(addOrderDto.ProductId,addOrderDto.Count,addOrderDto.Price);
            _repository.Add(order);
            _repository.SaveChanges();
        }

        public void FinallyOrder(FinallyOrderDto finallyOrderDto)
        {
            var order = _repository.GetById(finallyOrderDto.OrderId);
            order.Finally();
            _repository.Update(order);
            _repository.SaveChanges();
            _smsService.SendSMS(new SMSBody()
            {
                Message = "text",
                PhoneNamber = "09332936144"
            });
        }

        public OrderDto GetOrderById(long id)
        {
            var order = _repository.GetById(id);
            return new OrderDto()
            {
                Count=order.Count,
                Price=order.Price,
                ProductId=order.ProductId
            };
        }

        public List<OrderDto> GetOrders()
        {
            return _repository.GetLists().Select(order => new OrderDto()
            {
                Count = order.Count,
                Price = order.Price,
                ProductId = order.ProductId
            }).ToList();

        }
    }
}
