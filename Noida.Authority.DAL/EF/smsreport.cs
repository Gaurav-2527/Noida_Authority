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
    
    public partial class smsreport
    {
        public int ID { get; set; }
        public string form_no { get; set; }
        public string MobileNo { get; set; }
        public string TextMasage { get; set; }
        public Nullable<System.DateTime> sendingdate { get; set; }
        public string response_status { get; set; }
        public string scheme_no { get; set; }
    }
}
