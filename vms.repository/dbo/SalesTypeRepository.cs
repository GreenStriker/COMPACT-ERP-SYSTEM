using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface ISalesTypeRepository : IRepositoryBase<SalesType>
    {
    }
    public class SalesTypeRepository : RepositoryBase<SalesType>, ISalesTypeRepository
    {
        private readonly DbContext _context;

        public SalesTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
