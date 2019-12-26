using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.viewModels;
using vms.repository.dbo.StoredProcedure;

namespace vms.service.dbo.StoredProdecure
{
    public interface IStoreProcedureService
    {
        Task<bool> InsertCredit(vmCreditNote vm);
    }
   public class StoreProcedureService: IStoreProcedureService
    {
        private readonly IStoreProcedureRepository _repository;

        public StoreProcedureService(IStoreProcedureRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> InsertCredit(vmCreditNote vm)
        {
            return await _repository.InsertCredit(vm);
        }
    }
}
