﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class RoleRight
    {
        public int RoleRightId { get; set; }
        public int RoleId { get; set; }
        public int RightId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Right Right { get; set; }
    }
}