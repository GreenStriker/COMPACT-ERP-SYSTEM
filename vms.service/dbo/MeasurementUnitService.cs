using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
  
    public interface IMeasurementUnitService : IServiceBase<MeasurementUnit>
    {
    }

    public class MeasurementUnitService : ServiceBase<MeasurementUnit>, IMeasurementUnitService
    {
        public IMeasurementUnitRepository _repository { get; }
        public MeasurementUnitService(IMeasurementUnitRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
