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
    
    public partial class SigningOfficerMaster
    {
        public int id { get; set; }
        public Nullable<int> departmentId { get; set; }
        public string officerDetails { get; set; }
        public Nullable<System.DateTime> efficatTo { get; set; }
        public Nullable<System.DateTime> efficatFrom { get; set; }
        public Nullable<int> status { get; set; }
    }
}
