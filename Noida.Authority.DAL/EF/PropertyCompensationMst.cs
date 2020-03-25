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
    
    public partial class PropertyCompensationMst
    {
        public int Id { get; set; }
        public Nullable<int> PropertyId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> SectorId { get; set; }
        public Nullable<int> BlockId { get; set; }
        public Nullable<decimal> EffectedArea { get; set; }
        public Nullable<decimal> CompensationRate { get; set; }
        public Nullable<decimal> CompensationInPercent { get; set; }
        public Nullable<decimal> PenalInterest { get; set; }
        public Nullable<decimal> InterestAmount { get; set; }
        public Nullable<decimal> CompensationAmount { get; set; }
        public Nullable<decimal> TotalCompensationAmount { get; set; }
        public Nullable<System.DateTime> CompensationRequestDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual BlockMst BlockMst { get; set; }
        public virtual DepartmentMst DepartmentMst { get; set; }
        public virtual SectorMst SectorMst { get; set; }
    }
}
