using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IDamageTypeRepository : IRepositoryBase<DamageType>
    {
    }
    public class DamageTypeRepository : RepositoryBase<DamageType>, IDamageTypeRepository
    {
        private readonly DbContext _context;

        public DamageTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
