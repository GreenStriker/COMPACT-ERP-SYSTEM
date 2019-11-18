using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;

namespace vms.entity.viewModels
{
    public class vmSession
    {
        //public vmSession()
        //{
        //    Rights = new List<Right>();
        //}
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string PreviousData { get; set; }
     //   public List<Right> Rights { get; set; }
    }
    
}
