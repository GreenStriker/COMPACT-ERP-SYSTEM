using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IAuditLogService : IServiceBase<AuditLog>
    {
        Task<bool> RestoreAudit(vmRestore vmRestore);
    }

    public class AuditLogService : ServiceBase<AuditLog>, IAuditLogService
    {
        public IAuditLogRepository _repository { get; }
        public AuditLogService(IAuditLogRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<bool> RestoreAudit(vmRestore vmRestore)
        {
            return _repository.RestoreAuditAsync(vmRestore);
           
        }
    }
}
