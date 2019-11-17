using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IPurchaseDetailService : IServiceBase<PurchaseDetail>
    {
    }

    public class PurchaseDetailService : ServiceBase<PurchaseDetail>, IPurchaseDetailService
    {
        public IPurchaseDetailRepository _repository { get; }
        public PurchaseDetailService(IPurchaseDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
