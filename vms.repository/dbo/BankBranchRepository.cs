using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IBankBranchRepository : IRepositoryBase<BankBranch>
    {

    }
    public class BankBranchRepository : RepositoryBase<BankBranch>, IBankBranchRepository
    {
        private readonly DbContext _context;

        public BankBranchRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
