namespace RV_Messenger
{
    partial class Register
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
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordText = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameText = new MaterialSkin.Controls.MaterialTextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.confirmPasswordText = new MaterialSkin.Controls.MaterialTextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Coral;
            this.registerButton.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.registerButton.Location = new System.Drawing.Point(745, 566);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(159, 69);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.AnimateReadOnly = false;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Depth = 0;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordText.LeadingIcon = null;
            this.passwordText.Location = new System.Drawing.Point(637, 323);
            this.passwordText.MaxLength = 50;
            this.passwordText.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordText.Multiline = false;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(393, 50);
            this.passwordText.TabIndex = 9;
            this.passwordText.Text = "";
            this.passwordText.TrailingIcon = null;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordLabel.Location = new System.Drawing.Point(287, 309);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(264, 64);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.AnimateReadOnly = false;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Depth = 0;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameText.LeadingIcon = null;
            this.usernameText.Location = new System.Drawing.Point(637, 209);
            this.usernameText.MaxLength = 50;
            this.usernameText.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameText.Multiline = false;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(393, 50);
            this.usernameText.TabIndex = 7;
            this.usernameText.Text = "";
            this.usernameText.TrailingIcon = null;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usernameLabel.Location = new System.Drawing.Point(287, 195);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(279, 64);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // confirmPasswordText
            // 
            this.confirmPasswordText.AnimateReadOnly = false;
            this.confirmPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordText.Depth = 0;
            this.confirmPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.confirmPasswordText.LeadingIcon = null;
            this.confirmPasswordText.Location = new System.Drawing.Point(637, 439);
            this.confirmPasswordText.MaxLength = 50;
            this.confirmPasswordText.MouseState = MaterialSkin.MouseState.OUT;
            this.confirmPasswordText.Multiline = false;
            this.confirmPasswordText.Name = "confirmPasswordText";
            this.confirmPasswordText.Size = new System.Drawing.Size(393, 50);
            this.confirmPasswordText.TabIndex = 13;
            this.confirmPasswordText.Text = "";
            this.confirmPasswordText.TrailingIcon = null;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(58, 425);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(493, 64);
            this.confirmPasswordLabel.TabIndex = 12;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 734);
            this.Controls.Add(this.confirmPasswordText);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameLabel);
            this.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Register";
            this.Padding = new System.Windows.Forms.Padding(6, 112, 6, 5);
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private MaterialSkin.Controls.MaterialTextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private MaterialSkin.Controls.MaterialTextBox usernameText;
        private System.Windows.Forms.Label usernameLabel;
        private MaterialSkin.Controls.MaterialTextBox confirmPasswordText;
        private System.Windows.Forms.Label confirmPasswordLabel;
    }
}