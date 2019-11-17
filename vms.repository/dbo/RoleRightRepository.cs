using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    
    public interface IRoleRightRepository : IRepositoryBase<RoleRight>
    {
    }
    public class RoleRightRepository : RepositoryBase<RoleRight>, IRoleRightRepository
    {
        private readonly DbContext _context;

        public RoleRightRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
