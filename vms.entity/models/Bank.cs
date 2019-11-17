using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Bank
    {
        public Bank()
        {
            BankBranches = new HashSet<BankBranch>();
            MushakGenerationReturnFromClosingSdChequeBanks = new HashSet<MushakGeneration>();
            MushakGenerationReturnFromClosingVatChequeBanks = new HashSet<MushakGeneration>();
        }

        public int BankId { get; set; }
        public string Name { get; set; }
        public string NameInBangla { get; set; }

        public virtual ICollection<BankBranch> BankBranches { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationReturnFromClosingSdChequeBanks { get; set; }
        public virtual ICollection<MushakGeneration> MushakGenerationReturnFromClosingVatChequeBanks { get; set; }
    }
}