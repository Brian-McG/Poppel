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
            this.cancelButton = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.ListView();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pickDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.resetButton = new System.Windows.Forms.Button();
            this.poppelLogo = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(592, 480);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 40);
            this.cancelButton.TabIndex = 46;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // productListView
            // 
            this.productListView.HoverSelection = true;
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
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
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
            // pickDateCalendar
            // 
            this.pickDateCalendar.Location = new System.Drawing.Point(263, 127);
            this.pickDateCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.pickDateCalendar.Name = "pickDateCalendar";
            this.pickDateCalendar.TabIndex = 47;
            this.pickDateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.pickDateCalendar_DateChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(679, 480);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(81, 40);
            this.resetButton.TabIndex = 48;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // poppelLogo
            // 
            this.poppelLogo.Image = global::Poppel.Properties.Resources.poppelLogo;
            this.poppelLogo.Location = new System.Drawing.Point(26, 9);
            this.poppelLogo.Name = "poppelLogo";
            this.poppelLogo.Size = new System.Drawing.Size(100, 57);
            this.poppelLogo.TabIndex = 50;
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(26, 66);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(167, 15);
            this.sloganLabel.TabIndex = 49;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // ExpiredProducts
            // 
            this.ClientSize = new System.Drawing.Size(772, 532);
            this.Controls.Add(this.poppelLogo);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pickDateCalendar);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Name = "ExpiredProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar pickDateCalendar;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label poppelLogo;
        private System.Windows.Forms.Label sloganLabel;
    }
}