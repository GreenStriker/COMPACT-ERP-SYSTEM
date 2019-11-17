using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface ISaleOrderRepository : IRepositoryBase<SaleOrders>
    {
    }
    public class  SaleOrderRepository : RepositoryBase<SaleOrders>, ISaleOrderRepository
    {
        private readonly DbContext _context;

        public SaleOrderRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
