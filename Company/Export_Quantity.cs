//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Company
{
    using System;
    using System.Collections.Generic;
    
    public partial class Export_Quantity
    {
        public int Per_Num_E { get; set; }
        public int I_Code { get; set; }
        public string Cus_Email { get; set; }
        public string WH_Name { get; set; }
        public int Out_Quantity { get; set; }
        public Nullable<System.DateTime> Prod_Date { get; set; }
        public Nullable<System.DateTime> Expi_Date { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Item Item { get; set; }
        public virtual Permetion_Export Permetion_Export { get; set; }
        public virtual WareHouse WareHouse { get; set; }
    }
}