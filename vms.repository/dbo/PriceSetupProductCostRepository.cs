using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IPriceSetupProductCostRepository : IRepositoryBase<PriceSetupProductCost>
    {
    }
   public class PriceSetupProductCostRepository : RepositoryBase<PriceSetupProductCost>, IPriceSetupProductCostRepository
    {
        private readonly DbContext _context;

        public PriceSetupProductCostRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
