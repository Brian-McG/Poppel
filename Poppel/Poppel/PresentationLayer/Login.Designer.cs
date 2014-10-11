namespace Poppel.PresentationLayer
{
    partial class Login
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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.loginHeaderLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameTexBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(48, 39);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // loginHeaderLabel
            // 
            this.loginHeaderLabel.AutoSize = true;
            this.loginHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 35.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHeaderLabel.Location = new System.Drawing.Point(258, 39);
            this.loginHeaderLabel.Name = "loginHeaderLabel";
            this.loginHeaderLabel.Size = new System.Drawing.Size(173, 62);
            this.loginHeaderLabel.TabIndex = 1;
            this.loginHeaderLabel.Text = "Poppel";
            // 
            // forgotPasswordLinkLabel
            // 
            this.forgotPasswordLinkLabel.AutoSize = true;
            this.forgotPasswordLinkLabel.Location = new System.Drawing.Point(395, 297);
            this.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            this.forgotPasswordLinkLabel.Size = new System.Drawing.Size(88, 13);
            this.forgotPasswordLinkLabel.TabIndex = 2;
            this.forgotPasswordLinkLabel.TabStop = true;
            this.forgotPasswordLinkLabel.Text = "forgot password?";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(113, 187);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(113, 230);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(509, 282);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(92, 43);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTexBox
            // 
            this.usernameTexBox.Location = new System.Drawing.Point(177, 184);
            this.usernameTexBox.Name = "usernameTexBox";
            this.usernameTexBox.Size = new System.Drawing.Size(265, 20);
            this.usernameTexBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(177, 227);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(265, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Viner Hand ITC", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(22, 102);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(171, 19);
            this.sloganLabel.TabIndex = 8;
            this.sloganLabel.Text = "Adding sweetness to your life!";
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(174, 266);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(70, 13);
            this.loginErrorLabel.TabIndex = 36;
            this.loginErrorLabel.Text = "<Error Label>";
            this.loginErrorLabel.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 361);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTexBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.forgotPasswordLinkLabel);
            this.Controls.Add(this.loginHeaderLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label loginHeaderLabel;
        private System.Windows.Forms.LinkLabel forgotPasswordLinkLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTexBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label loginErrorLabel;
    }
}