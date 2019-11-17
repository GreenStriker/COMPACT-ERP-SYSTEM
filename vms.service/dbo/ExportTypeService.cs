using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using vms.repository.dbo;

namespace vms.service.dbo
{
   
    public interface IExportTypeService : IServiceBase<ExportType>
    {
    }

    public class ExportTypeService : ServiceBase<ExportType>, IExportTypeService
    {
        public IExportTypeRepository _repository { get; }
        public ExportTypeService(IExportTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
