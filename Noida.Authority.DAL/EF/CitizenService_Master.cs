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
    
    public partial class CitizenService_Master
    {
        public int Id { get; set; }
        public Nullable<int> Deptt_Id { get; set; }
        public Nullable<int> service_id { get; set; }
        public string ServiceName { get; set; }
        public Nullable<int> Timeline { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Status { get; set; }
        public string NMServiceID { get; set; }
        public Nullable<int> TemplateId { get; set; }
    }
}
