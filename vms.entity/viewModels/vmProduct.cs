using System;
using System.Collections.Generic;
using vms.entity.models;

namespace vms.entity.viewModels
{
    public class vmProduct : Product
    {
        public int ProductVattypeId { get; set; }
        public IEnumerable<SelectListItems> ProductVattype;
       
        //public virtual ProductVattype ProductVattype { get; set; }
        //public int ProductTypeId { get; set; }
        //public List<vmProductType> vmProductType { get; set; }
    }
   
    public class vmProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAssigned { get; set; }
    }

}