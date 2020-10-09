namespace Client
{
    partial class ClientForm
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
            this.btnSendText = new System.Windows.Forms.Button();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.cmbIP = new System.Windows.Forms.ComboBox();
            this.btnSendImage = new System.Windows.Forms.Button();
            this.pnlMsg = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnSendText
            // 
            this.btnSendText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendText.Location = new System.Drawing.Point(496, 310);
            this.btnSendText.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(94, 53);
            this.btnSendText.TabIndex = 5;
            this.btnSendText.Text = "Send Text";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbMessage
            // 
            this.txbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMessage.BackColor = System.Drawing.Color.White;
            this.txbMessage.Location = new System.Drawing.Point(10, 310);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(482, 54);
            this.txbMessage.TabIndex = 4;
            this.txbMessage.TextChanged += new System.EventHandler(this.txbMessage_TextChanged);
            // 
            // cmbIP
            // 
            this.cmbIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIP.BackColor = System.Drawing.Color.White;
            this.cmbIP.FormattingEnabled = true;
            this.cmbIP.Items.AddRange(new object[] {
            "None"});
            this.cmbIP.Location = new System.Drawing.Point(10, 284);
            this.cmbIP.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIP.Name = "cmbIP";
            this.cmbIP.Size = new System.Drawing.Size(482, 21);
            this.cmbIP.TabIndex = 6;
            // 
            // btnSendImage
            // 
            this.btnSendImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendImage.Location = new System.Drawing.Point(496, 284);
            this.btnSendImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(94, 21);
            this.btnSendImage.TabIndex = 7;
            this.btnSendImage.Text = "Send Image";
            this.btnSendImage.UseVisualStyleBackColor = true;
            this.btnSendImage.Click += new System.EventHandler(this.btnSendImage_Click);
            // 
            // pnlMsg
            // 
            this.pnlMsg.BackColor = System.Drawing.Color.White;
            this.pnlMsg.Location = new System.Drawing.Point(10, 11);
            this.pnlMsg.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(581, 269);
            this.pnlMsg.TabIndex = 8;
            this.pnlMsg.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMsg_Paint);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnlMsg);
            this.Controls.Add(this.btnSendImage);
            this.Controls.Add(this.cmbIP);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.txbMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.ComboBox cmbIP;
        private System.Windows.Forms.Button btnSendImage;
        private System.Windows.Forms.FlowLayoutPanel pnlMsg;
    }
}

