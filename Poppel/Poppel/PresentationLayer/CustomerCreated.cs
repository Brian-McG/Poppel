using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel.CustomerMangement;

namespace Poppel.PresentationLayer
{
    public partial class CustomerCreated : Form
    {
        private CustomerManangementController customerController;
        public CustomerCreated(CustomerManangementController controller)
        {
            InitializeComponent();
            customerController = controller;
            customerNumberTextBox.Text = customerController.Customer.Id;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
