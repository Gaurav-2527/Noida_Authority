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
    
    public partial class RePrint_Challan
    {
        public Nullable<int> ServiceRefId { get; set; }
        public string Name { get; set; }
        public Nullable<int> ServiceType { get; set; }
        public string txnid { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string udf5 { get; set; }
        public string virtualaccountno { get; set; }
        public string Control_ID { get; set; }
        public string Unit_Id { get; set; }
        public string branch { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
    }
}
