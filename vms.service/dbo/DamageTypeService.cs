using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IDamageTypeService : IServiceBase<DamageType>
    {
    }

    public class DamageTypeService : ServiceBase<DamageType>, IDamageTypeService
    {
        public IDamageTypeRepository _repository { get; }
        public DamageTypeService(IDamageTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
