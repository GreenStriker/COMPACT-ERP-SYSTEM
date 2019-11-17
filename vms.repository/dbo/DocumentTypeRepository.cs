using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  
    public interface IDocumentTypeRepository : IRepositoryBase<DocumentType>
    {
    }
    public class DocumentTypeRepository : RepositoryBase<DocumentType>, IDocumentTypeRepository
    {
        private readonly DbContext _context;

        public DocumentTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
