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
using Poppel.Domain;
using Poppel.Report;

namespace Poppel
{
    public partial class MainForm : Form
    {
        private CreateCustomer createCustomer;
        private CustomerManagement customerMangement;
        private CustomerManangementController customerManangementController;
        private Employee employeeLoggedIn;
        private PickingList pickList;
        private ExpiredProducts expProducts;
        private bool loginClosed;

        public MainForm(Employee employee)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
           
            this.WindowState = FormWindowState.Maximized;
            customerManangementController = new CustomerManangementController();
            employeeLoggedIn = employee;
            loginClosed = false;
            loggedInAsLabel.BackColor = menuStrip1.BackColor;
            loggedInAsLabel.ForeColor = menuStrip1.ForeColor;
            loggedInAsLabel.Text = "Logged In As: " + employee.Name + " " + employee.Surname;
            customerManangementController.Employee = employee;
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginClosed)
            {
                Application.Exit();
            }
        }

        private void generatePickingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pickList = new PickingList();
            pickList.MdiParent = this;
            pickList.StartPosition = FormStartPosition.CenterScreen;
            pickList.Show();
        }

        private void generateExpiredProductsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expProducts = new ExpiredProducts();
            expProducts.MdiParent = this;
            expProducts.StartPosition = FormStartPosition.CenterScreen;
            expProducts.Show();
        }
    }
}
