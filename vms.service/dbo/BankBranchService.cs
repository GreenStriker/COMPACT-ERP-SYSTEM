using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IBankBranchService : IServiceBase<BankBranch>
    {
    }
   public class BankBranchService : ServiceBase<BankBranch>, IBankBranchService
    {
        public IBankBranchRepository _repository { get; }
        public BankBranchService(IBankBranchRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
