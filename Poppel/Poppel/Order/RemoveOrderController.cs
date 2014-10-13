using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Poppel.Report;
using Poppel.Database;

namespace Poppel.Order
{
    public class RemoveOrderController
    {
        public Collection<RemoveOrderItem> products;
        PoppelDatabase pd = new PoppelDatabase();
        public RemoveOrderController()
        {
            products = new Collection<RemoveOrderItem>();
        }

        public Collection<RemoveOrderItem> getOrders()
        {
            products=pd.getOrders();
            return products;
        }

        public void Delete(String orderID)
        {

        }
    }
}
