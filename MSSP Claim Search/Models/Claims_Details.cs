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
    
    public partial class Claims_Details
    {
        public int ClaimsDetailsKey { get; set; }
        public string CLAIM_NUMBER { get; set; }
        public string SUBSCRIBER_ID { get; set; }
        public string SEQ_CLAIM_ID { get; set; }
        public Nullable<short> LINE_NUMBER { get; set; }
        public string SUB_LINE_CODE { get; set; }
        public Nullable<System.DateTime> DETAIL_SVC_DATE { get; set; }
        public Nullable<System.DateTime> SVC_TO_DATE { get; set; }
        public string PROCEDURE_CODE { get; set; }
        public string MODIFIER_CODE_1 { get; set; }
        public string MODIFIER_CODE_2 { get; set; }
        public string MODIFIER_CODE_3 { get; set; }
        public string MODIFIER_CODE_4 { get; set; }
        public Nullable<short> REVENUE_CODE { get; set; }
        public string PLACE_OF_SVC_CODE1 { get; set; }
        public string PLACE_OF_SVC_CODE2 { get; set; }
        public string PLACE_OF_SVC_CODE3 { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public Nullable<decimal> BILLED_AMT { get; set; }
        public Nullable<decimal> PAID_AMT { get; set; }
        public string NDC_CODE { get; set; }
        public string RX_GENERIC_BRAND_IND { get; set; }
        public string RX_SUPPLY_DAYS { get; set; }
        public Nullable<decimal> RX_DISPENSING_FEE_AMT { get; set; }
        public Nullable<decimal> RX_INGREDIENT_AMT { get; set; }
        public string RX_FORMULARY_IND { get; set; }
        public Nullable<System.DateTime> RX_DATE_PRESCRIPTION_WRITTEN { get; set; }
        public Nullable<System.DateTime> RX_DATE_PRESCRIPTION_FILLED { get; set; }
        public string PRESCRIBING_PROV_TYPE_ID { get; set; }
        public string PRESCRIBING_PROV_ID { get; set; }
        public string BRAND_NAME { get; set; }
        public string DRUG_STRENGTH_DESC { get; set; }
        public string GPI { get; set; }
        public string GPI_DESC { get; set; }
        public string CONTROLLED_DRUG_IND { get; set; }
        public string COMPOUND_CODE { get; set; }
        public string SrcAdiTableName { get; set; }
        public int SrcAdiKey { get; set; }
        public System.DateTime LoadDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
