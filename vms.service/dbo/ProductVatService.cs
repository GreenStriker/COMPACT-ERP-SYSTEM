using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    
    public interface IProductVatService : IServiceBase<ProductVat>
    {
    }

    public class ProductVatService : ServiceBase<ProductVat>, IProductVatService
    {
        public IProductVatRepository _repository { get; }
        public ProductVatService(IProductVatRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
