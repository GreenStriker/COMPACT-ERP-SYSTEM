using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    
    public interface IPurchaseDetailRepository : IRepositoryBase<PurchaseDetail>
    {
    }
    public class PurchaseDetailRepository : RepositoryBase<PurchaseDetail>, IPurchaseDetailRepository
    {
        private readonly DbContext _context;

        public PurchaseDetailRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
