namespace RemoteSender
{
    partial class RemoteSender
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
            this.toLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.toField = new System.Windows.Forms.TextBox();
            this.titleField = new System.Windows.Forms.TextBox();
            this.bodyField = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(22, 19);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "To:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(22, 49);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(22, 81);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(34, 13);
            this.bodyLabel.TabIndex = 2;
            this.bodyLabel.Text = "Body:";
            // 
            // toField
            // 
            this.toField.Location = new System.Drawing.Point(58, 16);
            this.toField.Name = "toField";
            this.toField.Size = new System.Drawing.Size(210, 20);
            this.toField.TabIndex = 3;
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(58, 46);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(210, 20);
            this.titleField.TabIndex = 4;
            // 
            // bodyField
            // 
            this.bodyField.Location = new System.Drawing.Point(58, 81);
            this.bodyField.Multiline = true;
            this.bodyField.Name = "bodyField";
            this.bodyField.Size = new System.Drawing.Size(210, 89);
            this.bodyField.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(118, 186);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(68, 20);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // RemoteSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 218);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.bodyField);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.toField);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.toLabel);
            this.Load += new System.EventHandler(RemoteSender_Load);
            this.Name = "RemoteSender";
            this.Text = "Remote Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.TextBox toField;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.TextBox bodyField;
        private System.Windows.Forms.Button sendButton;
    }
}

