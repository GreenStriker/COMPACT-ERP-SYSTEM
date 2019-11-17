using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  
    public interface IProductVatRepository : IRepositoryBase<ProductVat>
    {
    }
    public class ProductVatRepository : RepositoryBase<ProductVat>, IProductVatRepository
    {
        private readonly DbContext _context;

        public ProductVatRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
