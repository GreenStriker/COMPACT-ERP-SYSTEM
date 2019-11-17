using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    
    public interface IDocumentTypeService : IServiceBase<DocumentType>
    {
    }

    public class DocumentTypeService : ServiceBase<DocumentType>, IDocumentTypeService
    {
        public IDocumentTypeRepository _repository { get; }
        public DocumentTypeService(IDocumentTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
