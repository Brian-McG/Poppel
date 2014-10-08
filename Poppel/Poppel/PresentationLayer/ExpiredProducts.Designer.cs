namespace Poppel.Report
{
    partial class ExpiredProducts
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
            this.Comments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Order_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rack_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelButton = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.ListView();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Comments
            // 
            this.Comments.Text = "Comments";
            // 
            // Order_Number
            // 
            this.Order_Number.Text = "Order Number";
            // 
            // Product_Name
            // 
            this.Product_Name.Text = "Product Name";
            // 
            // Product_ID
            // 
            this.Product_ID.Text = "productID";
            // 
            // Rack_Number
            // 
            this.Rack_Number.Text = "Rack Number";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(618, 480);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 40);
            this.cancelButton.TabIndex = 46;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // productListView
            // 
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rack_Number,
            this.Product_ID,
            this.Product_Name,
            this.Order_Number,
            this.Comments});
            this.productListView.Location = new System.Drawing.Point(29, 107);
            this.productListView.Margin = new System.Windows.Forms.Padding(2);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(719, 312);
            this.productListView.TabIndex = 45;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.Red;
            this.dateLabel.Location = new System.Drawing.Point(357, 49);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 13);
            this.dateLabel.TabIndex = 43;
            this.dateLabel.Text = "<Date>";
            this.dateLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(279, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Expired Products";
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(12, 75);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(167, 15);
            this.sloganLabel.TabIndex = 37;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(38, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoPictureBox.TabIndex = 36;
            this.logoPictureBox.TabStop = false;
            // 
            // ExpiredProducts
            // 
            this.ClientSize = new System.Drawing.Size(772, 532);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "ExpiredProducts";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Comments;
        private System.Windows.Forms.ColumnHeader Order_Number;
        private System.Windows.Forms.ColumnHeader Product_Name;
        private System.Windows.Forms.ColumnHeader Product_ID;
        private System.Windows.Forms.ColumnHeader Rack_Number;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}