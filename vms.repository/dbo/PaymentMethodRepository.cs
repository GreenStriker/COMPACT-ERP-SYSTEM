using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IPaymentMethodRepository : IRepositoryBase<PaymentMethod>
    {
    }
    public class PaymentMethodRepository : RepositoryBase<PaymentMethod>, IPaymentMethodRepository
    {
        private readonly DbContext _context;

        public PaymentMethodRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
