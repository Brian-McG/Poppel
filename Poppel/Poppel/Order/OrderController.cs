﻿//Brian Mc George
//MCGBRI004

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
        private Collection<OrderItemForm> displayedProducts;
        private Collection<OrderItemForm> allProducts;

        public Collection<OrderItemForm> AllProducts
        {
            get { return allProducts; }
            set { allProducts = value; }
        }

        public Collection<OrderItemForm> DisplayedProducts
        {
            get { return displayedProducts; }
            set
            {

                displayedProducts = value;

            }
        }

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
            allProducts = new Collection<OrderItemForm>();
            orderTotal = 0;
        }

        public Collection<OrderItem> getProducts()
        {
            setProducts();
            return products;
        }
        public static OrderItemForm getClickedForm(int id, Collection<OrderItemForm> orderItemForms)
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

        public void setAlternatives(int id)
        {

            OrderItemForm clickedForm = OrderController.getClickedForm(id, displayedProducts);

            for (int i = 0; i < allProducts.Count; i++)
            {
                if (!allProducts[i].Equals(clickedForm))
                {
                    allProducts[i].SimilarFilterCheckBox.Checked = false;
                }
            }

            Collection<OrderItemForm> alternativesForm = new Collection<OrderItemForm>();
            Collection<Product> alternatives;
            if (clickedForm.RefOrderItem.Product.Alternatives != null)
            {
                alternatives = clickedForm.RefOrderItem.Product.Alternatives;
            }
            else
            {
                alternatives = new Collection<Product>();
            }

            foreach (OrderItemForm alternative in displayedProducts)
            {
                if (alternative.Equals(clickedForm))
                {
                    alternativesForm.Add(clickedForm);
                }
                foreach (Product product in alternatives)
                {

                    if (alternative.RefOrderItem.Product.Id == product.Id)
                    {
                        alternativesForm.Add(alternative);
                    }
                }

            }

            displayedProducts = alternativesForm;


        }

        public void unSetAlternatives(int id)
        {
            OrderItemForm clickedForm = OrderController.getClickedForm(id, displayedProducts);
            displayedProducts.Clear();
            foreach (OrderItemForm orderItemForm in allProducts)
            {
                displayedProducts.Add(orderItemForm);
            }
        }

        private void setProducts()
        {
            products = database.readProducts();
            foreach (OrderItem orderItem in products)
            {
                orderItem.Quantity = 1;
            }
        }

        public static OrderItem getProduct(int id, Collection<OrderItem> products)
        {
            OrderItem returnProduct = null;
            bool stop = false;
            int i = 0;
            while (stop != true && i < products.Count)
            {
                if (products[i].Product.Id == id)
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
