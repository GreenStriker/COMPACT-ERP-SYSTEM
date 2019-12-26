using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;

namespace vms.repository.dbo.StoredProcedure
{
    public interface IStoreProcedureRepository 
    {
        Task<bool> InsertCredit(vmCreditNote vm);
    }
    public class StoreProcedureRepository : IStoreProcedureRepository
    {
        private readonly DbContext _context;

        public StoreProcedureRepository(DbContext context)
        {
            _context = context;
        }
        public async Task<bool> InsertCredit(vmCreditNote vm)
        {
            var creditNoteDetails = Newtonsoft.Json.JsonConvert.SerializeObject(vm.CreditNoteDetails);
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpCreditNote]  " +
                    $"@SalesId," +
                    $"@VoucherNo," +
                    $"@ReasonOfReturn," +
                    $"@ReturnDate," +
                    $"@CreatedBy," +
                    $"@CreatedTime," +
                    $"@CreditNoteDetails"
                    , new SqlParameter("@SalesId", (object)vm.SalesId ?? DBNull.Value)
                    , new SqlParameter("@VoucherNo", (object)vm.VoucherNo ?? DBNull.Value)
                    , new SqlParameter("@ReasonOfReturn", (object)vm.ReasonOfReturn ?? DBNull.Value)
                    , new SqlParameter("@ReturnDate", (object)vm.ReturnDate ?? DBNull.Value)
                    , new SqlParameter("@CreatedBy", (object)vm.CreatedBy ?? DBNull.Value)
                    , new SqlParameter("@CreatedTime", (object)vm.CreatedTime ?? DBNull.Value)
                    , new SqlParameter("@CreditNoteDetails", (object)creditNoteDetails ?? DBNull.Value)
                );

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(true);
        }
    }
}
