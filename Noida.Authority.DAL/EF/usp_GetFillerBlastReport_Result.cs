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
    
    public partial class usp_GetFillerBlastReport_Result
    {
        public int FillerBlastId { get; set; }
        public int ScheduleId { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> ConfirmCount { get; set; }
        public Nullable<int> NoResonseCount { get; set; }
        public Nullable<int> PickUpOwnDateCount { get; set; }
        public Nullable<int> EmailsSentCount { get; set; }
        public System.DateTime DateSent { get; set; }
        public string RouteName { get; set; }
        public System.DateTime ScheduledDate { get; set; }
        public string ScheduledDateRoute { get; set; }
        public string sentBy { get; set; }
    }
}