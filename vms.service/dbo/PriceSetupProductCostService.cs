using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IPriceSetupProductCostService : IServiceBase<PriceSetupProductCost>
    {
    }
    public   class PriceSetupProductCostService : ServiceBase<PriceSetupProductCost>, IPriceSetupProductCostService
    {
        public IPriceSetupProductCostRepository _repository { get; }
        public PriceSetupProductCostService(IPriceSetupProductCostRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
