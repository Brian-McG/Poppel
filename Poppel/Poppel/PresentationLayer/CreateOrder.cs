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
        private Collection<OrderItemForm> displayedProducts;
        


        public CreateOrder()
        {
            InitializeComponent();
            orderController = new OrderController();

            products = orderController.getProducts();
            orderItems = new Collection<OrderItem>();
            displayedProducts = new Collection<OrderItemForm>();
            setUpEmployeeListView();
            setUpOrderFlowPanel();
            basketListView.View = View.Details;
        }

        private void setUpOrderFlowPanel()
        {
            foreach (OrderItem orderItem in products)
            {

                OrderItemForm orderItemForm = new OrderItemForm();

                orderItemForm.Id = orderItem.Product.Id;

                orderItemForm.ProductPanel.Width = 200;
                orderItemForm.ProductPanel.Height = 270;
                orderItemForm.ProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


                orderItemForm.PictureLabel.Width = 200;
                orderItemForm.PictureLabel.Height = 150;
                Bitmap pictureBitmap = new Bitmap("Assets/" + orderItem.Product.ProductCode + ".png");
                orderItemForm.PictureLabel.Image = pictureBitmap;
                orderItemForm.ProductPanel.Controls.Add(orderItemForm.PictureLabel);
                
            orderItemForm.ProductDescriptionLabel = new Label();
            orderItemForm.ProductDescriptionLabel.Width = orderItemForm.ProductPanel.Width;
            orderItemForm.ProductDescriptionLabel.Text = orderItem.Product.Description;
            orderItemForm.ProductDescriptionLabel.TextAlign = ContentAlignment.TopCenter;
            orderItemForm.ProductPanel.Controls.Add(orderItemForm.ProductDescriptionLabel);

                
            orderItemForm.NumberInStockLabel.Text = "Quantity In Stock: " + orderItem.Product.NumberInStock;
            orderItemForm.NumberInStockLabel.AutoSize = true;
            orderItemForm.NumberInStockLabel.Width = orderItemForm.ProductPanel.Width;


            orderItemForm.SimilarFilterCheckBox.Width = orderItemForm.ProductPanel.Width;
            orderItemForm.SimilarFilterCheckBox.Text = "Filter to alternatives";

            orderItemForm.ProductPanel.Controls.Add(orderItemForm.NumberInStockLabel);
            orderItemForm.ProductPanel.Controls.Add(orderItemForm.SimilarFilterCheckBox);


            orderItemForm.CostLabel = new Label();
            orderItemForm.CostLabel.Text = "R " + string.Format("{0:0.00}", orderItem.Product.Price);
            orderItemForm.CostLabel.Width = orderItemForm.ProductPanel.Width;
            orderItemForm.CostLabel.BackColor = Color.NavajoWhite;
            orderItemForm.CostLabel.TextAlign = ContentAlignment.MiddleCenter;
            orderItemForm.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderItemForm.CostLabel.Width = orderItemForm.ProductPanel.Width;
            orderItemForm.ProductPanel.Controls.Add(orderItemForm.CostLabel);

                
            orderItemForm.QuantityLabel.Text = "Quantity:";
            orderItemForm.QuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            orderItemForm.QuantityLabel.Size = new System.Drawing.Size(49, 20);
            orderItemForm.ProductPanel.Controls.Add(orderItemForm.QuantityLabel);

                
            orderItemForm.OrderQuantityNumericUpDown.Minimum = 1;
            orderItemForm.OrderQuantityNumericUpDown.Width = 35;
            orderItemForm.OrderQuantityNumericUpDown.Tag = orderItem.Product.Id;
            orderItemForm.OrderQuantityNumericUpDown.Maximum = orderItem.Product.NumberInStock;
            orderItemForm.ProductPanel.Controls.Add(orderItemForm.OrderQuantityNumericUpDown);
            orderItemForm.OrderQuantityNumericUpDown.ValueChanged += new EventHandler(orderQuantity_ValueChanged);

            orderItemForm.PlaceOrderButton.Tag = orderItem.Product.Id;
            orderItemForm.PlaceOrderButton.Text = "Add";
            orderItemForm.PlaceOrderButton.Click += new EventHandler(this.addButton_Click);

            orderItemForm.SpacerLabel.Width = 15;
            orderItemForm.ProductPanel.Controls.Add(orderItemForm.SpacerLabel);
            orderItemForm.ProductPanel.Controls.Add(orderItemForm.PlaceOrderButton);

                stockItemsFlowLayoutPanel.Controls.Add(orderItemForm.ProductPanel);
                displayedProducts.Add(orderItemForm);
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
               OrderItemForm clickedForm = OrderController.getClickedForm(id, displayedProducts);
               clickedForm.PlaceOrderButton.Enabled = false;
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
                    OrderItemForm clickedForm = OrderController.getClickedForm(parseInt, displayedProducts);
                    clickedForm.PlaceOrderButton.Enabled = true;
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
