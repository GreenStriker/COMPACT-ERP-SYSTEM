using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class NbrEconomicCode
    {
        public NbrEconomicCode()
        {
            MushakGenerationDevelopmentSurchargeEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationEnvironmentProtectSurchargeEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationExciseDutyEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationFinancialPenaltyEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationHealthDevelopmentSurchargeEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationInterestForDueSuppDutyEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationInterestForDueVatEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationItDevelopmentSurchargeEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationSuppDutyEconomicCodes = new HashSet<MushakGeneration>();
            MushakGenerationVatEconomicCodes = new HashSet<MushakGeneration>();
        }

        public int NbrEconomicCodeId { get; set; }
        public int NbrEconomicCodeTypeId { get; set; }
        public string EconomicTitle { get; set; }
        public string EconomicCode { get; set; }
        public string Code1stDisit { get; set; }
        public string Code2ndDisit { get; set; }
        public string Code3rdDisit { get; set; }
        public string Code4thDisit { get; set; }
        public string Code5thDisit { get; set; }
        public string Code6thDisit { get; set; }
        public string Code7thDisit { get; set; }
        public string Code8thDisit { get; set; }
        public string Code9thDisit { get; set; }
        public string Code10thDisit { get; set; }
        public string Code11thDisit { get; set; }
        public string Code12thDisit { get; set; }
        public string Code13thDisit { get; set; }
        public bool? IsActive { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }

        public virtual NbrEconomicCodeType NbrEconomicCodeType { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationDevelopmentSurchargeEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationEnvironmentProtectSurchargeEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationExciseDutyEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationFinancialPenaltyEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationHealthDevelopmentSurchargeEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationInterestForDueSuppDutyEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationInterestForDueVatEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationItDevelopmentSurchargeEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationSuppDutyEconomicCodes { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationVatEconomicCodes { get; set; }
    }
}