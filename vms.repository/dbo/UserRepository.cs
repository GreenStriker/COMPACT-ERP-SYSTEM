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

    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> GetUsers(int p_orgId);
        Task<User> GetUser(string p_encryptedId);
    }
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly DbContext _context;
        private readonly IDataProtectionProvider _protectionProvider;
        private readonly PurposeStringConstants _purposeStringConstants;
        private IDataProtector _dataProtector;
        public UserRepository(DbContext context, IDataProtectionProvider p_protectionProvider, PurposeStringConstants p_purposeStringConstants) : base(context)
        {
            this._context = context;
            _protectionProvider = p_protectionProvider;
            _purposeStringConstants = p_purposeStringConstants;
            _dataProtector = _protectionProvider.CreateProtector(_purposeStringConstants.UserIdQueryString);
        }
        public async Task<IEnumerable<User>> GetUsers(int p_orgId)
        {
            var users = await this.Query().Where(w => w.OrganizationId == p_orgId).Include(p => p.Role)
                .Include(p => p.UserType)
                .SelectAsync();
            users.ToList().ForEach(delegate (User user)
            {
                user.EncryptedId = _dataProtector.Protect(user.UserId.ToString());
            });
            return users;
        }
        public async Task<User> GetUser(string p_encryptedId)
        {
            int id = int.Parse(_dataProtector.Unprotect(p_encryptedId));
            var user = await this.Query()
                .Include(p => p.Role)
                .Include(p => p.UserType)
                .SingleOrDefaultAsync(x => x.UserId == id, System.Threading.CancellationToken.None);
            user.EncryptedId = _dataProtector.Protect(user.UserId.ToString());

            return user;
        }

    }
}
