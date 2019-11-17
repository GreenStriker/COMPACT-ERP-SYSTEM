using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IProductGroupService : IServiceBase<ProductGroup>
    {
    }

    public class ProductGroupService : ServiceBase<ProductGroup>, IProductGroupService
    {
        public IProductGroupRepository _repository { get; }
        public ProductGroupService(IProductGroupRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
