//Brian Mc George
//05-10-2014
//MCGBRI004

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel.Order;
using Poppel.Domain;

namespace Poppel.PresentationLayer
{
    public partial class CreateOrder : Form
    {
        private OrderController orderController;
        private Collection<OrderItem> products;
        private Collection<OrderItem> orderItems;
        


        public CreateOrder()
        {
            InitializeComponent();
            orderController = new OrderController();

            products = orderController.getProducts();
            orderItems = new Collection<OrderItem>();
            setUpEmployeeListView();
            setUpOrderFlowPanel();
            basketListView.View = View.Details;
        }

        private void setUpOrderFlowPanel()
        {
            foreach (OrderItem orderItem in products)
            {
                FlowLayoutPanel productPanel = new FlowLayoutPanel();
                productPanel.Width = 200;
                productPanel.Height = 270;
                productPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                Label pictureLabel = new Label();
                pictureLabel.Width = 200;
                pictureLabel.Height = 150;
                Bitmap pictureBitmap = new Bitmap("Assets/" + orderItem.Product.ProductCode + ".png");
                pictureLabel.Image = pictureBitmap;
                productPanel.Controls.Add(pictureLabel);

                Label productDescriptionLabel = new Label();
                productDescriptionLabel.Width = productPanel.Width;
                productDescriptionLabel.Text = orderItem.Product.Description;
                productDescriptionLabel.TextAlign = ContentAlignment.TopCenter;
                productPanel.Controls.Add(productDescriptionLabel);

                Label numberInStockLabel = new Label();
                numberInStockLabel.Text = "Quantity In Stock: " + orderItem.Product.NumberInStock;
                numberInStockLabel.AutoSize = true;
                numberInStockLabel.Width = productPanel.Width;

                CheckBox similarFilterCheckBox = new CheckBox();
                similarFilterCheckBox.Width = productPanel.Width;
                similarFilterCheckBox.Text = "Filter to alternatives";

                productPanel.Controls.Add(numberInStockLabel);
                productPanel.Controls.Add(similarFilterCheckBox);

                Label costLabel = new Label();
                costLabel.Text = "R " + string.Format("{0:0.00}", orderItem.Product.Price);
                costLabel.Width = productPanel.Width;
                costLabel.BackColor = Color.NavajoWhite;
                costLabel.TextAlign = ContentAlignment.MiddleCenter;
                costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costLabel.Width = productPanel.Width;
                productPanel.Controls.Add(costLabel);

                Label quantityLabel = new Label();
                quantityLabel.Text = "Quantity:";
                quantityLabel.TextAlign = ContentAlignment.MiddleCenter;
                quantityLabel.Size = new System.Drawing.Size(49, 20);
                productPanel.Controls.Add(quantityLabel);

                NumericUpDown orderQuantityNumericUpDown = new NumericUpDown();
                orderQuantityNumericUpDown.Minimum=1;
                orderQuantityNumericUpDown.Width = 35;
                orderQuantityNumericUpDown.Tag = orderItem.Product.Id;
                orderQuantityNumericUpDown.Maximum = orderItem.Product.NumberInStock;
                productPanel.Controls.Add(orderQuantityNumericUpDown);
                orderQuantityNumericUpDown.ValueChanged += new EventHandler(orderQuantity_ValueChanged);

                Button placeOrderButton = new Button();
                placeOrderButton.Tag = orderItem.Product.Id;
                placeOrderButton.Text = "Add";
                placeOrderButton.Click += new EventHandler(this.addButton_Click);

                Label spacerLabel = new Label();
                spacerLabel.Width = 15;
                productPanel.Controls.Add(spacerLabel);
                productPanel.Controls.Add(placeOrderButton);
                stockItemsFlowLayoutPanel.Controls.Add(productPanel);
            }
        }
        private void orderQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown quantityUpDown = (NumericUpDown)sender;
              int id = -1;
              if (int.TryParse(quantityUpDown.Tag.ToString(), out id))
              {
                  orderController.getProduct(id).Quantity = decimal.ToInt32(quantityUpDown.Value);
              }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int id = -1;
            if (int.TryParse(clickedButton.Tag.ToString(), out id))
            {
                addToOrder(orderController.getProduct(id));
            }

        }

        private void flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
         //   stockItemsFlowLayoutPanel.Focus();
        }

        private void flowLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            stockItemsFlowLayoutPanel.Focus();
        }

        public void setUpEmployeeListView()
        {



            //Clear current List View Control
            basketListView.Clear();

            //Set Up Columns of List View
            basketListView.Columns.Insert(0, "Product", 95, HorizontalAlignment.Left);
            basketListView.Columns.Insert(1, "Quantity", 55, HorizontalAlignment.Left);
            basketListView.Columns.Insert(2, "Total Cost", 75, HorizontalAlignment.Left);
            basketListView.Columns.Insert(3, "", 0, HorizontalAlignment.Left);

            //Add employee details to each ListView item 



            basketListView.Refresh();
            basketListView.GridLines = true;

        }

        public void addToOrder(OrderItem orderItem)
        {
            ListViewItem orderItemDetails;
            orderItemDetails = new ListViewItem();
            orderItemDetails.Text = ""+orderItem.Product.Description;
            orderItemDetails.SubItems.Add(""+orderItem.Quantity);
            orderItemDetails.SubItems.Add("R " + string.Format("{0:0.00}", (orderItem.Quantity * orderItem.Product.Price)));
            orderItemDetails.SubItems[0].Tag = orderItem.Product.Id;
            basketListView.Items.Add(orderItemDetails);

            orderItems.Add(orderItem);
            checkOutButton.Enabled = true;

            orderController.OrderTotal+=(orderItem.Quantity * orderItem.Product.Price);
            totalCostTextBox.Text = "R " + string.Format("{0:0.00}", (orderController.OrderTotal));

        }

        private void basketListView_Click(object sender, EventArgs e)
        {
            removeFromOrderButton.Enabled = true;

        }

        private void basketListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(basketListView.SelectedItems.Count==0)
            {
                removeFromOrderButton.Enabled = false;
            }
            else
            {
                removeFromOrderButton.Enabled = true;
            }
                
        }

        private void basketListView_Leave(object sender, EventArgs e)
        {
     //       removeFromOrderButton.Enabled = false;
        }

        private void removeFiltersButton_Click(object sender, EventArgs e)
        {

        }

        private void removeFromOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item from the order?", "Confirm Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int parseInt = -1;
                if (int.TryParse(basketListView.SelectedItems[0].SubItems[0].Tag.ToString(), out parseInt))
                {
                    OrderItem removalItem = orderController.getProduct(parseInt);
                    orderItems.Remove(removalItem);
                    basketListView.Items.Remove(basketListView.SelectedItems[0]);
                    orderController.OrderTotal -= (removalItem.Product.Price * removalItem.Quantity);
                    totalCostTextBox.Text = "R " + string.Format("{0:0.00}", (orderController.OrderTotal));
                    if(orderItems.Count==0)
                    {
                        checkOutButton.Enabled = false;
                    }
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

           
             
           
            
        }
    }
}
