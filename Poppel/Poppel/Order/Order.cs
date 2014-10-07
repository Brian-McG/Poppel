using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Domain;

namespace Poppel.Order
{
    public class Order
    {
        private Collection<OrderItem> products = new Collection<OrderItem>();
        private DateTime deliveryDate;
        private DateTime dateOrderPlaced;
        private Customer customer;
        private Employee employee;
        //Etc.


    }
}
