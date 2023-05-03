namespace ChatClient
{
    partial class ChatClientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.txtRecivedMsgs = new System.Windows.Forms.TextBox();
            this.txtMsgs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(384, 29);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Connect To Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(303, 244);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 48);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // txtRecivedMsgs
            // 
            this.txtRecivedMsgs.Location = new System.Drawing.Point(12, 35);
            this.txtRecivedMsgs.Multiline = true;
            this.txtRecivedMsgs.Name = "txtRecivedMsgs";
            this.txtRecivedMsgs.ReadOnly = true;
            this.txtRecivedMsgs.Size = new System.Drawing.Size(275, 196);
            this.txtRecivedMsgs.TabIndex = 5;
            // 
            // txtMsgs
            // 
            this.txtMsgs.Location = new System.Drawing.Point(12, 244);
            this.txtMsgs.Multiline = true;
            this.txtMsgs.Name = "txtMsgs";
            this.txtMsgs.Size = new System.Drawing.Size(275, 48);
            this.txtMsgs.TabIndex = 4;
            // 
            // ChatClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 304);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.txtRecivedMsgs);
            this.Controls.Add(this.txtMsgs);
            this.Name = "ChatClientForm";
            this.Text = "Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button BtnSend;
        private TextBox txtRecivedMsgs;
        private TextBox txtMsgs;
    }
}