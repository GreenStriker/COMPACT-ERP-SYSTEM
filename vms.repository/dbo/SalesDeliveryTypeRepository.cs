using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface ISalesDeliveryTypeRepository : IRepositoryBase<SalesDeliveryType>
    {
    }
    public class SalesDeliveryTypeRepository : RepositoryBase<SalesDeliveryType>, ISalesDeliveryTypeRepository
    {
        private readonly DbContext _context;

        public SalesDeliveryTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
