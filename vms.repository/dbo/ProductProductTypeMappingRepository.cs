using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IProductProductTypeMappingRepository : IRepositoryBase<ProductProductTypeMapping>
    {
    }
    public class ProductProductTypeMappingRepository : RepositoryBase<ProductProductTypeMapping>, IProductProductTypeMappingRepository
    {
        private readonly DbContext _context;

        public ProductProductTypeMappingRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
