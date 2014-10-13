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
        private Collection<ReportItem> products;
        private DateTime pickDate = DateTime.Now;
        public PickingList()
        {
            InitializeComponent();
            productListView.View = View.Details;
            pickReport = new PickingListReport();
            products = pickReport.getOrderProducts();

            
        }
        private void pickDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            pickDate=pickDateCalendar.SelectionRange.Start;
            dateLabel.Text = pickDate.Year+"-"+pickDate.Month+"-"+pickDate.Day;
            
            pickNameLabel.Visible = true;
            pickDateLabel.Visible = true;
            pickDateCalendar.Visible = false;
            pickSignLabel.Visible = true;
            selectDateLabel.Visible = false;
            productListView.Visible = true;
            populateForm();
        }

        private void populateForm()
        {
            dateLabel.Visible = true;
            ListViewItem itemDetails;
            PoppelDatabase pd = new PoppelDatabase();
            productListView.Columns.Insert(0, "Rack Number", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(1, "Product ID", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(2, "Product Name", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(3, "Quantity", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(4, "Order Number", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(5, "Comments", 100, HorizontalAlignment.Left);

            foreach (ReportItem item in products)
            {
                    itemDetails = new ListViewItem();
                    if (pickReport.getOrderDate(pickReport.getOrderNumber(item.productID)).Equals(this.pickDate))
                    {
                        itemDetails.Text = pickReport.getRackNumber(item.productID); ;
                        itemDetails.SubItems.Add(item.productID+"");
                        itemDetails.SubItems.Add(item.productID+"");
                        itemDetails.SubItems.Add(item.productID+"");
                        itemDetails.SubItems.Add(pickReport.getOrderNumber(item.productID));
                        itemDetails.SubItems.Add("");
                        productListView.Items.Add(itemDetails);
                    }
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
