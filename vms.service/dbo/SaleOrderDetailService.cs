using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface ISaleOrderDetailService : IServiceBase<SalesDetail>
    {
    }
    public class SaleOrderDetailService : ServiceBase<SalesDetail>, ISaleOrderDetailService
    {
        public ISaleOrderDetailsRepository _repository { get; }

        public SaleOrderDetailService(ISaleOrderDetailsRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
