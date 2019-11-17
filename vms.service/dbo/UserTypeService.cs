using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface IUserTypeService : IServiceBase<UserType>
    {
    }

    public class UserTypeService : ServiceBase<UserType>, IUserTypeService
    {
        public IUserTypeRepository _repository { get; }
        public UserTypeService(IUserTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
