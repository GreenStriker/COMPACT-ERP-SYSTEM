using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface ISalePaymentService : IServiceBase<SalePayment>
    {
        Task<IEnumerable<SalePayment>> GetAll();
        Task<SalePayment> GetById(int id);
    }
    public class SalePaymentService : ServiceBase<SalePayment>, ISalePaymentService
    {
        public ISalePaymentRepository _repository { get; }
        public SalePaymentService(ISalePaymentRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<SalePayment>> GetAll()
        {
            return await _repository.GetAll();
        }
        public async Task<SalePayment> GetById(int id)
        {
            return await _repository.GetById(id);
        }
    }
}
