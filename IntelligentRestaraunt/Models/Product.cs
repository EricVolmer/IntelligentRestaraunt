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
    
    public partial class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productPrice { get; set; }
        public int categoryID { get; set; }
    
        public virtual Category Category { get; set; }
    }
}