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
    
    public partial class Sp_GetListValueByTotalCount_Result
    {
        public int Id { get; set; }
        public Nullable<int> RegistrationId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string departmentName { get; set; }
        public Nullable<int> PropertyId { get; set; }
        public string ApplicantName { get; set; }
        public string PropertyNo { get; set; }
        public Nullable<System.DateTime> LeaseDeedDate { get; set; }
        public Nullable<System.DateTime> TransferLeaseDate { get; set; }
        public Nullable<decimal> LeaseRentPremium { get; set; }
        public Nullable<decimal> RevisedPremium { get; set; }
        public Nullable<System.DateTime> RevisedPremiumDate { get; set; }
        public Nullable<decimal> PanelInterest { get; set; }
        public Nullable<decimal> Column1 { get; set; }
        public Nullable<int> ReviseRateAfterYear { get; set; }
        public Nullable<decimal> GST { get; set; }
        public Nullable<decimal> TotalPremium { get; set; }
        public Nullable<System.DateTime> ChallanDate { get; set; }
        public Nullable<System.DateTime> NDCDate { get; set; }
        public string NDCStatus { get; set; }
        public Nullable<System.DateTime> DepositDate { get; set; }
        public Nullable<bool> IsOneTimeLeasePaid { get; set; }
        public Nullable<bool> IsTotalPremiumPaid { get; set; }
        public string PremiumPaidDuration { get; set; }
        public Nullable<System.DateTime> PaidUptoDate { get; set; }
        public Nullable<bool> IsOneTimeInstallmentPaid { get; set; }
        public Nullable<bool> IsTotalInstallmentPaid { get; set; }
        public string PaymentMode { get; set; }
        public string TransactionId { get; set; }
        public Nullable<decimal> BalanceAmount { get; set; }
        public Nullable<decimal> BalanceInterest { get; set; }
        public Nullable<System.DateTime> BalanceUptoDate { get; set; }
        public Nullable<decimal> PreviousDues { get; set; }
        public Nullable<decimal> CurrentDues { get; set; }
        public Nullable<System.DateTime> PreviousDuesDate { get; set; }
        public Nullable<System.DateTime> CurrentDuesDate { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> Approver { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string RComment { get; set; }
        public Nullable<System.DateTime> RCommentDate { get; set; }
        public Nullable<decimal> LeaseRentDues { get; set; }
        public Nullable<System.DateTime> DuesUptoDate { get; set; }
        public string HtmlDuesTemplate { get; set; }
        public string SchemeName { get; set; }
        public string Sector { get; set; }
        public string Block { get; set; }
        public string PlotNo { get; set; }
        public int OldRId { get; set; }
    }
}
