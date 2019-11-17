using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
   
    public interface ITransectionTypeRepository : IRepositoryBase<TransectionType>
    {
    }
    public class TransectionTypeRepository : RepositoryBase<TransectionType>, ITransectionTypeRepository
    {
        private readonly DbContext _context;

        public TransectionTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
