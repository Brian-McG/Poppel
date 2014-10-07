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
        #region Properties
        private Collection<Product> productToBePicked
        {
            get
            {
                return productToBePicked;
            }
            set
            {
                productToBePicked = value;
            }
        }
        #endregion
        public PickingListReport(Collection<Product> productToBePicked)
            : base()
        {
            this.productToBePicked = productToBePicked;
        }


   }
}
