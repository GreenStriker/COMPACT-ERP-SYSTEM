﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace vms.entity.models
{
    public partial class User
    {
        public int Uid { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? BrachId { get; set; }
        public string Designation { get; set; }
        public string Moble { get; set; }
        public int? RoleId { get; set; }
        public int? UserTypeId { get; set; }
        public string Address { get; set; }
        public DateTime? JoingDate { get; set; }
        public DateTime? DeactiveDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual Branch Brach { get; set; }
        public virtual Role Role { get; set; }
        public virtual UserType UserType { get; set; }
    }
}