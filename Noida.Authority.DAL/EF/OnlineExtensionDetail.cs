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
    
    public partial class OnlineExtensionDetail
    {
        public int ExtensionSid { get; set; }
        public Nullable<int> RequestNo { get; set; }
        public Nullable<int> Rid { get; set; }
        public string PropertyNo { get; set; }
        public Nullable<System.DateTime> CompletionDueDate { get; set; }
        public Nullable<System.DateTime> ExtensionGivenDate { get; set; }
        public Nullable<System.DateTime> ExtensionDueDate { get; set; }
        public Nullable<decimal> ExtensionCharge { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string RComment { get; set; }
        public Nullable<System.DateTime> RCommentDate { get; set; }
    
        public virtual Customer_ServiceRequest Customer_ServiceRequest { get; set; }
        public virtual StatusMaster StatusMaster { get; set; }
    }
}
