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
    
    public partial class GlobalConfigurationSetting
    {
        public int GlobalConfigurationSettingId { get; set; }
        public string DispatchEmail { get; set; }
        public string CustomerCareEmail { get; set; }
        public string AdminEmail { get; set; }
        public bool IsIngenuityAutoUpload { get; set; }
        public System.TimeSpan IngenuityNewFileCheckTime { get; set; }
        public Nullable<int> Frequency { get; set; }
        public Nullable<int> IngenuitySkipCycle { get; set; }
        public Nullable<int> FillerBlastSkip { get; set; }
        public string Action { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
