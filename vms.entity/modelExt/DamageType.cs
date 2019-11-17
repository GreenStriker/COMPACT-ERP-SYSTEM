﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using vms.entity.viewModels;
namespace vms.entity.models

{
    [ModelMetadataType(typeof(DamageTypeMetadata))]
    public partial class DamageType : URF.Core.EF.Trackable.Entity
    {

        public IEnumerable<SelectListItems> DamageTypes { get; set; }
    }
    public class DamageTypeMetadata
    {

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required]
        
        public string Name { get; set; }
    }
  
}
