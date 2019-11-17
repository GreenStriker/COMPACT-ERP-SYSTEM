using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IRoleService : IServiceBase<Role>
    {
        Task<IEnumerable<Role>> GetRoles(int p_orgId);
        Task<Role> GetRole(string p_encryptedId);
    }

    public class RoleService : ServiceBase<Role>, IRoleService
    {
        public IRoleRepository _repository { get; }
        public RoleService(IRoleRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Role>> GetRoles(int p_orgId)
        {
            return await _repository.GetRoles(p_orgId);
        }
        public async Task<Role> GetRole(string p_encryptedId)
        {
            return await _repository.GetRole(p_encryptedId);
        }
    }
}
