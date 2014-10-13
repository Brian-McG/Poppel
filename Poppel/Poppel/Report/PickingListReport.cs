﻿using System;
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
        private PoppelDatabase pd;
        public PickingListReport(): base()
        {
            this.productToBePicked = orderController.getProducts();
            pd = new PoppelDatabase();
        }

        public String getRackNumber(int ID)
        {
            return pd.getRackNumber(ID);
        }

        public String getOrderNumber(int ID)
        {
            return pd.getOrderNumber(ID);
        }

        public DateTime getOrderDate(String ID)
        {
            return pd.getOrderDate(ID);
        }
   }
}
