using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  
    public interface ISalesDetailRepository : IRepositoryBase<SalesDetail>
    {
    }
    public class SalesDetailRepository : RepositoryBase<SalesDetail>, ISalesDetailRepository
    {
        private readonly DbContext _context;

        public SalesDetailRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
