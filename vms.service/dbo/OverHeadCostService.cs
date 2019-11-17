using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IOverHeadCostService : IServiceBase<OverHeadCost>
    {
    }
    public class OverHeadCostService : ServiceBase<OverHeadCost>, IOverHeadCostService
    {
        public IOverHeadCostRepository _repository { get; }
        public OverHeadCostService(IOverHeadCostRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
