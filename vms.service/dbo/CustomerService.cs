using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface ICustomerService : IServiceBase<Customer>
    {
    }

    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        public ICustomerRepository _repository { get; }
        public CustomerService(ICustomerRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
