namespace RV_Messenger
{
    partial class GroupChat
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
            this.consoleText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
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
            this.friendListLabel.TabIndex = 9;
            this.friendListLabel.Text = "Friend List";
            // 
            // messageText
            // 
            this.messageText.AnimateReadOnly = false;
            this.messageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageText.Depth = 0;
            this.messageText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.messageText.LeadingIcon = null;
            this.messageText.Location = new System.Drawing.Point(739, 215);
            this.messageText.MaxLength = 50;
            this.messageText.MouseState = MaterialSkin.MouseState.OUT;
            this.messageText.Multiline = false;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(393, 50);
            this.messageText.TabIndex = 14;
            this.messageText.Text = "";
            this.messageText.TrailingIcon = null;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.messageLabel.Location = new System.Drawing.Point(389, 201);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(244, 64);
            this.messageLabel.TabIndex = 13;
            this.messageLabel.Text = "Message";
            // 
            // consoleText
            // 
            this.consoleText.Location = new System.Drawing.Point(519, 446);
            this.consoleText.Multiline = true;
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(660, 226);
            this.consoleText.TabIndex = 18;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.sendButton.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendButton.Location = new System.Drawing.Point(856, 327);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(159, 69);
            this.sendButton.TabIndex = 19;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // friendListDataGridView
            // 
            this.friendListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendListDataGridView.Location = new System.Drawing.Point(-5, 108);
            this.friendListDataGridView.Name = "friendListDataGridView";
            this.friendListDataGridView.RowTemplate.Height = 24;
            this.friendListDataGridView.Size = new System.Drawing.Size(294, 632);
            this.friendListDataGridView.TabIndex = 20;
            // 
            // GroupChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 734);
            this.Controls.Add(this.friendListDataGridView);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.consoleText);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.friendListLabel);
            this.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GroupChat";
            this.Padding = new System.Windows.Forms.Padding(6, 112, 6, 5);
            this.Text = "GroupChat";
            this.Load += new System.EventHandler(this.GroupChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.friendListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label friendListLabel;
        private MaterialSkin.Controls.MaterialTextBox messageText;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox consoleText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.DataGridView friendListDataGridView;
    }
}