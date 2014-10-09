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


namespace Poppel.PresentationLayer
{
    public partial class PickingList : Form
    {
        public PickingListReport pickReport = new PickingListReport();
        private Collection<OrderItem> products;
        private DateTime pickDate = DateTime.Now;
        public PickingList()
        {
            InitializeComponent();
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

            products = pickReport.productToBePicked;
            ListViewItem itemDetails;
            
            foreach (OrderItem item in products)
            {
                if(pickDate==pickDate){// NEED date variable for item so can filter
                    itemDetails = new ListViewItem();
                    itemDetails.Text = item.Product.Description;// need rack number
                    itemDetails.SubItems.Add(item.Product.Id+"");
                    itemDetails.SubItems.Add(item.Product.Description);
                    itemDetails.SubItems.Add(item.Quantity+"");
                    itemDetails.SubItems.Add(item.Product.Description);// need order number
                    itemDetails.SubItems.Add("");

                    productListView.Items.Add(itemDetails);
                }
            }
            productListView.Refresh();
            productListView.GridLines = true;
        }
    }
}
