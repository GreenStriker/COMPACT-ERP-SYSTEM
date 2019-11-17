using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    
    public interface ISalesDeliveryTypeService : IServiceBase<SalesDeliveryType>
    {
    }

    public class SalesDeliveryTypeService : ServiceBase<SalesDeliveryType>, ISalesDeliveryTypeService
    {
        public ISalesDeliveryTypeRepository _repository { get; }
        public SalesDeliveryTypeService(ISalesDeliveryTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
