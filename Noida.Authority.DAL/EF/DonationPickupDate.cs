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
    
    public partial class DonationPickupDate
    {
        public int DonationPickupId { get; set; }
        public Nullable<int> DonationId { get; set; }
        public Nullable<int> DateKey { get; set; }
    
        public virtual DateDimension DateDimension { get; set; }
        public virtual Donation Donation { get; set; }
    }
}