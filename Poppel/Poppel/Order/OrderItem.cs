﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Domain;

namespace Poppel.Order
{
    public class OrderItem
    {
        private Product product;
        private int quantity;

        public Product Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

    }
}
