using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IPurchaseOrderDetailService : IServiceBase<PurchaseDetail>
    {

    }
    public class PurchaseOrderDetailService : ServiceBase<PurchaseDetail>, IPurchaseOrderDetailService
    {
        public IPurchaseOrderDetailsRepository _repository { get; }
        public PurchaseOrderDetailService(IPurchaseOrderDetailsRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
