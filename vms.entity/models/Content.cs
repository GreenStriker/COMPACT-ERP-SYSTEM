using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class Content
    {
        public int ContentId { get; set; }
        public string Name { get; set; }
        public int? ContentTypeId { get; set; }
        public int? TransId { get; set; }
        public string Url { get; set; }
        public string Remark { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Contenttype ContentType { get; set; }
    }
}