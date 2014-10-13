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
using Poppel.Database;

namespace Poppel.PresentationLayer
{
    public partial class CancelOrder : Form
    {
        private RemoveOrderController removeOrderController;
        private Collection<RemoveOrderItem> products;
        public CancelOrder()
        {
            InitializeComponent();
            removeOrderController = new RemoveOrderController();
            ordersListView.View = View.Details;
            products = removeOrderController.getOrders();
            

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
            PoppelDatabase pd = new PoppelDatabase();
            ordersListView.Clear();
            ListViewItem itemDetails;
            //Set Up Columns of List View
            ordersListView.Columns.Insert(0, "Order Number", 95, HorizontalAlignment.Left);
            ordersListView.Columns.Insert(1, "Order Date", 95, HorizontalAlignment.Left);

            try
            {
                errorLabel.Visible = false ;
                foreach (RemoveOrderItem item in products)
                {
                    //Need a way to find out what order this is associated to
                    itemDetails = new ListViewItem();
                    itemDetails.Text = item.orderNumber;
                    itemDetails.SubItems.Add(item.orderDatePlaced);
                    ordersListView.Items.Add(itemDetails);
                }
                ordersListView.Refresh();
                ordersListView.GridLines = true;
            }
            catch(Exception e){
                errorLabel.Text = "No orders for customer!";
                errorLabel.Visible = true;
            }
        
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
