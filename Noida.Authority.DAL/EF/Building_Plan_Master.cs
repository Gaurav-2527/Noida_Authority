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
    
    public partial class Building_Plan_Master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Building_Plan_Master()
        {
            this.Building_Plan_Trans = new HashSet<Building_Plan_Trans>();
        }
    
        public int id { get; set; }
        public Nullable<int> Rid { get; set; }
        public string BP_File_Name { get; set; }
        public Nullable<int> Property_Use { get; set; }
        public Nullable<System.DateTime> Submission_Date { get; set; }
        public Nullable<System.DateTime> Sanction_Date { get; set; }
        public Nullable<System.DateTime> Sanctioned_Plan_Validity { get; set; }
        public Nullable<decimal> Purchasable_Far_Percent { get; set; }
        public string Map_Released { get; set; }
        public string Map_Revised { get; set; }
        public Nullable<decimal> Plot_Area { get; set; }
        public Nullable<decimal> Covered_Area { get; set; }
        public Nullable<double> FAR { get; set; }
        public Nullable<int> Max_No_Stories { get; set; }
        public string Architect_Reg_No { get; set; }
        public string Architect_Name { get; set; }
        public Nullable<bool> Is_Completed { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_Plan_Trans> Building_Plan_Trans { get; set; }
    }
}
