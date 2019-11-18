using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Contenttype
    {
        public Contenttype()
        {
            Contents = new HashSet<Content>();
        }

        public int ContentTypeId { get; set; }
        public string Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual ICollection<Content> Contents { get; set; }
    }
}