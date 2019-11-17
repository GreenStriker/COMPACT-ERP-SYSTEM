using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    
    public interface IOrderService : IServiceBase<Order>
    {
    }

    public class OrderService : ServiceBase<Order>, IOrderService
    {
        public IOrderRepository _repository { get; }
        public OrderService(IOrderRepository repository) : base(repository)
        {
            _repository = repository;
           
        }
    }
}
