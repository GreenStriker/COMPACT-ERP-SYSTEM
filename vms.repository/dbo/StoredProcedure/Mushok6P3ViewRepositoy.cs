using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.StoredProcedureModel;
using vms.entity.viewModels.ReportsViewModel;

namespace vms.repository.dbo.StoredProcedure
{
    public interface IMushok6P3ViewRepositoy
    {
        Task<List<spGet6P3View>> GetMushok6p3(vmSalesDetails vm);

    }

    public class Mushok6P3ViewRepositoy : IMushok6P3ViewRepositoy
    {
        private readonly DbContext _context;
        public Mushok6P3ViewRepositoy(DbContext context)
        {
            _context = context;
        }
        public async Task<List<spGet6P3View>> GetMushok6p3(vmSalesDetails vm)
        {

            try
            {
                var item= await _context.Set<spGet6P3View>().FromSql("spGet6P3View @InvoiceNo={0},@CustomerName={1},@FromDate={2},@ToDate={3}", vm.InvoiceNo,vm.CustomerName,vm.FromDate,vm.ToDate ).ToListAsync();

                return item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
