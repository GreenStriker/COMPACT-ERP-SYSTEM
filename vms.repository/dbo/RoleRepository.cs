using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;

namespace vms.repository.dbo
{
    
    public interface IRoleRepository : IRepositoryBase<Role>
    {
        Task<IEnumerable<Role>> GetRoles(int p_orgId);
        Task<Role> GetRole(string p_encryptedId);
    }
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        private readonly DbContext _context;
        private readonly IDataProtectionProvider _protectionProvider;
        private readonly PurposeStringConstants _purposeStringConstants;
        private IDataProtector _dataProtector;

        public RoleRepository(DbContext context, IDataProtectionProvider p_protectionProvider, PurposeStringConstants p_purposeStringConstants) : base(context)
        {
            this._context = context;
            _protectionProvider = p_protectionProvider;
            _purposeStringConstants = p_purposeStringConstants;
            _dataProtector = _protectionProvider.CreateProtector(_purposeStringConstants.UserIdQueryString);
        }

        public async Task<IEnumerable<Role>> GetRoles(int p_orgId)
        {
            var roles = await this.Query().Where(w => w.OrganizationId == p_orgId).SelectAsync();
            
            roles.ToList().ForEach(delegate (Role role)
            {
                role.EncryptedId = _dataProtector.Protect(role.RoleId.ToString());
            });
            return roles;
        }
        public async Task<Role> GetRole(string p_encryptedId)
        {
            int id = int.Parse(_dataProtector.Unprotect(p_encryptedId));
            var role = await this.Query()               
                .SingleOrDefaultAsync(x => x.RoleId == id, System.Threading.CancellationToken.None);
            role.EncryptedId = _dataProtector.Protect(role.RoleId.ToString());

            return role;
        }

    }
}
