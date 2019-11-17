using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo.acc
{
   
    public interface ICoagroupService : IServiceBase<Coagroup>
    {
    }

    public class CoagroupService : ServiceBase<Coagroup>, ICoagroupService
    {
        public ICoagroupRepository _repository { get; }
        public CoagroupService(ICoagroupRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
