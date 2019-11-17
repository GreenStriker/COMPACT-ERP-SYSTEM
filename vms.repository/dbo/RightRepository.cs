using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  
    public interface IRightRepository : IRepositoryBase<Right>
    {
    }
    public class RightRepository : RepositoryBase<Right>, IRightRepository
    {
        private readonly DbContext _context;

        public RightRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
