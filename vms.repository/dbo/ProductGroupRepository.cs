using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    
    public interface IProductGroupRepository : IRepositoryBase<ProductGroup>
    {
    }
    public class ProductGroupRepository : RepositoryBase<ProductGroup>, IProductGroupRepository
    {
        private readonly DbContext _context;

        public ProductGroupRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
