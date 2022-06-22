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
    
    public partial class SchemePropTrans_log
    {
        public int refId { get; set; }
        public Nullable<int> schemeId { get; set; }
        public Nullable<int> departmentId { get; set; }
        public Nullable<int> propertyTypeId { get; set; }
        public Nullable<int> sectorId { get; set; }
        public Nullable<int> blockId { get; set; }
        public Nullable<int> floorId { get; set; }
        public Nullable<int> propertyId { get; set; }
        public string propertyNo { get; set; }
        public Nullable<decimal> propertyCost { get; set; }
        public Nullable<decimal> civilCost { get; set; }
        public Nullable<decimal> landRatePerSqmt { get; set; }
        public Nullable<decimal> totalArea { get; set; }
        public Nullable<decimal> coveredArea { get; set; }
        public Nullable<decimal> actualArea { get; set; }
        public string Registry { get; set; }
        public Nullable<decimal> allotmentMoney { get; set; }
        public Nullable<decimal> totalPropertyCost { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public string modifiedBy { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public Nullable<int> ParentPropertyId { get; set; }
        public Nullable<int> VillageId { get; set; }
        public string KhasraNumber { get; set; }
        public string KhatoniNumber { get; set; }
        public Nullable<decimal> Processingfee { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<int> groupProjectId { get; set; }
        public Nullable<decimal> EarnestMoney { get; set; }
    }
}