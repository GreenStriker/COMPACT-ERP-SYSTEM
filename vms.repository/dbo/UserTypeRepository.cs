using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  

    public interface IUserTypeRepository : IRepositoryBase<UserType>
    {
    }
    public class UserTypeRepository : RepositoryBase<UserType>, IUserTypeRepository
    {
        private readonly DbContext _context;

        public UserTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
