using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IAuditOperationService : IServiceBase<AuditOperation>
    {
    }

    public class AuditOperationService : ServiceBase<AuditOperation>, IAuditOperationService
    {
        public IAuditOperationRepository _repository { get; }
        public AuditOperationService(IAuditOperationRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
