using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.entity.viewModels;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IProductService : IServiceBase<Product>
    {
        vmProduct GetProductAutoComplete();
    }

    public class ProductService : ServiceBase<Product>, IProductService
    {
        public IProductRepository _repository { get; }
        public ProductService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public vmProduct GetProductAutoComplete()
        {
            return _repository.GetProductAutoComplete();
        }
    }
}
