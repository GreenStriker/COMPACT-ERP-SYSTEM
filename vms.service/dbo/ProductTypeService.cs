using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IProductTypeService : IServiceBase<ProductType>
    {
    }

    public class ProductTypeService : ServiceBase<ProductType>, IProductTypeService
    {
        public IProductTypeRepository _repository { get; }
        public ProductTypeService(IProductTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
