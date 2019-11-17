using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.StoredProcedureModel;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IMushakGenerationService : IServiceBase<MushakGeneration>
    {
        Task<bool> InsertMushak(SpAddMushakReturnBasicInfo vm);
        Task<bool> InsertReturnPlanToPaymentInfo(SpAddMushakReturnPlanToPaymentInfo model);
        Task<bool> InsertReturnPaymentInfo(SpAddMushakReturnPaymentInfo model);
        Task<bool> InsertSubmissionInfo(SpAddMushakReturnSubmissionInfo model);
        Task<bool> InsertReturnReturnedAmountInfo(SpAddMushakReturnReturnedAmountInfo model);
        Task<bool> InsertAddMushakReturnCompleteProcess(int id);
    }

    public class MushakGenerationService : ServiceBase<MushakGeneration>, IMushakGenerationService
    {
        public IMushakGenerationRepository _repository { get; }

        public MushakGenerationService(IMushakGenerationRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<bool> InsertMushak(SpAddMushakReturnBasicInfo vm)
        {
            return await _repository.InsertMushak(vm);
        }

        public async Task<bool> InsertReturnPlanToPaymentInfo(SpAddMushakReturnPlanToPaymentInfo model)
        {
            return await _repository.InsertReturnPlanToPaymentInfo(model);
        }

        public async Task<bool> InsertReturnPaymentInfo(SpAddMushakReturnPaymentInfo model)
        {
            return await _repository.InsertReturnPaymentInfo(model);
        }

        public async Task<bool> InsertSubmissionInfo(SpAddMushakReturnSubmissionInfo vm)
        {
            return await _repository.InsertSubmissionInfo(vm);
        }

        public async Task<bool> InsertReturnReturnedAmountInfo(SpAddMushakReturnReturnedAmountInfo model)
        {
            return await _repository.InsertReturnReturnedAmountInfo(model);
        }

        public async Task<bool> InsertAddMushakReturnCompleteProcess(int id)
        {
            return await _repository.InsertAddMushakReturnCompleteProcess(id);
        }
    }
}
