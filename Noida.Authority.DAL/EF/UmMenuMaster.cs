//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Noida.Authority.DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class UmMenuMaster
    {
        public int MenuId { get; set; }
        public Nullable<int> MenuPathId { get; set; }
        public string MenuName { get; set; }
        public Nullable<int> MenuParentId { get; set; }
        public Nullable<int> ApplicationId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual UmApplicationMaster UmApplicationMaster { get; set; }
    }
}
