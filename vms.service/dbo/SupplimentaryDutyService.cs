using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface ISupplimentaryDutyService : IServiceBase<SupplimentaryDuty>
    {
    }

    public class SupplimentaryDutyService : ServiceBase<SupplimentaryDuty>, ISupplimentaryDutyService
    {
        public ISupplimentaryDutyRepository _repository { get; }
        public SupplimentaryDutyService(ISupplimentaryDutyRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
