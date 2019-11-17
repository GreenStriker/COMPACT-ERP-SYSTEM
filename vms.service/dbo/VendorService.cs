using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IVendorService : IServiceBase<Vendor>
    {
    }

    public class VendorService : ServiceBase<Vendor>, IVendorService
    {
        public IVendorRepository _repository { get; }
        public VendorService(IVendorRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
