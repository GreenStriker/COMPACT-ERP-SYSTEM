using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface ITransectionTypeService : IServiceBase<TransectionType>
    {
    }

    public class TransectionTypeService : ServiceBase<TransectionType>, ITransectionTypeService
    {
        public ITransectionTypeRepository _repository { get; }
        public TransectionTypeService(ITransectionTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
