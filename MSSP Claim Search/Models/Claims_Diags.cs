//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSSP_Claim_Search.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Claims_Diags
    {
        public long URN { get; set; }
        public string SEQ_CLAIM_ID { get; set; }
        public string SUBSCRIBER_ID { get; set; }
        public string ICD_FLAG { get; set; }
        public Nullable<short> diagNumber { get; set; }
        public string diagCode { get; set; }
        public string diagCodeWithoutDot { get; set; }
        public string diagPoa { get; set; }
        public System.DateTime LoadDate { get; set; }
        public string SrcAdiTableName { get; set; }
        public int SrcAdiKey { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
