using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
  
    public interface ISalesTypeService : IServiceBase<SalesType>
    {
    }

    public class SalesTypeService : ServiceBase<SalesType>, ISalesTypeService
    {
        public ISalesTypeRepository _repository { get; }
        public SalesTypeService(ISalesTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
