using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IBankService : IServiceBase<Bank>
    {
    }
    public class BankService : ServiceBase<Bank>, IBankService
    {
        public IBankRepository _repository { get; }
        public BankService(IBankRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
