using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Poppel.Order;

namespace Poppel.PresentationLayer
{
    public partial class CancelOrder : Form
    {
        private OrderController orderController;
        private Collection<OrderItem> products;
        private Collection<OrderItem> orderItems;
        public CancelOrder()
        {
            products = orderController.getProducts();
            removeButton.Enabled = false;
            InitializeComponent();
            setUpListView();
        }

        private void ordersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersListView.SelectedItems.Count == 0)
            {
                removeButton.Enabled = false;
            }
            else
            {
                removeButton.Enabled = true;
            }
        }

        public void setUpListView()
        {
            //Clear current List View Control
            ordersListView.Clear();
            ListViewItem itemDetails;
            //Set Up Columns of List View
            ordersListView.Columns.Insert(0, "Order Number", 95, HorizontalAlignment.Left);
            ordersListView.Columns.Insert(1, "Total Cost", 75, HorizontalAlignment.Left);
            ordersListView.Columns.Insert(2, "", 0, HorizontalAlignment.Left);

            //Add employee details to each ListView item 
            foreach (OrderItem item in products)
            {
                //Need a way to find out what order this is associated to
                    itemDetails = new ListViewItem();
                    itemDetails.Text = item.Product.Id+"";// Need order item
                    itemDetails.SubItems.Add(item.Quantity+"");
                    ordersListView.Items.Add(itemDetails);
            }


            ordersListView.Refresh();
            ordersListView.GridLines = true;
        }
    }
}
