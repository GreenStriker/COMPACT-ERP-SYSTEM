
using Microsoft.EntityFrameworkCore;
using vms.entity.models;
using URF.Core.Abstractions.Trackable;


namespace vms.repository.dbo
{

    public interface IOrganizationRepository : IRepositoryBase<Organization>
    {
    }
    public class OrganizationRepository : RepositoryBase<Organization>, IOrganizationRepository
    {
        private readonly DbContext _context;

        public OrganizationRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}




