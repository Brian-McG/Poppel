using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Domain;
using Poppel.Database;
using System.Windows.Forms;

namespace Poppel.Order
{
    class OrderController
    {
        private Collection<OrderItem> products;
        private PoppelDatabase database;
        private decimal orderTotal;

        public decimal OrderTotal
        {
            get
            {
                return orderTotal;
            }
            set
            {
                orderTotal = value;
            }
        }

        public OrderController()
        {
            products = new Collection<OrderItem>();
            database = new PoppelDatabase();
            orderTotal = 0;
        }

        public Collection<OrderItem> getProducts()
        {
            setProducts();
            return products;
        }
        public static OrderItemForm getClickedForm(int id,Collection<OrderItemForm> orderItemForms)
        {
            OrderItemForm returnForm = null;
            bool stop = false;
            int i = 0;
            while (stop != true && i < orderItemForms.Count)
            {
                if (orderItemForms[i].Id == id)
                {
                    returnForm = orderItemForms[i];
                    stop = true;
                }
                i++;
                
            }
            return returnForm;
        }

        private void setProducts()
        {
          products =  database.readProducts();
            foreach(OrderItem orderItem in products)
            {
                orderItem.Quantity = 1;
            }
        }

        public OrderItem getProduct(int id)
        {
            OrderItem returnProduct=null;
            bool stop=false;
            int i = 0;
            while(stop!=true && i<products.Count)
            {
                if(products[i].Product.Id == id)
                {
                    returnProduct = products[i];
                    stop = true;
                }
                i++;
            }

            return returnProduct;

        }
        
    }
}
