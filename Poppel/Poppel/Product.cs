//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poppel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.StockItems = new HashSet<StockItem>();
            this.Product1 = new HashSet<Product>();
            this.Products = new HashSet<Product>();
            this.Categories = new HashSet<Category>();
        }
    
        public int product_id { get; set; }
        public string product_description { get; set; }
        public Nullable<decimal> product_price { get; set; }
        public string product_code { get; set; }
    
        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<Product> Product1 { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
