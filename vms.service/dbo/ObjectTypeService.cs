using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
  
    public interface IObjectTypeService : IServiceBase<ObjectType>
    {
    }

    public class ObjectTypeService : ServiceBase<ObjectType>, IObjectTypeService
    {
        public IObjectTypeRepository _repository { get; }
        public ObjectTypeService(IObjectTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
