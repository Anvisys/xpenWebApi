//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAS
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewProject
    {
        public int ProjectID { get; set; }
        public string ProjectNumber { get; set; }
        public string ClientName { get; set; }
        public string ProjectName { get; set; }
        public Nullable<int> ProjectValue { get; set; }
        public System.DateTime ProjectCreationDate { get; set; }
        public string ProjectDescription { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public System.DateTime StatusOn { get; set; }
        public Nullable<int> WorkCompletion { get; set; }
        public string StatusRemark { get; set; }
        public string Status { get; set; }
        public int Spent { get; set; }
        public int Received { get; set; }
        public int OrgID { get; set; }
    }
}
