using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.StoredProcedureModel;
using vms.repository.dbo.StoredProcedure;

namespace vms.service.dbo.StoredProdecure
{
   public interface ISpGetSalePagedService
    {
        Task<List<spGetSalePaged>> GetSalePaged(int PageSize, int PageNumber, int OrganizationId);

    }
    public class SpGetSalePagedService : ISpGetSalePagedService
    {
        private readonly ISpGetSalePagedRepository _repository;
        public SpGetSalePagedService(ISpGetSalePagedRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<spGetSalePaged>> GetSalePaged(int PageSize, int PageNumber, int OrganizationId)
        {
            return await _repository.GetSalePaged(PageSize, PageNumber, OrganizationId);
        }
    }
}
