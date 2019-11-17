using System;
using System.Collections.Generic;
using vms.entity.models;

namespace vms.entity.viewModels
{
    public class VmDamage : DamageType
    {
        public int DamageId { get; set; }
      
        public int ProductId { get; set; }
        public long StockInId { get; set; }
        public decimal DamageQty { get; set; }
      
        public string Description { get; set; }
      
        public string purchageInvoice { get; set; }
        public string BachNo { get; set; }
        public List<vmDamageType> vMDamageType { get; set; }
    }

    public class vmDamageType
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
    }

}