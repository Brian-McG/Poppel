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
using Poppel.Report;

namespace Poppel.Report
{
    public partial class ExpiredProducts : Form
    {
        public Collection<StockItem> products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }
        ExpiredProductReport expiredController = new ExpiredProductReport();
        public ExpiredProducts()
        {
            this.products = expiredController.getStock();
            InitializeComponent();
            populateReport();
            dateLabel.Text = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
        }

        private void populateReport()
        {

            productListView.Clear();
            ListViewItem itemDetails;

            productListView.Columns.Insert(0, "Rack Number", 95, HorizontalAlignment.Left);
            productListView.Columns.Insert(1, "Number In Stock", 55, HorizontalAlignment.Left);
            productListView.Columns.Insert(2, "Expiry Date", 75, HorizontalAlignment.Left);
            productListView.Columns.Insert(3, "Product Ref", 50, HorizontalAlignment.Left);
            productListView.Columns.Insert(4, "Comments", 50, HorizontalAlignment.Left);

            foreach (StockItem item in products)
            {
                    itemDetails = new ListViewItem();
                    itemDetails.Text = item.rackNumber;
                    itemDetails.SubItems.Add(item.numberInStock);
                    itemDetails.SubItems.Add(item.expiryDate);
                    itemDetails.SubItems.Add(item.productRef);
                    itemDetails.SubItems.Add("");
                    productListView.Items.Add(itemDetails);
            }

            productListView.Refresh();
            productListView.GridLines = true;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
        
    }
}
