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
    
    public partial class Sp_GetServiceDetailsByServiceId_Result
    {
        public int RequestId { get; set; }
        public string RegistrationNo { get; set; }
        public string PropertyNo { get; set; }
        public string ServiceName { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string Status { get; set; }
        public string Approver { get; set; }
        public string Applicant { get; set; }
        public Nullable<System.DateTime> ValidationDate { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public string Comment { get; set; }
    }
}
