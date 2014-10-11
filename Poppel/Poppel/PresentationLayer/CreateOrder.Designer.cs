namespace Poppel.PresentationLayer
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stockItemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterProductsLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.basketLabel = new System.Windows.Forms.Label();
            this.basketListView = new System.Windows.Forms.ListView();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.removeFromOrderButton = new System.Windows.Forms.Button();
            this.removeFiltersButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.creditRemainingLabel = new System.Windows.Forms.Label();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.creditRemainingTextBox = new System.Windows.Forms.TextBox();
            this.poppelDatabaseDataSet1 = new Poppel.PoppelDatabaseDataSet();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockItemsFlowLayoutPanel
            // 
            this.stockItemsFlowLayoutPanel.AutoScroll = true;
            this.stockItemsFlowLayoutPanel.Location = new System.Drawing.Point(12, 120);
            this.stockItemsFlowLayoutPanel.Name = "stockItemsFlowLayoutPanel";
            this.stockItemsFlowLayoutPanel.Size = new System.Drawing.Size(654, 774);
            this.stockItemsFlowLayoutPanel.TabIndex = 0;
            this.stockItemsFlowLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel_MouseClick);
            this.stockItemsFlowLayoutPanel.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            // 
            // filterProductsLabel
            // 
            this.filterProductsLabel.AutoSize = true;
            this.filterProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterProductsLabel.Location = new System.Drawing.Point(726, 120);
            this.filterProductsLabel.Name = "filterProductsLabel";
            this.filterProductsLabel.Size = new System.Drawing.Size(119, 20);
            this.filterProductsLabel.TabIndex = 1;
            this.filterProductsLabel.Text = "Filter Products";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLabel.Location = new System.Drawing.Point(340, 39);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(186, 29);
            this.headerLabel.TabIndex = 17;
            this.headerLabel.Text = "Create an Order";
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(13, 81);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(167, 15);
            this.sloganLabel.TabIndex = 16;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(39, 18);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoPictureBox.TabIndex = 15;
            this.logoPictureBox.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(671, 156);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(87, 13);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search by name:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(764, 153);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(135, 20);
            this.searchTextBox.TabIndex = 18;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketLabel.Location = new System.Drawing.Point(747, 246);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(61, 20);
            this.basketLabel.TabIndex = 19;
            this.basketLabel.Text = "Basket";
            // 
            // basketListView
            // 
            this.basketListView.Location = new System.Drawing.Point(671, 383);
            this.basketListView.MultiSelect = false;
            this.basketListView.Name = "basketListView";
            this.basketListView.Size = new System.Drawing.Size(228, 455);
            this.basketListView.TabIndex = 21;
            this.basketListView.UseCompatibleStateImageBehavior = false;
            this.basketListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.basketListView_ItemSelectionChanged);
            this.basketListView.Click += new System.EventHandler(this.basketListView_Click);
            this.basketListView.Leave += new System.EventHandler(this.basketListView_Leave);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(671, 187);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 22;
            this.categoryLabel.Text = "Category:";
            // 
            // checkOutButton
            // 
            this.checkOutButton.AutoSize = true;
            this.checkOutButton.Enabled = false;
            this.checkOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutButton.Location = new System.Drawing.Point(793, 844);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(106, 50);
            this.checkOutButton.TabIndex = 23;
            this.checkOutButton.Text = "Checkout";
            this.checkOutButton.UseVisualStyleBackColor = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(729, 184);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(170, 21);
            this.categoryComboBox.TabIndex = 24;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // removeFromOrderButton
            // 
            this.removeFromOrderButton.Enabled = false;
            this.removeFromOrderButton.Location = new System.Drawing.Point(721, 354);
            this.removeFromOrderButton.Name = "removeFromOrderButton";
            this.removeFromOrderButton.Size = new System.Drawing.Size(123, 23);
            this.removeFromOrderButton.TabIndex = 25;
            this.removeFromOrderButton.Text = "Remove from order";
            this.removeFromOrderButton.UseVisualStyleBackColor = true;
            this.removeFromOrderButton.Click += new System.EventHandler(this.removeFromOrderButton_Click);
            // 
            // removeFiltersButton
            // 
            this.removeFiltersButton.Location = new System.Drawing.Point(671, 211);
            this.removeFiltersButton.Name = "removeFiltersButton";
            this.removeFiltersButton.Size = new System.Drawing.Size(95, 23);
            this.removeFiltersButton.TabIndex = 26;
            this.removeFiltersButton.Text = "Remove Filters";
            this.removeFiltersButton.UseVisualStyleBackColor = true;
            this.removeFiltersButton.Click += new System.EventHandler(this.removeFiltersButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(703, 283);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostLabel.TabIndex = 27;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // creditRemainingLabel
            // 
            this.creditRemainingLabel.AutoSize = true;
            this.creditRemainingLabel.Location = new System.Drawing.Point(671, 308);
            this.creditRemainingLabel.Name = "creditRemainingLabel";
            this.creditRemainingLabel.Size = new System.Drawing.Size(90, 13);
            this.creditRemainingLabel.TabIndex = 28;
            this.creditRemainingLabel.Text = "Credit Remaining:";
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(764, 280);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(134, 20);
            this.totalCostTextBox.TabIndex = 29;
            this.totalCostTextBox.Text = "R 0.00";
            // 
            // creditRemainingTextBox
            // 
            this.creditRemainingTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.creditRemainingTextBox.Location = new System.Drawing.Point(764, 308);
            this.creditRemainingTextBox.Name = "creditRemainingTextBox";
            this.creditRemainingTextBox.ReadOnly = true;
            this.creditRemainingTextBox.Size = new System.Drawing.Size(134, 20);
            this.creditRemainingTextBox.TabIndex = 30;
            // 
            // poppelDatabaseDataSet1
            // 
            this.poppelDatabaseDataSet1.DataSetName = "PoppelDatabaseDataSet";
            this.poppelDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.AutoSize = true;
            this.cancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderButton.Location = new System.Drawing.Point(672, 844);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(113, 50);
            this.cancelOrderButton.TabIndex = 31;
            this.cancelOrderButton.Text = "Cancel";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(911, 906);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.creditRemainingTextBox);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.creditRemainingLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.removeFiltersButton);
            this.Controls.Add(this.removeFromOrderButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.basketListView);
            this.Controls.Add(this.basketLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.filterProductsLabel);
            this.Controls.Add(this.stockItemsFlowLayoutPanel);
            this.Name = "CreateOrder";
            this.Text = "Create an Order";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel stockItemsFlowLayoutPanel;
        private System.Windows.Forms.Label filterProductsLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.ListView basketListView;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button removeFromOrderButton;
        private System.Windows.Forms.Button removeFiltersButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label creditRemainingLabel;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.TextBox creditRemainingTextBox;
        private PoppelDatabaseDataSet poppelDatabaseDataSet1;
        private System.Windows.Forms.Button cancelOrderButton;
    }
}