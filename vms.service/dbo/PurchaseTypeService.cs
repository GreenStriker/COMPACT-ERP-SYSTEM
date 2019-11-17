using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IPurchaseTypeService : IServiceBase<PurchaseType>
    {
    }
    public class PurchaseTypeService : ServiceBase<PurchaseType>, IPurchaseTypeService
    {
        public IPurchaseTypeRepository _repository { get; }

        public PurchaseTypeService(IPurchaseTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
   
}
