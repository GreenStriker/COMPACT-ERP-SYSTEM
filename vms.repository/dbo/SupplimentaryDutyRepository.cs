using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface ISupplimentaryDutyRepository : IRepositoryBase<SupplimentaryDuty>
    {
    }
    public class SupplimentaryDutyRepository : RepositoryBase<SupplimentaryDuty>, ISupplimentaryDutyRepository
    {
        private readonly DbContext _context;

        public SupplimentaryDutyRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
