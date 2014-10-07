using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Domain;
using System.Collections.ObjectModel;

namespace Poppel.Report
{
    public class PickingListReport
   {
        private Collection<Product> productToBePicked;
        public PickingListReport(Collection<Product> productToBePicked)
            : base()
        {
            this.productToBePicked = productToBePicked;
        }

       #region Properties
        private Collection<Product> ProductToBePicked
        {
            get
            {
                return productToBePicked;
            }
        }
       #endregion
   }
}
