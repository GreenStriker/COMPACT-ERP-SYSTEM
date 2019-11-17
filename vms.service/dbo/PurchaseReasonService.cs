using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IPurchaseReasonService : IServiceBase<PurchaseReason>
    {
    }

    public class PurchaseReasonService : ServiceBase<PurchaseReason>, IPurchaseReasonService
    {
        public IPurchaseReasonRepository _repository { get; }
        public PurchaseReasonService(IPurchaseReasonRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
