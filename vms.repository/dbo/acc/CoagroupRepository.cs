using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface ICoagroupRepository : IRepositoryBase<Coagroup>
    {
    }
    public class CoagroupRepository : RepositoryBase<Coagroup>, ICoagroupRepository
    {
        private readonly DbContext _context;

        public CoagroupRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}

