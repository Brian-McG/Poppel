namespace Poppel.PresentationLayer
{
    partial class CreateDelivery
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.startTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endTimeComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.day1CheckBox = new System.Windows.Forms.CheckBox();
            this.day2CheckBox = new System.Windows.Forms.CheckBox();
            this.day3CheckBox = new System.Windows.Forms.CheckBox();
            this.day4CheckBox = new System.Windows.Forms.CheckBox();
            this.day5CheckBox = new System.Windows.Forms.CheckBox();
            this.deliveryErrorMessageLabel = new System.Windows.Forms.Label();
            this.deliveryWeekLabel = new System.Windows.Forms.Label();
            this.dateOfWeekOfDelivery = new System.Windows.Forms.Label();
            this.allowedDaysLabel = new System.Windows.Forms.Label();
            this.timeErrorLabel = new System.Windows.Forms.Label();
            this.poppelLogo = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(385, 350);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 40);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLabel.Location = new System.Drawing.Point(340, 38);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(100, 29);
            this.headerLabel.TabIndex = 32;
            this.headerLabel.Text = "Delivery";
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(166, 144);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryTimeLabel.TabIndex = 34;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // startTimeComboBox
            // 
            this.startTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeComboBox.FormattingEnabled = true;
            this.startTimeComboBox.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.startTimeComboBox.Location = new System.Drawing.Point(246, 141);
            this.startTimeComboBox.Name = "startTimeComboBox";
            this.startTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.startTimeComboBox.TabIndex = 35;
            this.startTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.startTimeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "to";
            // 
            // endTimeComboBox
            // 
            this.endTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endTimeComboBox.FormattingEnabled = true;
            this.endTimeComboBox.Location = new System.Drawing.Point(395, 141);
            this.endTimeComboBox.Name = "endTimeComboBox";
            this.endTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.endTimeComboBox.TabIndex = 37;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(472, 350);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 40);
            this.backButton.TabIndex = 38;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(559, 350);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(81, 40);
            this.nextButton.TabIndex = 39;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // day1CheckBox
            // 
            this.day1CheckBox.AutoSize = true;
            this.day1CheckBox.Location = new System.Drawing.Point(243, 211);
            this.day1CheckBox.Name = "day1CheckBox";
            this.day1CheckBox.Size = new System.Drawing.Size(64, 17);
            this.day1CheckBox.TabIndex = 40;
            this.day1CheckBox.Text = "Monday";
            this.day1CheckBox.UseVisualStyleBackColor = true;
            // 
            // day2CheckBox
            // 
            this.day2CheckBox.AutoSize = true;
            this.day2CheckBox.Location = new System.Drawing.Point(243, 234);
            this.day2CheckBox.Name = "day2CheckBox";
            this.day2CheckBox.Size = new System.Drawing.Size(67, 17);
            this.day2CheckBox.TabIndex = 42;
            this.day2CheckBox.Text = "Tuesday";
            this.day2CheckBox.UseVisualStyleBackColor = true;
            // 
            // day3CheckBox
            // 
            this.day3CheckBox.AutoSize = true;
            this.day3CheckBox.Location = new System.Drawing.Point(243, 257);
            this.day3CheckBox.Name = "day3CheckBox";
            this.day3CheckBox.Size = new System.Drawing.Size(83, 17);
            this.day3CheckBox.TabIndex = 43;
            this.day3CheckBox.Text = "Wednesday";
            this.day3CheckBox.UseVisualStyleBackColor = true;
            // 
            // day4CheckBox
            // 
            this.day4CheckBox.AutoSize = true;
            this.day4CheckBox.Location = new System.Drawing.Point(243, 280);
            this.day4CheckBox.Name = "day4CheckBox";
            this.day4CheckBox.Size = new System.Drawing.Size(70, 17);
            this.day4CheckBox.TabIndex = 44;
            this.day4CheckBox.Text = "Thursday";
            this.day4CheckBox.UseVisualStyleBackColor = true;
            // 
            // day5CheckBox
            // 
            this.day5CheckBox.AutoSize = true;
            this.day5CheckBox.Location = new System.Drawing.Point(243, 303);
            this.day5CheckBox.Name = "day5CheckBox";
            this.day5CheckBox.Size = new System.Drawing.Size(54, 17);
            this.day5CheckBox.TabIndex = 45;
            this.day5CheckBox.Text = "Friday";
            this.day5CheckBox.UseVisualStyleBackColor = true;
            // 
            // deliveryErrorMessageLabel
            // 
            this.deliveryErrorMessageLabel.AutoSize = true;
            this.deliveryErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.deliveryErrorMessageLabel.Location = new System.Drawing.Point(240, 323);
            this.deliveryErrorMessageLabel.Name = "deliveryErrorMessageLabel";
            this.deliveryErrorMessageLabel.Size = new System.Drawing.Size(70, 13);
            this.deliveryErrorMessageLabel.TabIndex = 46;
            this.deliveryErrorMessageLabel.Text = "<Error Label>";
            this.deliveryErrorMessageLabel.Visible = false;
            // 
            // deliveryWeekLabel
            // 
            this.deliveryWeekLabel.AutoSize = true;
            this.deliveryWeekLabel.Location = new System.Drawing.Point(163, 181);
            this.deliveryWeekLabel.Name = "deliveryWeekLabel";
            this.deliveryWeekLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryWeekLabel.TabIndex = 47;
            this.deliveryWeekLabel.Text = "Delivery Date:";
            // 
            // dateOfWeekOfDelivery
            // 
            this.dateOfWeekOfDelivery.AutoSize = true;
            this.dateOfWeekOfDelivery.Location = new System.Drawing.Point(243, 181);
            this.dateOfWeekOfDelivery.Name = "dateOfWeekOfDelivery";
            this.dateOfWeekOfDelivery.Size = new System.Drawing.Size(89, 13);
            this.dateOfWeekOfDelivery.TabIndex = 48;
            this.dateOfWeekOfDelivery.Text = "<Delivery Week>";
            this.dateOfWeekOfDelivery.Visible = false;
            // 
            // allowedDaysLabel
            // 
            this.allowedDaysLabel.AutoSize = true;
            this.allowedDaysLabel.Location = new System.Drawing.Point(163, 212);
            this.allowedDaysLabel.Name = "allowedDaysLabel";
            this.allowedDaysLabel.Size = new System.Drawing.Size(74, 13);
            this.allowedDaysLabel.TabIndex = 49;
            this.allowedDaysLabel.Text = "Allowed Days:";
            // 
            // timeErrorLabel
            // 
            this.timeErrorLabel.AutoSize = true;
            this.timeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.timeErrorLabel.Location = new System.Drawing.Point(243, 165);
            this.timeErrorLabel.Name = "timeErrorLabel";
            this.timeErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.timeErrorLabel.TabIndex = 50;
            this.timeErrorLabel.Text = "<Error Label>";
            this.timeErrorLabel.Visible = false;
            // 
            // poppelLogo
            // 
            this.poppelLogo.Image = global::Poppel.Properties.Resources.poppelLogo;
            this.poppelLogo.Location = new System.Drawing.Point(12, 9);
            this.poppelLogo.Name = "poppelLogo";
            this.poppelLogo.Size = new System.Drawing.Size(100, 57);
            this.poppelLogo.TabIndex = 52;
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(3, 77);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(167, 15);
            this.sloganLabel.TabIndex = 51;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // CreateDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 414);
            this.Controls.Add(this.poppelLogo);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.timeErrorLabel);
            this.Controls.Add(this.allowedDaysLabel);
            this.Controls.Add(this.dateOfWeekOfDelivery);
            this.Controls.Add(this.deliveryWeekLabel);
            this.Controls.Add(this.deliveryErrorMessageLabel);
            this.Controls.Add(this.day5CheckBox);
            this.Controls.Add(this.day4CheckBox);
            this.Controls.Add(this.day3CheckBox);
            this.Controls.Add(this.day2CheckBox);
            this.Controls.Add(this.day1CheckBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.endTimeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTimeComboBox);
            this.Controls.Add(this.deliveryTimeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.headerLabel);
            this.Name = "CreateDelivery";
            this.Text = "Delivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.ComboBox startTimeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox endTimeComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.CheckBox day1CheckBox;
        private System.Windows.Forms.CheckBox day2CheckBox;
        private System.Windows.Forms.CheckBox day3CheckBox;
        private System.Windows.Forms.CheckBox day4CheckBox;
        private System.Windows.Forms.CheckBox day5CheckBox;
        private System.Windows.Forms.Label deliveryErrorMessageLabel;
        private System.Windows.Forms.Label deliveryWeekLabel;
        private System.Windows.Forms.Label dateOfWeekOfDelivery;
        private System.Windows.Forms.Label allowedDaysLabel;
        private System.Windows.Forms.Label timeErrorLabel;
        private System.Windows.Forms.Label poppelLogo;
        private System.Windows.Forms.Label sloganLabel;
    }
}