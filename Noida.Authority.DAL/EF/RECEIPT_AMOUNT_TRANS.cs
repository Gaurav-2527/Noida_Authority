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
    
    public partial class RECEIPT_AMOUNT_TRANS
    {
        public int id { get; set; }
        public Nullable<long> RECEIPT_ID { get; set; }
        public Nullable<int> DEPT_CODE { get; set; }
        public Nullable<int> RECEIPT_HEAD_ID { get; set; }
        public Nullable<int> RECEIPT_SUBHEAD_ID { get; set; }
        public string CHALLAN_ID { get; set; }
        public System.DateTime DEPOSIT_DATE { get; set; }
        public decimal AMOUNT_PAID { get; set; }
        public Nullable<int> STATUS { get; set; }
        public string USERID { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
    
        public virtual RECEIPT_DETAIL_MASTER RECEIPT_DETAIL_MASTER { get; set; }
        public virtual RECIEPT_HEAD RECIEPT_HEAD { get; set; }
        public virtual RECEIPT_SUB_HEAD RECEIPT_SUB_HEAD { get; set; }
    }
}
