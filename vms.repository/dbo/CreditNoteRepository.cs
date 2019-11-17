using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface ICreditNoteRepository : IRepositoryBase<CreditNote>
    {
    }
    public class CreditNoteRepository : RepositoryBase<CreditNote>, ICreditNoteRepository
    {
        private readonly DbContext _context;

        public CreditNoteRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
