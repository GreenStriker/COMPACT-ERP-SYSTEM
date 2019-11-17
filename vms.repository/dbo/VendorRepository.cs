using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IVendorRepository : IRepositoryBase<Vendor>
    {
    }
    public class VendorRepository : RepositoryBase<Vendor>, IVendorRepository
    {
        private readonly DbContext _context;

        public VendorRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
