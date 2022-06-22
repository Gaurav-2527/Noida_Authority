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
    
    public partial class Building_Plan_Trans
    {
        public int id { get; set; }
        public Nullable<int> BPid { get; set; }
        public Nullable<int> Rid { get; set; }
        public string Tower_Name { get; set; }
        public Nullable<decimal> All_Covered_Area { get; set; }
        public Nullable<decimal> GF_Covered_Area { get; set; }
        public Nullable<decimal> Building_Height { get; set; }
        public Nullable<int> No_Of_stories { get; set; }
        public Nullable<int> Receipt_Head { get; set; }
        public Nullable<int> Receipt_Sub_Head { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Noc_Type { get; set; }
        public string Is_Submit { get; set; }
        public Nullable<int> Record_Type { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
    
        public virtual Building_Plan_Master Building_Plan_Master { get; set; }
        public virtual NOC_MASTER NOC_MASTER { get; set; }
        public virtual RECEIPT_SUB_HEAD RECEIPT_SUB_HEAD1 { get; set; }
    }
}