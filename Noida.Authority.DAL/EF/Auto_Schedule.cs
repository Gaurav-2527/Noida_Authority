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
    
    public partial class Auto_Schedule
    {
        public int Schedule_Id { get; set; }
        public Nullable<int> Scheme_Id { get; set; }
        public Nullable<int> Department_Id { get; set; }
        public Nullable<int> Process_Id { get; set; }
        public Nullable<int> Duration_In_Days { get; set; }
        public Nullable<int> Trigger_Process_Id { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        public virtual Process_Master Process_Master { get; set; }
        public virtual Process_Master Process_Master1 { get; set; }
    }
}
