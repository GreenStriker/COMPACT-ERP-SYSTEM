using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  
    public interface IAuditOperationRepository : IRepositoryBase<AuditOperation>
    {
    }
    public class AuditOperationRepository : RepositoryBase<AuditOperation>, IAuditOperationRepository
    {
        private readonly DbContext _context;

        public AuditOperationRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
