using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    
    public interface IPurchasePaymentService : IServiceBase<PurchasePayment>
    {
    }

    public class PurchasePaymentService : ServiceBase<PurchasePayment>, IPurchasePaymentService
    {
        public IPurchasePaymentRepository _repository { get; }
        public PurchasePaymentService(IPurchasePaymentRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
