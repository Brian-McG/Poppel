using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Poppel.Report;
using Poppel.Database;
using Poppel.CustomerMangement;

namespace Poppel.Order
{
    public class RemoveOrderController
    {
        public Collection<RemoveOrderItem> products;
        PoppelDatabase pd = new PoppelDatabase();
        private CustomerManangementController customerManagementController;
        public RemoveOrderController(CustomerManangementController customerManagementController)
        {
            this.customerManagementController = customerManagementController;
            products = new Collection<RemoveOrderItem>();
        }

        public Collection<RemoveOrderItem> getOrders()
        {
            products = pd.getOrders(customerManagementController.Customer.Id);
            return products;
        }

        public void Delete(int orderID)
        {
            
            pd.deleteOrder(orderID);
        }
    }
}
