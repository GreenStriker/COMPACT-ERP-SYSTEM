using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IBankRepository : IRepositoryBase<Bank>
    {

    }
   public class BankRepository : RepositoryBase<Bank>, IBankRepository
    {
        private readonly DbContext _context;

        public BankRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
