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
    
    public partial class Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Route()
        {
            this.ItemsLeftbehinds = new HashSet<ItemsLeftbehind>();
            this.PickupSchedules = new HashSet<PickupSchedule>();
            this.PickupScheduleRoutes = new HashSet<PickupScheduleRoute>();
        }
    
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public int ZipCode { get; set; }
        public int Display { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsLeftbehind> ItemsLeftbehinds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PickupSchedule> PickupSchedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PickupScheduleRoute> PickupScheduleRoutes { get; set; }
    }
}
