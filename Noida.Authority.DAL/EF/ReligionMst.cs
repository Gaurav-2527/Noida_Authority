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
    
    public partial class ReligionMst
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReligionMst()
        {
            this.ApplicationDetails = new HashSet<ApplicationDetail>();
        }
    
        public int religionId { get; set; }
        public string religion { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public string modifiedBy { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationDetail> ApplicationDetails { get; set; }
    }
}
