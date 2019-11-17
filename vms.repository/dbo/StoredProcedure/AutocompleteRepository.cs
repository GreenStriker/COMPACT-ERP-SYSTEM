using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using vms.entity.StoredProcedureModel;

namespace vms.repository.dbo.StoredProcedure
{
    public interface IAutocompleteRepository
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

    public class AutocompleteRepository : IAutocompleteRepository
    {
        private readonly DbContext _context;

        public AutocompleteRepository(DbContext context)
        {
            _context = context;
        }
        public async Task<List<SpGetProductAutocompleteForBom>> ProductionReceiveAutoCompleteBOM(int organizationId, string searchTerm)
        {
            try
            {
                return await _context.Set<SpGetProductAutocompleteForBom>().FromSql("SpGetProductAutocompleteForBom @OrganizationId={0}, @ProductSearchTerm={1}", organizationId, searchTerm).ToListAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public async Task<List<SpGetProductAutocompleteForPurchase>> GetProductAutocompleteForPurchases(int organizationId, string searchTerm)
        {
            return await _context.Set<SpGetProductAutocompleteForPurchase>().FromSql("SpGetProductAutocompleteForPurchase @OrganizationId={0}, @ProductSearchTerm={1}", organizationId, searchTerm).ToListAsync();
        }
        public async Task<List<SpGetProductAutocompleteForProductionReceive>> ProductionReceiveAutoComplete(int organizationId, string searchTerm)
        {
            return await _context.Set<SpGetProductAutocompleteForProductionReceive>().FromSql("SpGetProductAutocompleteForProductionReceive @OrganizationId={0}, @ProductSearchTerm={1}", organizationId, searchTerm).ToListAsync();
        }

        public async Task<List<SpGetProductAutocompleteForSale>> GetProductAutocompleteForSales(int organizationId, string searchTerm)
        {
            return await _context.Set<SpGetProductAutocompleteForSale>().FromSql("SpGetProductAutocompleteForSale @OrganizationId={0}, @ProductSearchTerm={1}", organizationId, searchTerm).ToListAsync();
        }
    }
}