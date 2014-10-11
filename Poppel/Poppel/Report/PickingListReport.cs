using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Domain;
using System.Collections.ObjectModel;
using Poppel.Order;

namespace Poppel.Report
{
    public class PickingListReport
   {
        #region Properties
        OrderController orderController = new OrderController(null,null);
        public Collection<OrderItem> productToBePicked
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
        public PickingListReport(): base()
        {
            this.productToBePicked = orderController.getProducts();
        }


   }
}
