namespace Poppel.PresentationLayer
{
    partial class CustomerCreated
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
            this.closeButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.CustomerNumberLabel = new System.Windows.Forms.Label();
            this.messageLabel2 = new System.Windows.Forms.Label();
            this.customerNumberTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(166, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customer Created";
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(1, 83);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(167, 15);
            this.sloganLabel.TabIndex = 13;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(27, 20);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(372, 254);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(81, 28);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(121, 131);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(153, 13);
            this.messageLabel.TabIndex = 16;
            this.messageLabel.Text = "Customer successfully created.";
            // 
            // CustomerNumberLabel
            // 
            this.CustomerNumberLabel.AutoSize = true;
            this.CustomerNumberLabel.Location = new System.Drawing.Point(24, 191);
            this.CustomerNumberLabel.Name = "CustomerNumberLabel";
            this.CustomerNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.CustomerNumberLabel.TabIndex = 17;
            this.CustomerNumberLabel.Text = "Customer Number:";
            // 
            // messageLabel2
            // 
            this.messageLabel2.AutoSize = true;
            this.messageLabel2.Location = new System.Drawing.Point(119, 153);
            this.messageLabel2.Name = "messageLabel2";
            this.messageLabel2.Size = new System.Drawing.Size(256, 13);
            this.messageLabel2.TabIndex = 18;
            this.messageLabel2.Text = "Please inform the customer of their customer number.";
            // 
            // customerNumberTextBox
            // 
            this.customerNumberTextBox.Location = new System.Drawing.Point(124, 188);
            this.customerNumberTextBox.Name = "customerNumberTextBox";
            this.customerNumberTextBox.ReadOnly = true;
            this.customerNumberTextBox.Size = new System.Drawing.Size(168, 20);
            this.customerNumberTextBox.TabIndex = 19;
            // 
            // CustomerCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 307);
            this.Controls.Add(this.customerNumberTextBox);
            this.Controls.Add(this.messageLabel2);
            this.Controls.Add(this.CustomerNumberLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "CustomerCreated";
            this.Text = "CustomerCreated";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label CustomerNumberLabel;
        private System.Windows.Forms.Label messageLabel2;
        private System.Windows.Forms.TextBox customerNumberTextBox;
    }
}