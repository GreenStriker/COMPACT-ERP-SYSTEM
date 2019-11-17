using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IPaymentMethodService : IServiceBase<PaymentMethod>
    {
    }

    public class PaymentMethodService : ServiceBase<PaymentMethod>, IPaymentMethodService
    {
        public IPaymentMethodRepository _repository { get; }
        public PaymentMethodService(IPaymentMethodRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
