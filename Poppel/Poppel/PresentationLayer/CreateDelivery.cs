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

namespace Poppel.PresentationLayer
{
    public partial class CreateDelivery : Form
    {
        //123
        private Poppel.Order.OrderController orderController;
        private CheckBox[] checkBoxes;
        public CreateDelivery(Poppel.Order.OrderController orderController)
        {
            InitializeComponent();
            startTimeComboBox.SelectedIndex = -1;
            endTimeComboBox.SelectedIndex = -1;
            DateTime deliveryDate = DateTime.Now;
            checkBoxes = new CheckBox[5];
            checkBoxes[0] = day1CheckBox;
            checkBoxes[1] = day2CheckBox;
            checkBoxes[2] = day3CheckBox;
            checkBoxes[3] = day4CheckBox;
            checkBoxes[4] = day5CheckBox;

                deliveryDate = deliveryDate.AddDays(1);
            if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                while (deliveryDate.DayOfWeek != DateTime.Now.DayOfWeek)
                {
                    deliveryDate = deliveryDate.AddDays(1);
                }
            }
            else
            {
                while (deliveryDate.DayOfWeek != DayOfWeek.Friday)
                {
                    deliveryDate = deliveryDate.AddDays(1);
                }
            }

            DateTime startTime = DateTime.Now.AddDays(1);
            DateTime temp = DateTime.Now.AddDays(1);
            if (startTime.DayOfWeek == DayOfWeek.Saturday)
            {
                startTime = startTime.AddDays(2);
                temp = temp.AddDays(2);
            }
            else if (startTime.DayOfWeek == DayOfWeek.Sunday)
            {
                startTime = startTime.AddDays(1);
                temp = temp.AddDays(1);
            }
            dateOfWeekOfDelivery.Text = startTime.ToShortDateString() + " to " + deliveryDate.ToShortDateString();
            dateOfWeekOfDelivery.Visible = true;
            day1CheckBox.Text = temp.DayOfWeek + " " + temp.ToShortDateString();
            day1CheckBox.Tag = temp.ToShortDateString();
            temp = temp.AddDays(1);
            if (temp.DayOfWeek == DayOfWeek.Saturday)
            {
                temp = temp.AddDays(2);
            }
            else if (temp.DayOfWeek == DayOfWeek.Sunday)
            {
                temp = temp.AddDays(1);
            }
            day2CheckBox.Text = temp.DayOfWeek + " " + temp.ToShortDateString();
            day2CheckBox.Tag = temp.ToShortDateString();
            temp = temp.AddDays(1);
            if (temp.DayOfWeek == DayOfWeek.Saturday)
            {
                temp = temp.AddDays(2);
            }
            else if (temp.DayOfWeek == DayOfWeek.Sunday)
            {
                temp = temp.AddDays(1);
            }
            day3CheckBox.Text = temp.DayOfWeek + " " + temp.ToShortDateString();
            day3CheckBox.Tag = temp.ToShortDateString();
            temp = temp.AddDays(1);
            if (temp.DayOfWeek == DayOfWeek.Saturday)
            {
                temp = temp.AddDays(2);
            }
            else if (temp.DayOfWeek == DayOfWeek.Sunday)
            {
                temp = temp.AddDays(1);
            }
            day4CheckBox.Text = temp.DayOfWeek + " " + temp.ToShortDateString();
            day4CheckBox.Tag = temp.ToShortDateString();
            temp = temp.AddDays(1);
            if (temp.DayOfWeek == DayOfWeek.Saturday)
            {
                temp = temp.AddDays(2);
            }
            else if (temp.DayOfWeek == DayOfWeek.Sunday)
            {
                temp = temp.AddDays(1);
            }
            day5CheckBox.Text = temp.DayOfWeek + " " + temp.ToShortDateString();
            day5CheckBox.Tag = temp.ToShortDateString();

            for (int i = 1; i < startTimeComboBox.Items.Count; i++)
            {
                endTimeComboBox.Items.Add(startTimeComboBox.Items[i]);
            }
            object add = "17:00";
            endTimeComboBox.Items.Add(add);

            this.orderController = orderController;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            deliveryErrorMessageLabel.Visible = false;
            timeErrorLabel.Visible = false;
            bool correct = true;
            if (!day1CheckBox.Checked && !day2CheckBox.Checked && !day3CheckBox.Checked && !day4CheckBox.Checked && !day5CheckBox.Checked)
            {
                deliveryErrorMessageLabel.Text = "At least one delivery day needs to be selected.";
                deliveryErrorMessageLabel.Visible = true;
                correct = false;
            }
            if (startTimeComboBox.SelectedIndex == -1 || endTimeComboBox.SelectedIndex == -1)
            {
                timeErrorLabel.Text = "The delivery time needs to be specified.";
                timeErrorLabel.Visible = true;
                correct = false;
            }
            if (correct)
            {
                addDeliveryDetailsToOrder();
                OrderSummary orderSummary = new OrderSummary(orderController);
                orderSummary.MdiParent = this.MdiParent;
                orderSummary.StartPosition = FormStartPosition.CenterScreen;
                this.Close();
                orderSummary.Show();
            }
        }

        private void addDeliveryDetailsToOrder()
        {
            orderController.Order.DeliveryDetails = new Poppel.Order.Delivery();
            orderController.Order.DeliveryDetails.AllowedDeliveryDates = new Collection<DateTime>();
            DateTime temp;
            if (day1CheckBox.Checked)
            {
                if (DateTime.TryParse(day1CheckBox.Tag.ToString(), out temp))
                {
                    orderController.Order.DeliveryDetails.AllowedDeliveryDates.Add(temp);
                }
            }
            if (day2CheckBox.Checked)
            {
                if (DateTime.TryParse(day2CheckBox.Tag.ToString(), out temp))
                {
                    orderController.Order.DeliveryDetails.AllowedDeliveryDates.Add(temp);
                }
            }
            if (day3CheckBox.Checked)
            {
                if (DateTime.TryParse(day3CheckBox.Tag.ToString(), out temp))
                {
                    orderController.Order.DeliveryDetails.AllowedDeliveryDates.Add(temp);
                }
            }
            if (day4CheckBox.Checked)
            {
                if (DateTime.TryParse(day4CheckBox.Tag.ToString(), out temp))
                {
                    orderController.Order.DeliveryDetails.AllowedDeliveryDates.Add(temp);
                }
            }
            if (day5CheckBox.Checked)
            {
                if (DateTime.TryParse(day5CheckBox.Tag.ToString(), out temp))
                {
                    orderController.Order.DeliveryDetails.AllowedDeliveryDates.Add(temp);
                }
            }

            if (DateTime.TryParse(startTimeComboBox.SelectedItem.ToString(), out temp))
            {
                orderController.Order.DeliveryDetails.StartDeliveryTime = temp;
            }
            if (DateTime.TryParse(endTimeComboBox.SelectedItem.ToString(), out temp))
            {
                orderController.Order.DeliveryDetails.EndDeliveryTime = temp;
            }


        }

        public void setDropDownlists(object start, object end)
        {
            startTimeComboBox.SelectedItem = start;
            endTimeComboBox.SelectedItem = end;
        }

        public void setCheckBoxes(Collection<DateTime> deliveryDates)
        {
            DateTime current = DateTime.Now;
           
            for (int i = 0; i < deliveryDates.Count;i++ )
            {
                int index = 0;
                while (current.ToShortDateString().Equals(deliveryDates[i].ToShortDateString())&&index<10)
                {
                    current = current.AddDays(1);
                    index++;

                }
                checkBoxes[index].Checked = true;

            }



        }

        private void startTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            object selectedValue = endTimeComboBox.SelectedItem;
            endTimeComboBox.Items.Clear();
            for (int i = startTimeComboBox.SelectedIndex + 1; i < startTimeComboBox.Items.Count; i++)
            {
                endTimeComboBox.Items.Add(startTimeComboBox.Items[i]);
            }
            object add = "17:00";
            endTimeComboBox.Items.Add(add);

            bool found = false;
            int index = 0;
            while (!found && index < endTimeComboBox.Items.Count)
            {
                object test = endTimeComboBox.Items[index];
                if (endTimeComboBox.Items[index].Equals(selectedValue))
                {
                    found = true;
                    endTimeComboBox.SelectedItem = selectedValue;
                }
                index++;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancel Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Back Button Broken
            CreateOrder create = new CreateOrder(orderController);
            //create.Show();
            orderController.Order = new Order.Order();
            orderController.OrderItems = null;
            orderController.AllProducts = null;
            orderController.DisplayedProducts = null;
            create.MdiParent = this.MdiParent;
            create.StartPosition = FormStartPosition.CenterScreen;
            this.Close();


        }
    }
}
