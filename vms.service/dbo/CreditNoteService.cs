using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{

    public interface ICreditNoteService : IServiceBase<CreditNote>
    {
    }

    public class CreditNoteService : ServiceBase<CreditNote>, ICreditNoteService
    {
        public ICreditNoteRepository _repository { get; }
        public CreditNoteService(ICreditNoteRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
