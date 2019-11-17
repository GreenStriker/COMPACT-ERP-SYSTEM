using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface ISaleOrderDetailsRepository : IRepositoryBase<SalesDetail>
    {

    }
    public class SaleOrderDetailRepository : RepositoryBase<SalesDetail>, ISaleOrderDetailsRepository
    {
        private readonly DbContext _context;

        public SaleOrderDetailRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
