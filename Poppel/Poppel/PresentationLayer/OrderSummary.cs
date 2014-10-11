using System;
using System.Collections.Generic;
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
    public partial class OrderSummary : Form
    {
        private Poppel.Order.Order order;
        public OrderSummary(Poppel.Order.Order order)
        {
            InitializeComponent();
        }
        private void setUpForm()
        {
            orderDate.Text = order.DateOrderPlaced.ToShortDateString();
            customer.Text = order.Customer.nameSurnameToString();

        }
    }
}
