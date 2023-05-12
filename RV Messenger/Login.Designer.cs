namespace RV_Messenger
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameText = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordText = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usernameLabel.Location = new System.Drawing.Point(212, 246);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(279, 64);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // usernameText
            // 
            this.usernameText.AnimateReadOnly = false;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Depth = 0;
            this.usernameText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameText.LeadingIcon = null;
            this.usernameText.Location = new System.Drawing.Point(562, 260);
            this.usernameText.MaxLength = 50;
            this.usernameText.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameText.Multiline = false;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(393, 50);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "";
            this.usernameText.TrailingIcon = null;
            // 
            // passwordText
            // 
            this.passwordText.AnimateReadOnly = false;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Depth = 0;
            this.passwordText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordText.LeadingIcon = null;
            this.passwordText.Location = new System.Drawing.Point(562, 374);
            this.passwordText.MaxLength = 50;
            this.passwordText.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordText.Multiline = false;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(393, 50);
            this.passwordText.TabIndex = 3;
            this.passwordText.Text = "";
            this.passwordText.TrailingIcon = null;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordLabel.Location = new System.Drawing.Point(212, 360);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(264, 64);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.signInButton.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.signInButton.Location = new System.Drawing.Point(562, 498);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(159, 69);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Coral;
            this.registerButton.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.registerButton.Location = new System.Drawing.Point(796, 498);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(159, 69);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 734);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameLabel);
            this.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(6, 112, 6, 5);
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private MaterialSkin.Controls.MaterialTextBox usernameText;
        private MaterialSkin.Controls.MaterialTextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button registerButton;
    }
}

