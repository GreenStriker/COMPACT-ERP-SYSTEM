using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.repository.dbo
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
    }
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        private readonly DbContext _context;

        public CustomerRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

    }
}
