using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Order;
using System.Collections.ObjectModel;

namespace Poppel.Report
{
    public class ExpiredProductReport : Report
    {
        #region Properties
        private Collection<OrderItem> expiredProducts
        {
            get
            {
                return expiredProducts;
            }
            set
            {
                expiredProducts = value;
            }
        }
        #endregion
        public ExpiredProductReport(): base()
        {
            expiredProducts = new Collection<OrderItem>();
        }

    
    }
}
