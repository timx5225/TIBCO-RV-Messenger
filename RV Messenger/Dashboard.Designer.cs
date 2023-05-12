namespace RV_Messenger
{
    partial class Dashboard
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
            this.friendListLabel = new System.Windows.Forms.Label();
            this.messageText = new MaterialSkin.Controls.MaterialTextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.usernameText = new MaterialSkin.Controls.MaterialTextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.deleteFriendButton = new System.Windows.Forms.Button();
            this.addFriendButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.consoleText = new System.Windows.Forms.TextBox();
            this.friendListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.friendListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // friendListLabel
            // 
            this.friendListLabel.AutoSize = true;
            this.friendListLabel.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendListLabel.Location = new System.Drawing.Point(-2, 64);
            this.friendListLabel.Name = "friendListLabel";
            this.friendListLabel.Size = new System.Drawing.Size(234, 48);
            this.friendListLabel.TabIndex = 7;
            this.friendListLabel.Text = "Friend List";
            // 
            // messageText
            // 
            this.messageText.AnimateReadOnly = false;
            this.messageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageText.Depth = 0;
            this.messageText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.messageText.LeadingIcon = null;
            this.messageText.Location = new System.Drawing.Point(717, 250);
            this.messageText.MaxLength = 50;
            this.messageText.MouseState = MaterialSkin.MouseState.OUT;
            this.messageText.Multiline = false;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(393, 50);
            this.messageText.TabIndex = 12;
            this.messageText.Text = "";
            this.messageText.TrailingIcon = null;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.messageLabel.Location = new System.Drawing.Point(367, 236);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(244, 64);
            this.messageLabel.TabIndex = 11;
            this.messageLabel.Text = "Message";
            // 
            // usernameText
            // 
            this.usernameText.AnimateReadOnly = false;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Depth = 0;
            this.usernameText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameText.LeadingIcon = null;
            this.usernameText.Location = new System.Drawing.Point(717, 136);
            this.usernameText.MaxLength = 50;
            this.usernameText.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameText.Multiline = false;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(393, 50);
            this.usernameText.TabIndex = 10;
            this.usernameText.Text = "";
            this.usernameText.TrailingIcon = null;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usernameLabel.Location = new System.Drawing.Point(367, 122);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(279, 64);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // deleteFriendButton
            // 
            this.deleteFriendButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteFriendButton.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteFriendButton.Location = new System.Drawing.Point(620, 350);
            this.deleteFriendButton.Name = "deleteFriendButton";
            this.deleteFriendButton.Size = new System.Drawing.Size(238, 69);
            this.deleteFriendButton.TabIndex = 14;
            this.deleteFriendButton.Text = "Delete Friend";
            this.deleteFriendButton.UseVisualStyleBackColor = false;
            this.deleteFriendButton.Click += new System.EventHandler(this.deleteFriendButton_Click);
            // 
            // addFriendButton
            // 
            this.addFriendButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addFriendButton.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addFriendButton.Location = new System.Drawing.Point(378, 350);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(208, 69);
            this.addFriendButton.TabIndex = 13;
            this.addFriendButton.Text = "Add Friend";
            this.addFriendButton.UseVisualStyleBackColor = false;
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.sendButton.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendButton.Location = new System.Drawing.Point(892, 350);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(159, 69);
            this.sendButton.TabIndex = 15;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupButton.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupButton.Location = new System.Drawing.Point(1081, 350);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(171, 69);
            this.groupButton.TabIndex = 16;
            this.groupButton.Text = "Group";
            this.groupButton.UseVisualStyleBackColor = false;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // consoleText
            // 
            this.consoleText.Location = new System.Drawing.Point(489, 455);
            this.consoleText.Multiline = true;
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(660, 226);
            this.consoleText.TabIndex = 17;
            // 
            // friendListDataGridView
            // 
            this.friendListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendListDataGridView.Location = new System.Drawing.Point(-4, 108);
            this.friendListDataGridView.Name = "friendListDataGridView";
            this.friendListDataGridView.RowTemplate.Height = 24;
            this.friendListDataGridView.Size = new System.Drawing.Size(294, 628);
            this.friendListDataGridView.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 734);
            this.Controls.Add(this.friendListDataGridView);
            this.Controls.Add(this.consoleText);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.deleteFriendButton);
            this.Controls.Add(this.addFriendButton);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.friendListLabel);
            this.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(6, 112, 6, 5);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.friendListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label friendListLabel;
        private MaterialSkin.Controls.MaterialTextBox messageText;
        private System.Windows.Forms.Label messageLabel;
        private MaterialSkin.Controls.MaterialTextBox usernameText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button deleteFriendButton;
        private System.Windows.Forms.Button addFriendButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.TextBox consoleText;
        private System.Windows.Forms.DataGridView friendListDataGridView;
    }
}