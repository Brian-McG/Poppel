using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel.Report;
using Poppel.Order;
using System.Collections.ObjectModel;
using Poppel.Database;


namespace Poppel.PresentationLayer
{
    public partial class PickingList : Form
    {
        public PickingListReport pickReport;
        private Collection<OrderItem> products;
        private DateTime pickDate = DateTime.Now;
        public PickingList()
        {
            InitializeComponent();
            products = pickReport.productToBePicked;
            pickReport=new PickingListReport();
        }
        private void pickDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            pickDate=pickDateCalendar.SelectionRange.Start;
            dateLabel.Text = pickDate+"";
            pickNumberLabel.Visible = true;
            pickNameLabel.Visible = true;
            pickDateLabel.Visible = true;
            pickDateCalendar.Visible = false;
            delNumberLabel.Visible = true;
            pickSignLabel.Visible = true;
            selectDateLabel.Visible = false;
            productListView.Visible = true;
            populateForm();
        }

        private void populateForm()
        {
            ListViewItem itemDetails;
            PoppelDatabase pd = new PoppelDatabase();
            productListView.Columns.Insert(0, "Rack Number", 95, HorizontalAlignment.Left);
            productListView.Columns.Insert(1, "Product ID", 50, HorizontalAlignment.Left);
            productListView.Columns.Insert(2, "Product Name", 55, HorizontalAlignment.Left);
            productListView.Columns.Insert(3, "Quantity", 75, HorizontalAlignment.Left);
            productListView.Columns.Insert(4, "Order Number", 75, HorizontalAlignment.Left);
            productListView.Columns.Insert(5, "Comments", 50, HorizontalAlignment.Left);

            foreach (OrderItem item in products)
            {
                    itemDetails = new ListViewItem();
                    if (pickReport.getOrderDate(pickReport.getOrderNumber(item.Product.Id)).Equals(this.pickDate))
                    {
                        itemDetails.Text = pickReport.getRackNumber(item.Product.Id); ;
                        itemDetails.SubItems.Add(item.Product.Id+"");
                        itemDetails.SubItems.Add(item.Product.Description);
                        itemDetails.SubItems.Add(item.Quantity+"");
                        itemDetails.SubItems.Add(pickReport.getOrderNumber(item.Product.Id));
                        itemDetails.SubItems.Add("");
                        productListView.Items.Add(itemDetails);
                    }
            }
            productListView.Refresh();
            productListView.GridLines = true;
        }
    }
}
