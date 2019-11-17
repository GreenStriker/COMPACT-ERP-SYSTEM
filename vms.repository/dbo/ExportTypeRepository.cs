using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  
    public interface IExportTypeRepository : IRepositoryBase<ExportType>
    {
    }
    public class ExportTypeRepository : RepositoryBase<ExportType>, IExportTypeRepository
    {
        private readonly DbContext _context;

        public ExportTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
