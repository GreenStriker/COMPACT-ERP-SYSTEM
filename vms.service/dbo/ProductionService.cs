using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IProductionService : IServiceBase<ProductionReceive>
    {
        Task<bool> InsertData(vmProductionReceive production);
    }
    public class ProductionService : ServiceBase<ProductionReceive>, IProductionService
    {
        public IProductionRepository _repository { get; }
        
        public ProductionService(IProductionRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public async Task<bool> InsertData(vmProductionReceive production)
        {
            return await _repository.InsertData(production);
        }
    }
}
