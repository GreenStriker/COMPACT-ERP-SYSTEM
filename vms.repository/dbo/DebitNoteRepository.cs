using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface IDebitNoteRepository : IRepositoryBase<DebitNote>
    {
    }
    public class DebitNoteRepository : RepositoryBase<DebitNote>, IDebitNoteRepository
    {
        private readonly DbContext _context;

        public DebitNoteRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
