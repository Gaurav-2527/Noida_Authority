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
    
    public partial class FillerBlastHistory
    {
        public int FillerBlastHistoryId { get; set; }
        public int FillerBlastId { get; set; }
        public int ScheduleId { get; set; }
        public int EmailTemplateId { get; set; }
        public int UserId { get; set; }
        public System.DateTime DateSentOn { get; set; }
        public bool OwnDateSelected { get; set; }
        public bool DonorResponse { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<int> DonationId { get; set; }
        public Nullable<bool> IsCancel { get; set; }
    
        public virtual FillerBlast FillerBlast { get; set; }
        public virtual PickupSchedule PickupSchedule { get; set; }
    }
}
