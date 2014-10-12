using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel.Report
{
    public class StockItem
    {
        #region Properties
        public String expiryDate
        {
            get
            {
                return expiryDate;
            }
            set
            {
                expiryDate = value;
            }
        }
        public String rackNumber
        {
            get
            {
                return expiryDate;
            }
            set
            {
                expiryDate = value;
            }
        }
        public String numberInStock
        {
            get
            {
                return expiryDate;
            }
            set
            {
                expiryDate = value;
            }
        }
        public String productRef
           {
                get
            {
                return expiryDate;
            }
            set
            {
                expiryDate = value;
            }
        }
        #endregion
        public StockItem(String expiryDate, String rackNumber, String numberInStock, String productRef)
        {
            this.expiryDate = expiryDate;
            this.rackNumber = rackNumber;
            this.numberInStock = numberInStock;
            this.productRef = productRef;
        }

        public StockItem()
        {
            this.expiryDate = "";
            this.rackNumber = "";
            this.numberInStock = "";
            this.productRef = "";
        }
    }
}
