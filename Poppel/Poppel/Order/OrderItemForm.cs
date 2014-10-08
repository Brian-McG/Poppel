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
using Poppel.Domain;
namespace Poppel.Order
{
    class OrderItemForm
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private FlowLayoutPanel productPanel;

        public FlowLayoutPanel ProductPanel
        {
            get { return productPanel; }
            set { productPanel = value; }
        }
        private Label pictureLabel = new Label();

        public Label PictureLabel
        {
            get { return pictureLabel; }
            set { pictureLabel = value; }
        }
        private Label productDescriptionLabel;

        public Label ProductDescriptionLabel
        {
            get { return productDescriptionLabel; }
            set { productDescriptionLabel = value; }
        }

        private Label numberInStockLabel = new Label();

        public Label NumberInStockLabel
        {
            get { return numberInStockLabel; }
            set { numberInStockLabel = value; }
        }
        private CheckBox similarFilterCheckBox;

        public CheckBox SimilarFilterCheckBox
        {
            get { return similarFilterCheckBox; }
            set { similarFilterCheckBox = value; }
        }
        private Label costLabel;

        public Label CostLabel
        {
            get { return costLabel; }
            set { costLabel = value; }
        }

        private Label quantityLabel;

        public Label QuantityLabel
        {
            get { return quantityLabel; }
            set { quantityLabel = value; }
        }
        private NumericUpDown orderQuantityNumericUpDown;

        public NumericUpDown OrderQuantityNumericUpDown
        {
            get { return orderQuantityNumericUpDown; }
            set { orderQuantityNumericUpDown = value; }
        }
        private Button placeOrderButton;

        public Button PlaceOrderButton
        {
            get { return placeOrderButton; }
            set { placeOrderButton = value; }
        }
        private Label spacerLabel;

        public Label SpacerLabel
        {
            get { return spacerLabel; }
            set { spacerLabel = value; }
        }

        public OrderItemForm()
        {
            productPanel = new FlowLayoutPanel();
            pictureLabel = new Label();
            productDescriptionLabel = new Label();
            numberInStockLabel = new Label();
            similarFilterCheckBox = new CheckBox();
            costLabel = new Label();
            quantityLabel = new Label();
            orderQuantityNumericUpDown = new NumericUpDown();
            placeOrderButton = new Button();
            spacerLabel = new Label();
        }

        #region Properties


        #endregion
    }
}
