using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface ISaleOrdersService : IServiceBase<SaleOrders>
    {
    }
    public class SaleOrdersService : ServiceBase<SaleOrders>, ISaleOrdersService
    {
        public ISaleOrderRepository _repository { get; }

        public SaleOrdersService(ISaleOrderRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
