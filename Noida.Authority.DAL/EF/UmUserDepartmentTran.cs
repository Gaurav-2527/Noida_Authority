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
    
    public partial class UmUserDepartmentTran
    {
        public int Id { get; set; }
        public Nullable<int> UserRefId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<bool> Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual UmDepartmentMaster UmDepartmentMaster { get; set; }
        public virtual UmUserMaster UmUserMaster { get; set; }
    }
}
