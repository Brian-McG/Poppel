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
        public Collection<StockItem> products;
        public Collection<StockItem> Products
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
            this.Products = expiredController.getStock();
            InitializeComponent(); 
            productListView.View = View.Details;
            populateReport();
            dateLabel.Text = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
        }

        private void populateReport()
        {

            productListView.Clear();
            ListViewItem itemDetails;
            dateLabel.Visible = true;
            productListView.Columns.Insert(0, "Rack Number", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(1, "Number In Stock", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(2, "Expiry Date", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(3, "Product Ref", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(4, "Comments", 100, HorizontalAlignment.Left);

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
            this.Close();
        }
        
    }
}
