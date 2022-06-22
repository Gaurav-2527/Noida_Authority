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
    
    public partial class Donor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donor()
        {
            this.Donations = new HashSet<Donation>();
            this.DWAReports = new HashSet<DWAReport>();
        }
    
        public int DonorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Salutation { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Organization { get; set; }
        public int DonorStatusId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public int DateKey { get; set; }
        public bool IsPhonePreferred { get; set; }
        public bool IsEmailPreferred { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string AlternatePhone { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public bool IsSMSPreferred { get; set; }
    
        public virtual DateDimension DateDimension { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual DonorStatu DonorStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DWAReport> DWAReports { get; set; }
    }
}