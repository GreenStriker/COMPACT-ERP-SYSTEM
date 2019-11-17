using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
  
    public interface IObjectTypeRepository : IRepositoryBase<ObjectType>
    {
    }
    public class ObjectTypeRepository : RepositoryBase<ObjectType>, IObjectTypeRepository
    {
        private readonly DbContext _context;

        public ObjectTypeRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
