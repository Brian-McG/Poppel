namespace Poppel.PresentationLayer
{
    partial class PickingList
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
            this.label1 = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.pickNumberLabel = new System.Windows.Forms.Label();
            this.pickNumLabel = new System.Windows.Forms.Label();
            this.delNumberLabel = new System.Windows.Forms.Label();
            this.delNumLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pickDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.productListView = new System.Windows.Forms.ListView();
            this.Rack_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Order_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelButton = new System.Windows.Forms.Button();
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.pickSignLabel = new System.Windows.Forms.Label();
            this.pickNameLabel = new System.Windows.Forms.Label();
            this.selectDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(255, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Picking List";
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(5, 68);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(167, 15);
            this.sloganLabel.TabIndex = 13;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(31, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // pickNumberLabel
            // 
            this.pickNumberLabel.AutoSize = true;
            this.pickNumberLabel.Location = new System.Drawing.Point(476, 13);
            this.pickNumberLabel.Name = "pickNumberLabel";
            this.pickNumberLabel.Size = new System.Drawing.Size(82, 13);
            this.pickNumberLabel.TabIndex = 15;
            this.pickNumberLabel.Text = "Picking Number";
            // 
            // pickNumLabel
            // 
            this.pickNumLabel.AutoSize = true;
            this.pickNumLabel.ForeColor = System.Drawing.Color.Red;
            this.pickNumLabel.Location = new System.Drawing.Point(564, 13);
            this.pickNumLabel.Name = "pickNumLabel";
            this.pickNumLabel.Size = new System.Drawing.Size(94, 13);
            this.pickNumLabel.TabIndex = 16;
            this.pickNumLabel.Text = "<Picking Number>";
            this.pickNumLabel.Visible = false;
            // 
            // delNumberLabel
            // 
            this.delNumberLabel.AutoSize = true;
            this.delNumberLabel.Location = new System.Drawing.Point(473, 42);
            this.delNumberLabel.Name = "delNumberLabel";
            this.delNumberLabel.Size = new System.Drawing.Size(85, 13);
            this.delNumberLabel.TabIndex = 17;
            this.delNumberLabel.Text = "Delivery Number";
            // 
            // delNumLabel
            // 
            this.delNumLabel.AutoSize = true;
            this.delNumLabel.ForeColor = System.Drawing.Color.Red;
            this.delNumLabel.Location = new System.Drawing.Point(564, 42);
            this.delNumLabel.Name = "delNumLabel";
            this.delNumLabel.Size = new System.Drawing.Size(97, 13);
            this.delNumLabel.TabIndex = 18;
            this.delNumLabel.Text = "<Delivery Number>";
            this.delNumLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.Red;
            this.dateLabel.Location = new System.Drawing.Point(299, 53);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 13);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "<Date>";
            this.dateLabel.Visible = false;
            // 
            // pickDateCalendar
            // 
            this.pickDateCalendar.Location = new System.Drawing.Point(228, 122);
            this.pickDateCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.pickDateCalendar.Name = "pickDateCalendar";
            this.pickDateCalendar.TabIndex = 20;
            this.pickDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.pickDateCalendar_DateChanged);
            // 
            // productListView
            // 
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rack_Number,
            this.Product_ID,
            this.Product_Name,
            this.Order_Number,
            this.Comments});
            this.productListView.Location = new System.Drawing.Point(11, 102);
            this.productListView.Margin = new System.Windows.Forms.Padding(2);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(719, 312);
            this.productListView.TabIndex = 21;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.Visible = false;
            // 
            // Rack_Number
            // 
            this.Rack_Number.Text = "Rack Number";
            // 
            // Product_ID
            // 
            this.Product_ID.Text = "productID";
            // 
            // Product_Name
            // 
            this.Product_Name.Text = "Product Name";
            // 
            // Order_Number
            // 
            this.Order_Number.Text = "Order Number";
            // 
            // Comments
            // 
            this.Comments.Text = "Comments";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(649, 486);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 40);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // pickDateLabel
            // 
            this.pickDateLabel.AutoSize = true;
            this.pickDateLabel.Location = new System.Drawing.Point(324, 500);
            this.pickDateLabel.Name = "pickDateLabel";
            this.pickDateLabel.Size = new System.Drawing.Size(156, 13);
            this.pickDateLabel.TabIndex = 31;
            this.pickDateLabel.Text = "Date        ..................................";
            this.pickDateLabel.Visible = false;
            // 
            // pickSignLabel
            // 
            this.pickSignLabel.AutoSize = true;
            this.pickSignLabel.Location = new System.Drawing.Point(269, 468);
            this.pickSignLabel.Name = "pickSignLabel";
            this.pickSignLabel.Size = new System.Drawing.Size(211, 13);
            this.pickSignLabel.TabIndex = 32;
            this.pickSignLabel.Text = "Picker Signature        ..................................";
            this.pickSignLabel.Visible = false;
            // 
            // pickNameLabel
            // 
            this.pickNameLabel.AutoSize = true;
            this.pickNameLabel.Location = new System.Drawing.Point(286, 440);
            this.pickNameLabel.Name = "pickNameLabel";
            this.pickNameLabel.Size = new System.Drawing.Size(194, 13);
            this.pickNameLabel.TabIndex = 34;
            this.pickNameLabel.Text = "Picker Name        ..................................";
            this.pickNameLabel.Visible = false;
            // 
            // selectDateLabel
            // 
            this.selectDateLabel.AutoSize = true;
            this.selectDateLabel.Location = new System.Drawing.Point(225, 102);
            this.selectDateLabel.Name = "selectDateLabel";
            this.selectDateLabel.Size = new System.Drawing.Size(66, 13);
            this.selectDateLabel.TabIndex = 35;
            this.selectDateLabel.Text = "Select Date:";
            // 
            // PickingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 539);
            this.Controls.Add(this.selectDateLabel);
            this.Controls.Add(this.pickDateCalendar);
            this.Controls.Add(this.pickNameLabel);
            this.Controls.Add(this.pickSignLabel);
            this.Controls.Add(this.pickDateLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.delNumLabel);
            this.Controls.Add(this.delNumberLabel);
            this.Controls.Add(this.pickNumLabel);
            this.Controls.Add(this.pickNumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "PickingList";
            this.Text = "Picking List";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label pickNumberLabel;
        private System.Windows.Forms.Label pickNumLabel;
        private System.Windows.Forms.Label delNumberLabel;
        private System.Windows.Forms.Label delNumLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MonthCalendar pickDateCalendar;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ColumnHeader Rack_Number;
        private System.Windows.Forms.ColumnHeader Product_ID;
        private System.Windows.Forms.ColumnHeader Product_Name;
        private System.Windows.Forms.ColumnHeader Order_Number;
        private System.Windows.Forms.ColumnHeader Comments;
        private System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.Label pickSignLabel;
        private System.Windows.Forms.Label pickNameLabel;
        private System.Windows.Forms.Label selectDateLabel;
    }
}