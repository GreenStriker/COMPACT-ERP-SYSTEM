using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class BankBranch
    {
        public BankBranch()
        {
            MushakGenerationDevelopmentSurchargeBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationEnvironmentProtectSurchargeBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationExciseDutyBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationFinancialPenaltyBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationHealthDevelopmentSurchargeBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationInterestForDueSuppDutyBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationInterestForDueVatBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationItDevelopmentSurchargeBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationSuppDutyBankBranches = new HashSet<MushakGeneration>();
            MushakGenerationVatPaymentBankBranches = new HashSet<MushakGeneration>();
        }

        public int BankBranchId { get; set; }
        public int BankId { get; set; }
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public string NameInBangla { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual District District { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationDevelopmentSurchargeBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationEnvironmentProtectSurchargeBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationExciseDutyBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationFinancialPenaltyBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationHealthDevelopmentSurchargeBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationInterestForDueSuppDutyBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationInterestForDueVatBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationItDevelopmentSurchargeBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationSuppDutyBankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationVatPaymentBankBranches { get; set; }
    }
}