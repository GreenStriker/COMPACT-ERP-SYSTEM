using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
 
    public interface IOrderRepository : IRepositoryBase<Order>
    {
    }
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        private readonly DbContext _context;

        public OrderRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
