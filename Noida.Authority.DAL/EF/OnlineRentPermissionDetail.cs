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
    
    public partial class OnlineRentPermissionDetail
    {
        public int RentingSid { get; set; }
        public Nullable<int> RequestNo { get; set; }
        public Nullable<int> Rid { get; set; }
        public Nullable<bool> Permission { get; set; }
        public string TenantName { get; set; }
        public string TenantProject { get; set; }
        public Nullable<int> RentDurationYears { get; set; }
        public Nullable<decimal> RentingCharge { get; set; }
        public Nullable<System.DateTime> RentingDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> Approver { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Modifiedby { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.DateTime> RentingEndDate { get; set; }
        public string RComment { get; set; }
        public Nullable<System.DateTime> RCommentDate { get; set; }
    
        public virtual StatusMaster StatusMaster { get; set; }
        public virtual Customer_ServiceRequest Customer_ServiceRequest { get; set; }
    }
}
