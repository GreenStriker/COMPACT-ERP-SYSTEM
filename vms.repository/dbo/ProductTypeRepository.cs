using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IProductTypeRepository : IRepositoryBase<ProductType>
    {
    }
    public class ProductTypeRepository : RepositoryBase<ProductType>, IProductTypeRepository
    {
        private readonly DbContext _context;

        public ProductTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
