namespace Poppel.PresentationLayer
{
    partial class OrderSummary
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
            this.orderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.employee = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.orderTotalTextBox = new System.Windows.Forms.TextBox();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.shoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.deliveryGroupBox = new System.Windows.Forms.GroupBox();
            this.DateDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDaysTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.deliveryTimeEnd = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.deliveryTimeStart = new System.Windows.Forms.Label();
            this.allowedDeliveryDaysLabel = new System.Windows.Forms.Label();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.orderInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.shoppingCartGroupBox.SuspendLayout();
            this.deliveryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderInfoGroupBox
            // 
            this.orderInfoGroupBox.Controls.Add(this.employee);
            this.orderInfoGroupBox.Controls.Add(this.employeeLabel);
            this.orderInfoGroupBox.Controls.Add(this.orderTotalTextBox);
            this.orderInfoGroupBox.Controls.Add(this.orderTotalLabel);
            this.orderInfoGroupBox.Controls.Add(this.customer);
            this.orderInfoGroupBox.Controls.Add(this.orderDate);
            this.orderInfoGroupBox.Controls.Add(this.orderDateLabel);
            this.orderInfoGroupBox.Controls.Add(this.customerLabel);
            this.orderInfoGroupBox.Location = new System.Drawing.Point(12, 121);
            this.orderInfoGroupBox.Name = "orderInfoGroupBox";
            this.orderInfoGroupBox.Size = new System.Drawing.Size(385, 199);
            this.orderInfoGroupBox.TabIndex = 0;
            this.orderInfoGroupBox.TabStop = false;
            this.orderInfoGroupBox.Text = "Order Information";
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.Location = new System.Drawing.Point(102, 45);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(98, 13);
            this.employee.TabIndex = 11;
            this.employee.Text = "<Sales Consultant>";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(3, 45);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(89, 13);
            this.employeeLabel.TabIndex = 10;
            this.employeeLabel.Text = "Sales Consultant:";
            // 
            // orderTotalTextBox
            // 
            this.orderTotalTextBox.Location = new System.Drawing.Point(105, 101);
            this.orderTotalTextBox.Name = "orderTotalTextBox";
            this.orderTotalTextBox.Size = new System.Drawing.Size(85, 20);
            this.orderTotalTextBox.TabIndex = 90;
            this.orderTotalTextBox.TabStop = false;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(29, 104);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.orderTotalLabel.TabIndex = 8;
            this.orderTotalLabel.Text = "Order Total:";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(102, 20);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(63, 13);
            this.customer.TabIndex = 6;
            this.customer.Text = "<Customer>";
            // 
            // orderDate
            // 
            this.orderDate.AutoSize = true;
            this.orderDate.Location = new System.Drawing.Point(102, 75);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(71, 13);
            this.orderDate.TabIndex = 5;
            this.orderDate.Text = "<Order Date>";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(30, 75);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(62, 13);
            this.orderDateLabel.TabIndex = 2;
            this.orderDateLabel.Text = "Order Date:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(39, 20);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(54, 13);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLabel.Location = new System.Drawing.Point(322, 33);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(183, 29);
            this.headerLabel.TabIndex = 35;
            this.headerLabel.Text = "Order Summary";
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(20, 75);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(167, 15);
            this.sloganLabel.TabIndex = 34;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(46, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoPictureBox.TabIndex = 33;
            this.logoPictureBox.TabStop = false;
            // 
            // shoppingCartGroupBox
            // 
            this.shoppingCartGroupBox.Controls.Add(this.OrderListView);
            this.shoppingCartGroupBox.Location = new System.Drawing.Point(12, 326);
            this.shoppingCartGroupBox.Name = "shoppingCartGroupBox";
            this.shoppingCartGroupBox.Size = new System.Drawing.Size(774, 233);
            this.shoppingCartGroupBox.TabIndex = 36;
            this.shoppingCartGroupBox.TabStop = false;
            this.shoppingCartGroupBox.Text = "Shopping Cart";
            // 
            // OrderListView
            // 
            this.OrderListView.Location = new System.Drawing.Point(6, 19);
            this.OrderListView.MultiSelect = false;
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(762, 208);
            this.OrderListView.TabIndex = 22;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            // 
            // deliveryGroupBox
            // 
            this.deliveryGroupBox.Controls.Add(this.DateDeliveryTextBox);
            this.deliveryGroupBox.Controls.Add(this.deliveryDaysTextBox);
            this.deliveryGroupBox.Controls.Add(this.addressTextBox);
            this.deliveryGroupBox.Controls.Add(this.addressLabel);
            this.deliveryGroupBox.Controls.Add(this.deliveryTimeEnd);
            this.deliveryGroupBox.Controls.Add(this.label17);
            this.deliveryGroupBox.Controls.Add(this.deliveryTimeStart);
            this.deliveryGroupBox.Controls.Add(this.allowedDeliveryDaysLabel);
            this.deliveryGroupBox.Controls.Add(this.deliveryTimeLabel);
            this.deliveryGroupBox.Location = new System.Drawing.Point(403, 121);
            this.deliveryGroupBox.Name = "deliveryGroupBox";
            this.deliveryGroupBox.Size = new System.Drawing.Size(383, 199);
            this.deliveryGroupBox.TabIndex = 8;
            this.deliveryGroupBox.TabStop = false;
            this.deliveryGroupBox.Text = "Delivery";
            // 
            // DateDeliveryTextBox
            // 
            this.DateDeliveryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DateDeliveryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateDeliveryTextBox.Location = new System.Drawing.Point(186, 45);
            this.DateDeliveryTextBox.Multiline = true;
            this.DateDeliveryTextBox.Name = "DateDeliveryTextBox";
            this.DateDeliveryTextBox.Size = new System.Drawing.Size(98, 66);
            this.DateDeliveryTextBox.TabIndex = 14;
            this.DateDeliveryTextBox.TabStop = false;
            // 
            // deliveryDaysTextBox
            // 
            this.deliveryDaysTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.deliveryDaysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveryDaysTextBox.Location = new System.Drawing.Point(128, 45);
            this.deliveryDaysTextBox.Multiline = true;
            this.deliveryDaysTextBox.Name = "deliveryDaysTextBox";
            this.deliveryDaysTextBox.Size = new System.Drawing.Size(75, 66);
            this.deliveryDaysTextBox.TabIndex = 13;
            this.deliveryDaysTextBox.TabStop = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Location = new System.Drawing.Point(128, 117);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(239, 76);
            this.addressTextBox.TabIndex = 12;
            this.addressTextBox.TabStop = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(74, 117);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address:";
            // 
            // deliveryTimeEnd
            // 
            this.deliveryTimeEnd.AutoSize = true;
            this.deliveryTimeEnd.Location = new System.Drawing.Point(209, 20);
            this.deliveryTimeEnd.Name = "deliveryTimeEnd";
            this.deliveryTimeEnd.Size = new System.Drawing.Size(53, 13);
            this.deliveryTimeEnd.TabIndex = 9;
            this.deliveryTimeEnd.Text = "00:00 AM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(187, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "to";
            // 
            // deliveryTimeStart
            // 
            this.deliveryTimeStart.AutoSize = true;
            this.deliveryTimeStart.Location = new System.Drawing.Point(128, 20);
            this.deliveryTimeStart.Name = "deliveryTimeStart";
            this.deliveryTimeStart.Size = new System.Drawing.Size(53, 13);
            this.deliveryTimeStart.TabIndex = 7;
            this.deliveryTimeStart.Text = "02:00 PM";
            // 
            // allowedDeliveryDaysLabel
            // 
            this.allowedDeliveryDaysLabel.AutoSize = true;
            this.allowedDeliveryDaysLabel.Location = new System.Drawing.Point(7, 45);
            this.allowedDeliveryDaysLabel.Name = "allowedDeliveryDaysLabel";
            this.allowedDeliveryDaysLabel.Size = new System.Drawing.Size(115, 13);
            this.allowedDeliveryDaysLabel.TabIndex = 1;
            this.allowedDeliveryDaysLabel.Text = "Allowed Delivery Days:";
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(48, 20);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryTimeLabel.TabIndex = 0;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(686, 565);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 30);
            this.confirm.TabIndex = 37;
            this.confirm.Text = "Confirm Order";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(596, 565);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 30);
            this.backButton.TabIndex = 38;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(505, 565);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 30);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 607);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.deliveryGroupBox);
            this.Controls.Add(this.shoppingCartGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.orderInfoGroupBox);
            this.Name = "OrderSummary";
            this.Text = "Order Summary";
            this.orderInfoGroupBox.ResumeLayout(false);
            this.orderInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.shoppingCartGroupBox.ResumeLayout(false);
            this.deliveryGroupBox.ResumeLayout(false);
            this.deliveryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox orderInfoGroupBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label orderDate;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.GroupBox shoppingCartGroupBox;
        private System.Windows.Forms.GroupBox deliveryGroupBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label deliveryTimeEnd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label deliveryTimeStart;
        private System.Windows.Forms.Label allowedDeliveryDaysLabel;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox orderTotalTextBox;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox deliveryDaysTextBox;
        private System.Windows.Forms.TextBox DateDeliveryTextBox;
    }
}