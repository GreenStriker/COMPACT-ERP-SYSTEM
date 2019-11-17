using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IProductCategoryService : IServiceBase<ProductCategory>
    {
    }

    public class ProductCategoryService : ServiceBase<ProductCategory>, IProductCategoryService
    {
        public IProductCategoryRepository _repository { get; }
        public ProductCategoryService(IProductCategoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
