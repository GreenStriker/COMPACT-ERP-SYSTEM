using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IRightService : IServiceBase<Right>
    {
    }

    public class RightService : ServiceBase<Right>, IRightService
    {
        public IRightRepository _repository { get; }
        public RightService(IRightRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
