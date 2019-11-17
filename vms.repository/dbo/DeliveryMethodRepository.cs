using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface IDeliveryMethodRepository : IRepositoryBase<DeliveryMethod>
    {
    }
    public class DeliveryMethodRepository : RepositoryBase<DeliveryMethod>, IDeliveryMethodRepository
    {
        private readonly DbContext _context;

        public DeliveryMethodRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
