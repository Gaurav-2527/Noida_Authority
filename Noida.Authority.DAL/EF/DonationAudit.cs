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
    
    public partial class DonationAudit
    {
        public int DonationAuditId { get; set; }
        public Nullable<int> DonorId { get; set; }
        public Nullable<int> DonationTypeId { get; set; }
        public Nullable<int> DWAStatusId { get; set; }
        public Nullable<int> ItemWeight { get; set; }
        public Nullable<int> DonorSourceId { get; set; }
        public Nullable<int> DonationStatusId { get; set; }
        public Nullable<int> ItemLocationId { get; set; }
        public Nullable<int> PickupPriorityId { get; set; }
        public Nullable<System.DateTime> PickUpDate { get; set; }
        public Nullable<bool> IsPhonePreferred { get; set; }
        public Nullable<bool> IsEmailPreferred { get; set; }
        public Nullable<bool> IsSMSPreferred { get; set; }
        public Nullable<bool> IsDWA { get; set; }
        public Nullable<bool> IsDonationRouteException { get; set; }
        public Nullable<bool> IsMultipleDates { get; set; }
        public string Comments { get; set; }
        public string Instructions { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<int> DateKey { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> DataEnteredOn { get; set; }
        public Nullable<int> DonationId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public Nullable<bool> IsDoNotCall { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Salutation { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Organization { get; set; }
        public Nullable<int> DonorStatusId { get; set; }
        public string AlternatePhone { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> AddressTypeId { get; set; }
        public Nullable<int> AddressNumber { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string StreetAddress { get; set; }
        public string CrossStreet { get; set; }
        public string HouseColor { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> CityId { get; set; }
        public string ZipCode { get; set; }
        public string AddressUnit { get; set; }
        public Nullable<bool> IsMissedOrRescheduled { get; set; }
        public string MissedOrRescheduledReason { get; set; }
        public string AddressInstruction { get; set; }
        public Nullable<System.DateTime> dwaDate { get; set; }
    }
}