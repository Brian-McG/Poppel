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
            this.dateLabel = new System.Windows.Forms.Label();
            this.pickDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.productListView = new System.Windows.Forms.ListView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.pickSignLabel = new System.Windows.Forms.Label();
            this.pickNameLabel = new System.Windows.Forms.Label();
            this.selectDateLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.poppelLogo = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
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
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
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
            this.pickDateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.pickDateCalendar_DateSelected);
            // 
            // productListView
            // 
            this.productListView.Location = new System.Drawing.Point(11, 102);
            this.productListView.Margin = new System.Windows.Forms.Padding(2);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(719, 312);
            this.productListView.TabIndex = 21;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(567, 487);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 40);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(302, 70);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(40, 13);
            this.errorLabel.TabIndex = 36;
            this.errorLabel.Text = "<error>";
            this.errorLabel.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(655, 487);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 40);
            this.resetButton.TabIndex = 37;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // poppelLogo
            // 
            this.poppelLogo.Image = global::Poppel.Properties.Resources.poppelLogo;
            this.poppelLogo.Location = new System.Drawing.Point(12, 9);
            this.poppelLogo.Name = "poppelLogo";
            this.poppelLogo.Size = new System.Drawing.Size(100, 57);
            this.poppelLogo.TabIndex = 39;
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(12, 66);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(167, 15);
            this.sloganLabel.TabIndex = 38;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // PickingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 539);
            this.Controls.Add(this.poppelLogo);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.selectDateLabel);
            this.Controls.Add(this.pickDateCalendar);
            this.Controls.Add(this.pickNameLabel);
            this.Controls.Add(this.pickSignLabel);
            this.Controls.Add(this.pickDateLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Name = "PickingList";
            this.Text = "Picking List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MonthCalendar pickDateCalendar;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.Label pickSignLabel;
        private System.Windows.Forms.Label pickNameLabel;
        private System.Windows.Forms.Label selectDateLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label poppelLogo;
        private System.Windows.Forms.Label sloganLabel;
    }
}