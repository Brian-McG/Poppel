using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Domain;
using System.Collections.ObjectModel;
using Poppel.Order;
using Poppel.Database;

namespace Poppel.Report
{
    public class PickingListReport
   {
        #region Properties
        public Collection<ReportItem> productToBePicked;
        public Collection<ReportItem> ProductToBePicked
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
        private PoppelDatabase pd;
        public PickingListReport(): base()
        {
            this.ProductToBePicked = new Collection<ReportItem>();
            pd = new PoppelDatabase();
        }


        public Collection<ReportItem> getOrderProducts(String date)
        {
            ProductToBePicked=pd.readOrderItem();
            return ProductToBePicked;
        }
   }
}
