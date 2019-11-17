using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{

    public interface IOrganizationService : IServiceBase<Organization>
    {
        
    }

    public class OrganizationService : ServiceBase<Organization>, IOrganizationService
    {
        public IOrganizationRepository _repository { get; }
        public OrganizationService(IOrganizationRepository repository) : base(repository)
        {
            _repository = repository;
        }

       
    }
}




