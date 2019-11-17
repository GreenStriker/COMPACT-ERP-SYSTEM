using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
    public interface INbrEconomicCodeService : IServiceBase<NbrEconomicCode>
    {
    }
    public class NbrEconomicCodeService : ServiceBase<NbrEconomicCode>, INbrEconomicCodeService
    {
        public INbrEconomicCodeRepository _repository { get; }
        public NbrEconomicCodeService(INbrEconomicCodeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
