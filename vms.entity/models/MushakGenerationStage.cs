using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class MushakGenerationStage
    {
        public MushakGenerationStage()
        {
            MushakGenerations = new HashSet<MushakGeneration>();
        }

        public byte MushakGenerationStageId { get; set; }
        public string Name { get; set; }
        public string NameInBangla { get; set; }

        public virtual ICollection<MushakGeneration> MushakGenerations { get; set; }
    }
}