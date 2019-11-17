using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.StoredProcedureModel;

namespace vms.repository.dbo.StoredProcedure
{
    public interface ISpGetSalePagedRepository
    {
        Task<List<spGetSalePaged>> GetSalePaged(int PageSize,int PageNumber,int OrganizationId);

    }

    public class SpGetSalePagedRepository: ISpGetSalePagedRepository
    {
        private readonly DbContext _context;
        public SpGetSalePagedRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<spGetSalePaged>> GetSalePaged(int PageSize, int PageNumber, int OrganizationId)
        {
            try
            {
                return await _context.Set<spGetSalePaged>().FromSql("spGetSalePaged @PageSize={0}, @PageNumber={1},@OrganizationId={2}", PageSize, PageNumber,OrganizationId).ToListAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
