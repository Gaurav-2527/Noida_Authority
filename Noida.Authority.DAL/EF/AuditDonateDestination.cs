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
    
    public partial class AuditDonateDestination
    {
        public int DonateDestinationAuditId { get; set; }
        public int DonateDestinationId { get; set; }
        public string Region { get; set; }
        public string Location { get; set; }
        public Nullable<int> Display { get; set; }
        public int Action { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public int DateKey { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> DateEnteredOn { get; set; }
    }
}
