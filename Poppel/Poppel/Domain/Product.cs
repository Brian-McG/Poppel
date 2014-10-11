//Brian Mc George
//05-10-2014
//MCGBRI004

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel.Domain
{
   public class Product
    {
       private int id;
       private string description;
       private decimal price;
       private int numberInStock;
       private string productCode;
       private Collection<Product> alternatives;
       private Collection<Category> categories;


       

       #region Properties

       public Collection<Category> Categories
       {
           get { return categories; }
           set { categories = value; }
       }
       public Collection<Product> Alternatives
       {
           get { return alternatives; }
           set { alternatives = value; }
       }

       public decimal Vat
       {
           get
           {
               return decimal.Multiply(price, 0.14M);
           }
       }

       public decimal Total
       {
           get
           {
               return decimal.Add(price, Vat);
           }

       }

       public int Id
       {
           get
           {
               return id;
           }
           set
           {
               id = value;
           }
       }

       public string Description
       {
           get
           {
               return description;
           }
           set
           {
               description = value;
           }
       }

       public decimal Price
       {
           get
           {
               return price;
           }
           set
           {
               price = value;
           }
       }
       public int NumberInStock
       {
           get
           {
               return numberInStock;
           }
           set
           {
               numberInStock = value;
           }
       }
       public string ProductCode
       {
           get
           {
               return productCode;
           }
           set
           {
               productCode = value;
           }
       }
       #endregion

    }
}
