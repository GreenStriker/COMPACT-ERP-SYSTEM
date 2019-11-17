using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{

    public interface IDebitNoteService : IServiceBase<DebitNote>
    {
    }

    public class DebitNoteService : ServiceBase<DebitNote>, IDebitNoteService
    {
        public IDebitNoteRepository _repository { get; }
        public DebitNoteService(IDebitNoteRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
