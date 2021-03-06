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
    
    public partial class MortgageDetail
    {
        public int RequestNo { get; set; }
        public Nullable<int> RID { get; set; }
        public Nullable<bool> Mortgage { get; set; }
        public Nullable<System.DateTime> MortgageDate { get; set; }
        public string BankName { get; set; }
        public string BranchAddress { get; set; }
        public Nullable<decimal> ProcessingFee { get; set; }
        public Nullable<decimal> SanctionedAmount { get; set; }
        public string MortgageType { get; set; }
        public Nullable<System.DateTime> ValidUpto { get; set; }
        public Nullable<short> PreviousLoanNoc { get; set; }
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
        public string RComment { get; set; }
        public Nullable<System.DateTime> RCommentDate { get; set; }
        public Nullable<int> OnlineRequestNo { get; set; }
    
        public virtual StatusMaster StatusMaster { get; set; }
    }
}
