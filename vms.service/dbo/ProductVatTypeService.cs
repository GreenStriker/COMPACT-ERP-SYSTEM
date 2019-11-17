using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IProductVatTypeService : IServiceBase<ProductVattype>
    {
    }

    public class ProductVatTypeService : ServiceBase<ProductVattype>, IProductVatTypeService
    {
        public IProductVatTypeRepository _repository { get; }
        public ProductVatTypeService(IProductVatTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
