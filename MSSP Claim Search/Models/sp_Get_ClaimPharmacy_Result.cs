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
    
    public partial class sp_Get_ClaimPharmacy_Result
    {
        public string ClaimID { get; set; }
        public string MemberID { get; set; }
        public Nullable<short> LineNumber { get; set; }
        public string LineCode { get; set; }
        public Nullable<System.DateTime> SvcStartDate { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> BilledAmt { get; set; }
        public Nullable<decimal> PaidAmt { get; set; }
        public string NDCCode { get; set; }
        public string GenBrandInd { get; set; }
        public string SuppyDays { get; set; }
        public Nullable<decimal> DispFeeAmt { get; set; }
        public Nullable<decimal> IngredientAmt { get; set; }
        public string FormInd { get; set; }
        public Nullable<System.DateTime> PrescriptionDateWritten { get; set; }
        public Nullable<System.DateTime> PrescriptionDateFilled { get; set; }
        public string PrescribingProvType { get; set; }
        public string PrescribingProvID { get; set; }
        public string BrandName { get; set; }
        public string DrugStrength { get; set; }
        public string GPI { get; set; }
        public string GPIDesc { get; set; }
        public string CtrlDrugInd { get; set; }
        public string CompoundCode { get; set; }
    }
}