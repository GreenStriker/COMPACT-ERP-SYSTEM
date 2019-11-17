using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    
    public interface IDeliveryMethodService : IServiceBase<DeliveryMethod>
    {
    }

    public class DeliveryMethodService : ServiceBase<DeliveryMethod>, IDeliveryMethodService
    {
        public IDeliveryMethodRepository _repository { get; }
        public DeliveryMethodService(IDeliveryMethodRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
