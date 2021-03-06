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
    
    public partial class SchemeMst
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SchemeMst()
        {
            this.AlloteeListMasters = new HashSet<AlloteeListMaster>();
            this.ApplicationDetails = new HashSet<ApplicationDetail>();
            this.SchemeBankTrans = new HashSet<SchemeBankTran>();
            this.SchemeCostTrans = new HashSet<SchemeCostTran>();
            this.SchemeDepartmentTrans = new HashSet<SchemeDepartmentTran>();
            this.SchemeNotifTrans = new HashSet<SchemeNotifTran>();
            this.SchemePropTrans = new HashSet<SchemePropTran>();
            this.SchemeQuotaTrans = new HashSet<SchemeQuotaTran>();
            this.SchemeRebateTrans = new HashSet<SchemeRebateTran>();
            this.SchemeRefundTrans = new HashSet<SchemeRefundTran>();
            this.UnsuccessfulApplicantListMasters = new HashSet<UnsuccessfulApplicantListMaster>();
        }
    
        public int schemeId { get; set; }
        public Nullable<int> schemeTypeId { get; set; }
        public string schemeName { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public string modifiedBy { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public Nullable<bool> completed { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<decimal> FormFee { get; set; }
        public Nullable<decimal> ProcessingFee { get; set; }
        public Nullable<decimal> FormCGST { get; set; }
        public Nullable<decimal> FormSGST { get; set; }
        public Nullable<decimal> ProcessingCGST { get; set; }
        public Nullable<decimal> ProcessingSGST { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlloteeListMaster> AlloteeListMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationDetail> ApplicationDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchemeBankTran> SchemeBankTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchemeCostTran> SchemeCostTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchemeDepartmentTran> SchemeDepartmentTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchemeNotifTran> SchemeNotifTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchemePropTran> SchemePropTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchemeQuotaTran> SchemeQuotaTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchemeRebateTran> SchemeRebateTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchemeRefundTran> SchemeRefundTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnsuccessfulApplicantListMaster> UnsuccessfulApplicantListMasters { get; set; }
        public virtual SchemeTypeMst SchemeTypeMst { get; set; }
    }
}
