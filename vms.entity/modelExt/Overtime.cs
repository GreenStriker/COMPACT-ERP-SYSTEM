﻿using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.viewModels;

namespace vms.entity.models
{
    public partial class Overtime : URF.Core.EF.Trackable.Entity
    {
        public IEnumerable<SelectListItems> Employes;

        private bool Active { get; set; }
    }
}
