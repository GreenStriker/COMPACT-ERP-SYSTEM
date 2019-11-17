using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IPurchaseOrderService : IServiceBase<Purchase>
    {
        Task<bool> InsertData(VmPurchase purchase);
        Task<bool> ManagePurchaseDue(vmPurchasePayment vmPurchase);
        Task<bool> InsertDebitNote(vmDebitNote vmDebitNote);
    }

    public class PurchaseOrderService : ServiceBase<Purchase>, IPurchaseOrderService
    {
        public IPurchaseOrderRepository _repository { get; }

        public PurchaseOrderService(IPurchaseOrderRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<bool> InsertData(VmPurchase purchase)
        {
            return await _repository.InsertData(purchase);
        }
        public async Task<bool> InsertDebitNote(vmDebitNote vmDebitNote)
        {
            return await _repository.InsertDebitNote(vmDebitNote);
        }

        public async Task<bool> ManagePurchaseDue(vmPurchasePayment vmPurchase)
        {
            return await _repository.ManagePurchaseDue(vmPurchase);
        }
    }
}