using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IPurchasePaymentRepository : IRepositoryBase<PurchasePayment>
    {
    }
    public class PurchasePaymentRepository : RepositoryBase<PurchasePayment>, IPurchasePaymentRepository
    {
        private readonly DbContext _context;

        public PurchasePaymentRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
