using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface ISalesDetailService : IServiceBase<SalesDetail>
    {
    }

    public class SalesDetailService : ServiceBase<SalesDetail>, ISalesDetailService
    {
        public ISalesDetailRepository _repository { get; }
        public SalesDetailService(ISalesDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
