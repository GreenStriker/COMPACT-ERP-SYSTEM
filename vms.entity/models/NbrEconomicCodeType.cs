using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class NbrEconomicCodeType
    {
        public NbrEconomicCodeType()
        {
            NbrEconomicCodes = new HashSet<NbrEconomicCode>();
        }

        public int NbrEconomicCodeTypeId { get; set; }
        public string CodeTypeName { get; set; }

        public virtual ICollection<NbrEconomicCode> NbrEconomicCodes { get; set; }
    }
}