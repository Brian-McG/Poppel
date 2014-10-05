//Brian Mc George
//05-10-2014
//MCGBRI004

using System;
using System.Collections.Generic;
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
       

       #region Properties
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
