using System.Collections.Generic;
using System.Threading.Tasks;
using vms.entity.StoredProcedureModel;
using vms.repository.dbo.StoredProcedure;

namespace vms.service.dbo.StoredProdecure
{
    public interface IAutocompleteService
    {
        Task<List<SpGetProductAutocompleteForPurchase>> GetProductAutocompleteForPurchases(int organizationId,
            string searchTerm);

        Task<List<SpGetProductAutocompleteForSale>> GetProductAutocompleteForSales(int organizationId,
            string searchTerm); 
         Task<List<SpGetProductAutocompleteForProductionReceive>> ProductionReceiveAutoComplete(int organizationId,
            string searchTerm);
        Task<List<SpGetProductAutocompleteForBom>> ProductionReceiveAutoCompleteBOM(int organizationId,
            string searchTerm);
    }

    public class AutocompleteService : IAutocompleteService
    {
        private readonly IAutocompleteRepository _autocompleteRepository;

        public AutocompleteService(IAutocompleteRepository autocompleteRepository)
        {
            _autocompleteRepository = autocompleteRepository;
        }

        public async Task<List<SpGetProductAutocompleteForPurchase>> GetProductAutocompleteForPurchases(int organizationId, string searchTerm)
        {
            return await _autocompleteRepository.GetProductAutocompleteForPurchases(organizationId, searchTerm);
        }
        public async Task<List<SpGetProductAutocompleteForProductionReceive>> ProductionReceiveAutoComplete(int organizationId, string searchTerm)
        {
            return await _autocompleteRepository.ProductionReceiveAutoComplete(organizationId, searchTerm);
        }

        public async Task<List<SpGetProductAutocompleteForSale>> GetProductAutocompleteForSales(int organizationId, string searchTerm)
        {
            return await _autocompleteRepository.GetProductAutocompleteForSales(organizationId, searchTerm);
        }
        public async Task<List<SpGetProductAutocompleteForBom>> ProductionReceiveAutoCompleteBOM(int organizationId, string searchTerm)
        {
            return await _autocompleteRepository.ProductionReceiveAutoCompleteBOM(organizationId, searchTerm);
        }
    }
}