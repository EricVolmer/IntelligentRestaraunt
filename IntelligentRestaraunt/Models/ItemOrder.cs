//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentRestaraunt.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemOrder()
        {
            this.quantity = 0;
            this.Products = new HashSet<Product>();
        }
    
        public int ItemOrderId { get; set; }
        public int productID { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
        public int categoryID { get; set; }
        public int quantity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
