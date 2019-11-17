using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
  public interface IPriceSetupService : IServiceBase<PriceSetup>
    {
    }

    public class PriceSetupService : ServiceBase<PriceSetup>, IPriceSetupService
    {
        public IPriceSetupRepository _repository { get; }
        public PriceSetupService(IPriceSetupRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
