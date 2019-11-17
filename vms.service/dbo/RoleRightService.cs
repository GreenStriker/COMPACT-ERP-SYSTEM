using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IRoleRightService : IServiceBase<RoleRight>
    {
    }

    public class RoleRightService : ServiceBase<RoleRight>, IRoleRightService
    {
        public IRoleRightRepository _repository { get; }
        public RoleRightService(IRoleRightRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
