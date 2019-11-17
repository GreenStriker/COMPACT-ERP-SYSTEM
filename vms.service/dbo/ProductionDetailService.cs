using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;
namespace vms.service.dbo
{
    public interface IProductionDetailService : IServiceBase<ProductionDetail>
    {
    }
    public class ProductionDetailService : ServiceBase<ProductionDetail>, IProductionDetailService
    {
        public IProductionDetailRepository _repository { get; }
        public ProductionDetailService(IProductionDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
