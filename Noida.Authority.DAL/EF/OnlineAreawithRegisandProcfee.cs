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
    
    public partial class OnlineAreawithRegisandProcfee
    {
        public int ID { get; set; }
        public Nullable<int> schemeId { get; set; }
        public Nullable<decimal> ProcessingCharge { get; set; }
        public Nullable<decimal> ApplicationFee { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
    }
}
