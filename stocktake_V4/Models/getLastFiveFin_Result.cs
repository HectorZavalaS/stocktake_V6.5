//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stocktake_V4.Models
{
    using System;
    
    public partial class getLastFiveFin_Result
    {
        public string BARCODE { get; set; }
        public string MAGAZINE { get; set; }
        public string MODEL { get; set; }
        public string DJ_GROUP { get; set; }
        public int FIN_QTY { get; set; }
        public System.DateTime FIN_DATE { get; set; }
        public int PROD_QTY { get; set; }
        public string VALIDATED_BY_QA { get; set; }
        public string USER_VALIDATE { get; set; }
        public Nullable<System.DateTime> DATE_VALIDATED { get; set; }
    }
}
