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
    
    public partial class Director_Request_Master
    {
        public int Id { get; set; }
        public Nullable<int> Rid { get; set; }
        public Nullable<System.DateTime> Request_Date { get; set; }
        public Nullable<System.DateTime> Approved_date { get; set; }
        public Nullable<int> Approved_By { get; set; }
        public Nullable<int> Status { get; set; }
        public string Director_Id { get; set; }
        public Nullable<int> Is_Active { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public Nullable<decimal> CIC_Charge { get; set; }
        public Nullable<int> Change_Type { get; set; }
        public string Comment { get; set; }
        public string RComment { get; set; }
        public Nullable<System.DateTime> RCommentDate { get; set; }
        public Nullable<int> OnlineRequestNo { get; set; }
    }
}
