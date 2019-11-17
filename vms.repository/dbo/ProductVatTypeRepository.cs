using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IProductVatTypeRepository : IRepositoryBase<ProductVattype>
    {
    }

    public class ProductVatTypeRepository : RepositoryBase<ProductVattype>, IProductVatTypeRepository
    {
        private readonly DbContext _context;

        public ProductVatTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }

}
