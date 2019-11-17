using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using vms.entity.StoredProcedureModel;
using vms.entity.viewModels;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer.Metadata.Conventions.Internal;
using vms.entity.models;

namespace vms.repository.dbo.StoredProcedure
{
    public interface IDamageInvoiceListRepository
    {
        Task<List<SpDamageInvoiceList>> GetDamageInvoiceList(int organizationId,int productId);
        Task<bool> InsertDamage(SpDamageInsert Damage);
        Task<List<SpDamage>> GetDamageList(int organizationId);
    }

    public class DamageInvoiceListRepository : IDamageInvoiceListRepository
    {
        private readonly DbContext _context;

        public DamageInvoiceListRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<SpDamageInvoiceList>> GetDamageInvoiceList(int organizationId, int productId)
        {
            return await _context.Set<SpDamageInvoiceList>().FromSql("SpDamageInfo @OrganizationId={0},@ProductId={1}", organizationId,productId).ToListAsync();
        }
        public async Task<List<SpDamage>> GetDamageList(int organizationId)
        {

            var item= await _context.Set<SpDamage>().FromSql("SpDamageList @OrganizationId={0}", organizationId).ToListAsync();
            return item;
        }

        public async Task<bool> InsertDamage(SpDamageInsert Damage)
        {




            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpDamageInsert]" +
                    $"@OrganizationId " +
                    $",@ProductId" +
                    $",@StockInId" +
                    $",@DamageQty" +
                    $",@DamageTypeId" +
                    $",@Description" +
                    $",@CreatedBy "

                    , new SqlParameter("@OrganizationId", Damage.OrganizationId)
                    , new SqlParameter("@ProductId", Damage.ProductId)
                    , new SqlParameter("@StockInId", Damage.StockInId)
                    , new SqlParameter("@DamageQty", Damage.DamageQty)
                    , new SqlParameter("@DamageTypeId", Damage.DamageTypeId)
                    , new SqlParameter("@Description", Damage.Description)
                    , new SqlParameter("@CreatedBy", Damage.CreatedBy)
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