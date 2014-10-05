using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel.PresentationLayer;
using Poppel.CustomerMangement;

namespace Poppel
{
    public partial class MainForm : Form
    {
        private CreateCustomer createCustomer;
        private CustomerManagement customerMangement;
        private Login login;
        private CustomerManangementController customerManangementController;

        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            customerManangementController = new CustomerManangementController();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createCustomer == null)
            {
                createCustomer = new CreateCustomer(customerManangementController);
                createCustomer.MdiParent = this;
                createCustomer.StartPosition = FormStartPosition.CenterScreen;
                createCustomer.Show();
            }
            else if(createCustomer.Visible == false)
            {
                createCustomer = new CreateCustomer(customerManangementController);
                createCustomer.MdiParent = this;
                createCustomer.StartPosition = FormStartPosition.CenterScreen;
                createCustomer.Show();
            }

        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerMangement == null)
            {
                customerMangement = new CustomerManagement(customerManangementController);
                customerMangement.MdiParent = this;
                customerMangement.StartPosition = FormStartPosition.CenterScreen;
                customerMangement.Show();
            }
            else if (customerMangement.Visible == false)
            {
                customerMangement = new CustomerManagement(customerManangementController);
                customerMangement.MdiParent = this;
                customerMangement.StartPosition = FormStartPosition.CenterScreen;
                customerMangement.Show();
            }
        }
    }
}
