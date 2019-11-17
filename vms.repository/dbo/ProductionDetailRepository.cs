using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IProductionDetailRepository : IRepositoryBase<ProductionDetail>
    {
    }
    public class ProductionDetailRepository : RepositoryBase<ProductionDetail>, IProductionDetailRepository
    {
        private readonly DbContext _context;

        public ProductionDetailRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
