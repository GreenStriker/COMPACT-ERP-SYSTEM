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
   
    public interface IAuditLogRepository : IRepositoryBase<AuditLog>
    {
        Task<bool> RestoreAuditAsync(vmRestore vmRestore);
    }
    public class AuditLogRepository : RepositoryBase<AuditLog>, IAuditLogRepository
    {
        private readonly DbContext _context;

        public AuditLogRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<bool> RestoreAuditAsync(vmRestore vmRestore)
        {
            try
            {
                this._context.Database.ExecuteSqlCommand(
                    $"EXEC [dbo].[USP_AuditRestore]" +
                    $"@TableName " +
                    $",@PrimaryKeyName" +
                    $",@PrimaryKey " +
                    $",@AuditLogId "

                    , new SqlParameter("@TableName", vmRestore.TableName)
                    , new SqlParameter("@PrimaryKeyName", vmRestore.PrimaryKeyName)
                    , new SqlParameter("@PrimaryKey", vmRestore.PrimaryKey)
                     , new SqlParameter("@AuditLogId", vmRestore.AuditLogId)

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
