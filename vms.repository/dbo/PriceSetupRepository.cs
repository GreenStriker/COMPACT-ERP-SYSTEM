using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  
    public interface IPriceSetupRepository : IRepositoryBase<PriceSetup>
    {
    }
    public class PriceSetupRepository : RepositoryBase<PriceSetup>, IPriceSetupRepository
    {
        private readonly DbContext _context;

        public PriceSetupRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
