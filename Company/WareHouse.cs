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
    
    public partial class WareHouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WareHouse()
        {
            this.Export_Quantity = new HashSet<Export_Quantity>();
            this.Import_Quantity = new HashSet<Import_Quantity>();
            this.item_WareHouse = new HashSet<item_WareHouse>();
            this.Move_To = new HashSet<Move_To>();
            this.Move_To1 = new HashSet<Move_To>();
            this.Permetion_Export = new HashSet<Permetion_Export>();
            this.Permetion_Import = new HashSet<Permetion_Import>();
        }
    
        public string WH_Name { get; set; }
        public string WH_Address { get; set; }
        public string WH_Maneger { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Export_Quantity> Export_Quantity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import_Quantity> Import_Quantity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<item_WareHouse> item_WareHouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Move_To> Move_To { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Move_To> Move_To1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permetion_Export> Permetion_Export { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permetion_Import> Permetion_Import { get; set; }
    }
}
