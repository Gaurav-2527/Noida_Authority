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
    
    public partial class StampDutyMaster
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> StampDutyPercent { get; set; }
        public Nullable<decimal> DuplicateStampDutyValINR { get; set; }
        public Nullable<System.DateTime> EffectedFrom { get; set; }
        public Nullable<System.DateTime> EffectedTo { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Modifiedby { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
