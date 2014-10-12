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





        public CreateOrder(OrderController orderController)
        {
            InitializeComponent();
            this.orderController = orderController;
            setUpForm();

           
        }

        private void setUpForm()
        {
            products = orderController.getProducts();

            orderController.DisplayedProducts = new Collection<OrderItemForm>();
            setUpEmployeeListView();
            setUpOrderFlowPanel();
            basketListView.View = View.Details;
            Collection<Category> categories = orderController.getCategories();
            categoryComboBox.Items.Add("All");
            categoryComboBox.SelectedIndex = 0;
            foreach (Category category in categories)
            {
                categoryComboBox.Items.Add(category);
            }
        }

        private void setUpOrderFlowPanel()
        {
            foreach (OrderItem orderItem in products)
            {

                OrderItemForm orderItemForm = new OrderItemForm(orderItem);
                orderItemForm.SimilarFilterCheckBox.CheckedChanged += new EventHandler(setAlternativesCheckBox_Checked);
                orderItemForm.OrderQuantityNumericUpDown.ValueChanged += new EventHandler(orderQuantity_ValueChanged);
                orderItemForm.PlaceOrderButton.Click += new EventHandler(this.addButton_Click);
                stockItemsFlowLayoutPanel.Controls.Add(orderItemForm.ProductPanel);
                orderController.DisplayedProducts.Add(orderItemForm);
                orderController.AllProducts.Add(orderItemForm);
            }
        }


        public void setUpEmployeeListView()
        {



            //Clear current List View Control
            basketListView.Clear();

            //Set Up Columns of List View
            basketListView.Columns.Insert(0, "Product", 95, HorizontalAlignment.Left);
            basketListView.Columns.Insert(1, "Quantity", 55, HorizontalAlignment.Left);
            basketListView.Columns.Insert(2, "Cost", 75, HorizontalAlignment.Left);
            basketListView.Columns.Insert(3, "", 0, HorizontalAlignment.Left);

            //Add employee details to each ListView item 



            basketListView.Refresh();
            basketListView.GridLines = true;

        }

        public void addToOrder(OrderItem orderItem)
        {
            ListViewItem orderItemDetails;
            orderItemDetails = new ListViewItem();
            orderItemDetails.Text = "" + orderItem.Product.Description;
            orderItemDetails.SubItems.Add("" + orderItem.Quantity);
            orderItemDetails.SubItems.Add("R " + string.Format("{0:0.00}", (orderItem.Quantity * orderItem.Product.Price)));
            orderItemDetails.SubItems[0].Tag = orderItem.Product.Id;
            basketListView.Items.Add(orderItemDetails);

            orderController.OrderItems.Add(orderItem);
            checkOutButton.Enabled = true;

            orderController.OrderTotal += (orderItem.Quantity * orderItem.Product.Price);
            totalCostTextBox.Text = "R " + string.Format("{0:0.00}", (orderController.OrderTotal));

        }

        #region Events
        private void orderQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown quantityUpDown = (NumericUpDown)sender;
            int id = -1;
            if (int.TryParse(quantityUpDown.Tag.ToString(), out id))
            {
                OrderController.getProduct(id, products).Quantity = decimal.ToInt32(quantityUpDown.Value);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int id = -1;
            if (int.TryParse(clickedButton.Tag.ToString(), out id))
            {
                addToOrder(OrderController.getProduct(id, products));
                OrderItemForm clickedForm = OrderController.getClickedForm(id, orderController.DisplayedProducts);
                clickedForm.PlaceOrderButton.Text = "Remove";
                clickedForm.PlaceOrderButton.Click -= addButton_Click;
                clickedForm.PlaceOrderButton.Click += removeButton_Click;
                clickedForm.OrderQuantityNumericUpDown.Enabled = false;
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item from the order?", "Confirm Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Button clickedButton = (Button)sender;
                int id = -1;
                if (int.TryParse(clickedButton.Tag.ToString(), out id))
                {
                    removedButtonClicked(id);
                }
            }
        }
        private void removedButtonClicked(int id)
        {
            removeFromOrder(id);
            OrderItemForm clickedForm = OrderController.getClickedForm(id, orderController.DisplayedProducts);
            clickedForm.PlaceOrderButton.Text = "Add";
            clickedForm.PlaceOrderButton.Click -= removeButton_Click;
            clickedForm.PlaceOrderButton.Click += addButton_Click;
        }

        private void flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            //   stockItemsFlowLayoutPanel.Focus();
        }

        private void flowLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            stockItemsFlowLayoutPanel.Focus();
        }

        private void basketListView_Click(object sender, EventArgs e)
        {
            removeFromOrderButton.Enabled = true;

        }

        private void basketListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (basketListView.SelectedItems.Count == 0)
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
            searchTextBox.Text = "";
            categoryComboBox.SelectedIndex = 0;
            stockItemsFlowLayoutPanel.Controls.Clear();
            foreach (OrderItemForm orderItemForm in orderController.DisplayedProducts)
            {
                stockItemsFlowLayoutPanel.Controls.Add(orderItemForm.ProductPanel);
            }
        }

        private void removeFromOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item from the order?", "Confirm Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int parseInt = -1;
                if (int.TryParse(basketListView.SelectedItems[0].SubItems[0].Tag.ToString(), out parseInt))
                {
                    int index = 0;
                    bool changed = false;
                    while (index < orderController.AllProducts.Count && !changed)
                    {
                        if (orderController.AllProducts[index].RefOrderItem.Product.Id == parseInt)
                        {
                            OrderItemForm form = orderController.AllProducts[index];
                            form.PlaceOrderButton.Text = "Add";
                            form.PlaceOrderButton.Click -= removeButton_Click;
                            form.PlaceOrderButton.Click += addButton_Click;
                        }
                        index++;
                    }
                    removeFromOrder(parseInt);



                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }





        }
        private void removeFromOrder(int parseInt)
        {
            OrderItem removalItem = OrderController.getProduct(parseInt, products);
            OrderItemForm removeForm = OrderController.getClickedForm(parseInt, orderController.DisplayedProducts);
            orderController.OrderItems.Remove(removalItem);
            int index = 0;
            for (int i = 0; i < basketListView.Items.Count; i++)
            {
                if (int.TryParse(basketListView.Items[i].SubItems[0].Tag.ToString(), out index))
                {
                    if (index == parseInt)
                    {
                        basketListView.Items.Remove(basketListView.Items[i]);
                        break;
                    }
                }
            }
            orderController.OrderTotal -= (removalItem.Product.Price * removalItem.Quantity);
            totalCostTextBox.Text = "R " + string.Format("{0:0.00}", (orderController.OrderTotal));
            OrderItemForm clickedForm = OrderController.getClickedForm(parseInt, orderController.DisplayedProducts);
            clickedForm.PlaceOrderButton.Enabled = true;
            if (orderController.OrderItems.Count == 0)
            {
                checkOutButton.Enabled = false;
            }
            removeForm.OrderQuantityNumericUpDown.Enabled = true;
        }

        private void setAlternativesCheckBox_Checked(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                int id = -1;
                if (int.TryParse(checkBox.Tag.ToString(), out id))
                {
                    orderController.setAlternatives(id);
                    stockItemsFlowLayoutPanel.Controls.Clear();
                    foreach (OrderItemForm orderItemForm in orderController.DisplayedProducts)
                    {
                        stockItemsFlowLayoutPanel.Controls.Add(orderItemForm.ProductPanel);
                    }
                }
            }
            else
            {
                int id = -1;
                if (int.TryParse(checkBox.Tag.ToString(), out id))
                {
                    orderController.unSetAlternatives(id);
                    stockItemsFlowLayoutPanel.Controls.Clear();
                    foreach (OrderItemForm orderItemForm in orderController.DisplayedProducts)
                    {
                        stockItemsFlowLayoutPanel.Controls.Add(orderItemForm.ProductPanel);
                    }
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            stockItemsFlowLayoutPanel.Controls.Clear();
            foreach (OrderItemForm orderItemForm in orderController.DisplayedProducts)
            {
                if (orderItemForm.ProductDescriptionLabel.Text.ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    stockItemsFlowLayoutPanel.Controls.Add(orderItemForm.ProductPanel);

                }
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderController.setCategory(categoryComboBox.Text);
            stockItemsFlowLayoutPanel.Controls.Clear();
            foreach (OrderItemForm orderItemForm in orderController.DisplayedProducts)
            {
                stockItemsFlowLayoutPanel.Controls.Add(orderItemForm.ProductPanel);
            }
        }
        #endregion

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            orderController.checkOut();
            CreateDelivery createDelivery = new CreateDelivery(orderController);
            createDelivery.MdiParent = this.MdiParent;
            createDelivery.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
            createDelivery.Show();
        }
    }

}
