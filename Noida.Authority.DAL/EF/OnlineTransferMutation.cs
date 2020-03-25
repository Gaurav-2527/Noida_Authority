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
    
    public partial class OnlineTransferMutation
    {
        public int TMSid { get; set; }
        public Nullable<int> RequestNo { get; set; }
        public Nullable<int> Rid { get; set; }
        public Nullable<int> Property_Id { get; set; }
        public string Applicant_Name { get; set; }
        public string ApplicantFather_Name { get; set; }
        public string Applicant_Signing_Authority { get; set; }
        public string Applicant_Registered_Office { get; set; }
        public string Applicant_Gender { get; set; }
        public Nullable<int> Applicant_Age { get; set; }
        public string Applicant_Occupation { get; set; }
        public string Correspondance_Add { get; set; }
        public string Permanent_Add { get; set; }
        public Nullable<decimal> Selling_Cost { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> Transfer_Date { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Requested_By { get; set; }
        public Nullable<System.DateTime> Requested_Date { get; set; }
        public Nullable<int> Approved_By { get; set; }
        public Nullable<System.DateTime> Approved_Date { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> Mutation_Date { get; set; }
        public Nullable<int> Transfer_Sub_Type { get; set; }
        public Nullable<System.DateTime> TransferDeed_Date { get; set; }
        public string Bahi_No { get; set; }
        public string Bahi_Zild_No { get; set; }
        public string Bahi_Page_No { get; set; }
        public string Bahi_Series_No { get; set; }
        public string Book_No { get; set; }
        public string Book_Zild_No { get; set; }
        public string Book_Series_No { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public Nullable<int> Transfer_Type { get; set; }
        public Nullable<decimal> Transfer_Charge { get; set; }
        public Nullable<decimal> Total_Transfer_Charge { get; set; }
        public string GPA_Holder_Name { get; set; }
        public string GPA_Holder_Address { get; set; }
        public Nullable<System.DateTime> GPA_Effective_From { get; set; }
        public Nullable<System.DateTime> GPA_Effective_To { get; set; }
        public string T_Gender { get; set; }
        public string T_First_Name { get; set; }
        public string T_Middle_Name { get; set; }
        public string T_Last_Name { get; set; }
        public string T_Father_Husband_Name { get; set; }
        public string T_Mother_Name { get; set; }
        public string T_Company_Name { get; set; }
        public string T_Signing_Authority { get; set; }
        public string T_Email { get; set; }
        public string T_Mobile { get; set; }
        public string T_Correspondence_Add { get; set; }
        public string T_Permanent_Add { get; set; }
        public string T_Registered_Office { get; set; }
        public Nullable<int> T_Occupation_Id { get; set; }
        public string T_Pan { get; set; }
        public Nullable<decimal> T_Annual_Income { get; set; }
        public string RComment { get; set; }
        public Nullable<System.DateTime> RCommentDate { get; set; }
    
        public virtual StatusMaster StatusMaster { get; set; }
        public virtual Customer_ServiceRequest Customer_ServiceRequest { get; set; }
    }
}
