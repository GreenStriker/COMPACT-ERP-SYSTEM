using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IOverHeadCostRepository : IRepositoryBase<OverHeadCost>
    {
        
    }
   public class OverHeadCostRepository : RepositoryBase<OverHeadCost>, IOverHeadCostRepository
    {
        private readonly DbContext _context;

        public OverHeadCostRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
