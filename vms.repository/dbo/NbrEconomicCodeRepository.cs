using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface INbrEconomicCodeRepository : IRepositoryBase<NbrEconomicCode>
    {
        
    }
    public class NbrEconomicCodeRepository : RepositoryBase<NbrEconomicCode>, INbrEconomicCodeRepository
    {
        private readonly DbContext _context;

        public NbrEconomicCodeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
