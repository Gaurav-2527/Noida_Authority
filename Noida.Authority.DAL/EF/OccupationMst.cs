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
    
    public partial class OccupationMst
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OccupationMst()
        {
            this.ApplicationDetails = new HashSet<ApplicationDetail>();
        }
    
        public int occupationId { get; set; }
        public string occupation { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public string modifiedBy { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationDetail> ApplicationDetails { get; set; }
    }
}