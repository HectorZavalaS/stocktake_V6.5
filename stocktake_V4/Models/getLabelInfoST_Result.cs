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
    
    public partial class getLabelInfoST_Result
    {
        public int se_id_label { get; set; }
        public int se_id_user { get; set; }
        public string se_serial_read { get; set; }
        public string se_magazine { get; set; }
        public string se_model { get; set; }
        public string se_dj_group { get; set; }
        public string se_semifinish { get; set; }
        public int se_qty { get; set; }
        public string se_cgs_route { get; set; }
        public string se_barcode { get; set; }
        public System.DateTime se_date { get; set; }
        public int se_checked { get; set; }
        public int se_checkPrint { get; set; }
    }
}
