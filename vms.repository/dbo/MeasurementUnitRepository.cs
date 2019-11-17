using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IMeasurementUnitRepository : IRepositoryBase<MeasurementUnit>
    {
    }
    public class MeasurementUnitRepository : RepositoryBase<MeasurementUnit>, IMeasurementUnitRepository
    {
        private readonly DbContext _context;

        public MeasurementUnitRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
