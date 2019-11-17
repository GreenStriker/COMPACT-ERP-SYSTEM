using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IPurchaseOrderDetailsRepository : IRepositoryBase<PurchaseDetail>
    {
    }
    public class PurchaseOrderDetailRepository : RepositoryBase<PurchaseDetail>, IPurchaseOrderDetailsRepository
    {
        private readonly DbContext _context;
        public PurchaseOrderDetailRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
