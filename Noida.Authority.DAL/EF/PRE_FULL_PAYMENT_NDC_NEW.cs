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
    
    public partial class PRE_FULL_PAYMENT_NDC_NEW
    {
        public int Id { get; set; }
        public Nullable<int> RegistrationId { get; set; }
        public string Applicant { get; set; }
        public string isSector { get; set; }
        public string isBlock { get; set; }
        public string isPlotNo { get; set; }
        public string isTotalPaidPream { get; set; }
        public string isOneTimeLeasePaid { get; set; }
        public Nullable<System.DateTime> isLastNDCDate { get; set; }
        public Nullable<System.DateTime> isOTRChallanDate { get; set; }
        public Nullable<System.DateTime> isLeasedeeddate { get; set; }
        public Nullable<System.DateTime> isLeaseTransferdate { get; set; }
        public Nullable<double> isLeaseRentAmountPerYear { get; set; }
        public Nullable<double> isLeasePanelInterest { get; set; }
        public Nullable<System.DateTime> isLeaseRentPaidUptodate { get; set; }
        public string isLeaseRentPaidUpto { get; set; }
        public Nullable<System.DateTime> isLeaseRentReviseddate { get; set; }
        public Nullable<double> isLeaseRentBlanceAmount { get; set; }
        public Nullable<double> isLeaseRentBlanceIntAmount { get; set; }
        public Nullable<double> isLeaseRentGStIntAmount { get; set; }
        public Nullable<System.DateTime> isLeaseRentBalanceUptodate { get; set; }
        public Nullable<double> isrevicedrateper { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> Approver { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string RComment { get; set; }
        public Nullable<System.DateTime> RCommentDate { get; set; }
    }
}
