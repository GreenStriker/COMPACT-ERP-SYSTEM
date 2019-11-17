using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IPurchaseTypeRepository : IRepositoryBase<PurchaseType>
    {
    }

    public class PurchaseTypeRepository : RepositoryBase<PurchaseType>, IPurchaseTypeRepository
    {
        private readonly DbContext _context;

        public PurchaseTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
   
}
