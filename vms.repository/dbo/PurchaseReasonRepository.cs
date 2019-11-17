using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   public interface IPurchaseReasonRepository : IRepositoryBase<PurchaseReason>
    {
    }
    public class PurchaseReasonRepository : RepositoryBase<PurchaseReason>, IPurchaseReasonRepository
    {
        private readonly DbContext _context;

        public PurchaseReasonRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
