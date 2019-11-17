using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;
using vms.entity.viewModels.ReportsViewModel;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface ISaleService : IServiceBase<Sale>
    {
        Task<bool> InsertData(vmSaleOrder saleOrder); 
        Task<bool> InsertCreditNote(vmCreditNote vmCreditNote);
        Task<IList<Sale>> GetSalesDetailsAsync(vmSalesDetails salesDetails);
    }

    public class SaleService : ServiceBase<Sale>, ISaleService
    {
        public ISaleRepository _repository { get; }
        private readonly DbContext _context;

        public SaleService(ISaleRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public async Task<bool> InsertCreditNote(vmCreditNote vmCreditNote)
        {
            return await _repository.InsertCreditNote(vmCreditNote);
        }
        public async Task<bool> InsertData(vmSaleOrder saleOrder)
        {
            return await _repository.InsertData(saleOrder);
        }

        public async Task<IList<Sale>> GetSalesDetailsAsync(vmSalesDetails salesDetails)
        {
            return await _repository.Queryable().Where(s =>
                (string.IsNullOrEmpty(salesDetails.InvoiceNo) || s.InvoiceNo.Contains(salesDetails.InvoiceNo)) &&
                (string.IsNullOrEmpty(salesDetails.CustomerName) || s.Customer.Name.Contains(salesDetails.CustomerName)) &&
                (salesDetails.FromDate == null || s.SalesDate >= salesDetails.FromDate) &&
                (salesDetails.ToDate == null || s.SalesDate <= salesDetails.ToDate))
            .Include(s => s.Customer)
            .ToListAsync(CancellationToken.None);
        }
    }
}