using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IProductCategoryRepository : IRepositoryBase<ProductCategory>
    {
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        private readonly DbContext _context;

        public ProductCategoryRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
