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
    
    public partial class AuditBinPartnershipLocation
    {
        public int BinPartnershipLocationAuditId { get; set; }
        public int BinPartnershipLocationId { get; set; }
        public string Town { get; set; }
        public string BinLocation { get; set; }
        public int AddressNumber { get; set; }
        public string AddressStreet { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string CrossStreet { get; set; }
        public int NumberofBins { get; set; }
        public int RelationshipTypeId { get; set; }
        public int BinFeeTypeId { get; set; }
        public string ContactName { get; set; }
        public string Phone1 { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public Nullable<bool> Display { get; set; }
        public string Action { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Phone2 { get; set; }
        public string Company { get; set; }
        public Nullable<decimal> FeeTypeBasis { get; set; }
        public Nullable<decimal> FeeAmount { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> DateEnteredOn { get; set; }
    }
}
