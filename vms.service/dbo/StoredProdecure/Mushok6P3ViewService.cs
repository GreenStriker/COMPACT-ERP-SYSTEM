using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.StoredProcedureModel;
using vms.entity.viewModels.ReportsViewModel;
using vms.repository.dbo.StoredProcedure;

namespace vms.service.dbo.StoredProdecure
{
    public interface IMushok6P3ViewService
    {
        Task<List<spGet6P3View>> GetMushok6p3(vmSalesDetails vm);
    }
    public class Mushok6P3ViewService : IMushok6P3ViewService
    {
        private readonly IMushok6P3ViewRepositoy _repositoy;

        public Mushok6P3ViewService(IMushok6P3ViewRepositoy repositoy)
        {
            _repositoy = repositoy;
        }
        public async Task<List<spGet6P3View>> GetMushok6p3(vmSalesDetails vm)
        {
            return await _repositoy.GetMushok6p3(vm);

        }

    }
}
