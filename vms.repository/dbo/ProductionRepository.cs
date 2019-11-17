using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;

namespace vms.repository.dbo
{
    public interface IProductionRepository : IRepositoryBase<ProductionReceive>
    {
        Task<bool> InsertData(vmProductionReceive production);
    }
    public class ProductionRepository : RepositoryBase<ProductionReceive>, IProductionRepository
    {
        private readonly DbContext _context;

        public ProductionRepository(DbContext context) : base(context)
        {
            this._context = context;
        }
        public async Task<bool> InsertData(vmProductionReceive production)
        {
            var BomJson = Newtonsoft.Json.JsonConvert.SerializeObject(production.ProductionReceiveDetailList);
            string ContentJson = null;// Newtonsoft.Json.JsonConvert.SerializeObject(production.ContentInfoJson);
            if (production.ContentInfoJson != null)
                ContentJson = Newtonsoft.Json.JsonConvert.SerializeObject(production.ContentInfoJson);
            production.ProductionId = 0;
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[SpInsertProductionReceive]  " +
                    $"@BatchNo," +
                    $"@OrganizationId," +
                    $"@ProductionId," +
                    $"@ProductId," +
                    $"@ReceiveQuantity," +
                    $"@MeasurementUnitId," +
                    $"@ReceiveTime," +
                    $"@CreatedBy," +
                    $"@CreatedTime," +
                    $"@BomJson," +
                    $"@ContentJson"
                    , new SqlParameter("@BatchNo", (object)production.BatchNo ?? DBNull.Value)
                    , new SqlParameter("@OrganizationId", (object)production.OrganizationId ?? DBNull.Value)
                    , new SqlParameter("@ProductionId", production.ProductionId)
                    , new SqlParameter("@ProductId", (object)production.ProductId ?? DBNull.Value)
                    , new SqlParameter("@ReceiveQuantity", (object)production.ReceiveQuantity ?? DBNull.Value)
                    , new SqlParameter("@MeasurementUnitId", (object)production.MeasurementUnitId ?? DBNull.Value)
                    , new SqlParameter("@ReceiveTime", (object)production.ReceiveTime ?? DBNull.Value)
                    , new SqlParameter("@CreatedBy", (object)production.CreatedBy ?? DBNull.Value)
                    , new SqlParameter("@CreatedTime", (object)production.CreatedTime ?? DBNull.Value)
                    , new SqlParameter("@BomJson", (object)BomJson ?? DBNull.Value)
                    , new SqlParameter("@ContentJson", (object)ContentJson ?? DBNull.Value)   
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
