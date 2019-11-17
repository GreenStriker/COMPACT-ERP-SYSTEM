using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    
    public interface IProductProductTypeMappingService : IServiceBase<ProductProductTypeMapping>
    {
    }

    public class ProductProductTypeMappingService : ServiceBase<ProductProductTypeMapping>, IProductProductTypeMappingService
    {
        public IProductProductTypeMappingRepository _repository { get; }
        public ProductProductTypeMappingService(IProductProductTypeMappingRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
