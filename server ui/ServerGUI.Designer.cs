namespace server_ui
{
    partial class ServerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerGUI));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMsgLog = new System.Windows.Forms.TextBox();
            this.btn_SearchMsgSearchUser = new System.Windows.Forms.Button();
            this.customizedTooltip1 = new server_ui.CustomizedTooltip();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 238);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usernames";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Addresses - Time of connection";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(163, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(235, 238);
            this.listBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chat log";
            // 
            // txtBoxMsgLog
            // 
            this.txtBoxMsgLog.Location = new System.Drawing.Point(404, 34);
            this.txtBoxMsgLog.Multiline = true;
            this.txtBoxMsgLog.Name = "txtBoxMsgLog";
            this.txtBoxMsgLog.ReadOnly = true;
            this.txtBoxMsgLog.Size = new System.Drawing.Size(339, 238);
            this.txtBoxMsgLog.TabIndex = 6;
            this.txtBoxMsgLog.Text = "Chat log";
            // 
            // btn_SearchMsgSearchUser
            // 
            this.btn_SearchMsgSearchUser.Location = new System.Drawing.Point(12, 305);
            this.btn_SearchMsgSearchUser.Name = "btn_SearchMsgSearchUser";
            this.btn_SearchMsgSearchUser.Size = new System.Drawing.Size(179, 23);
            this.btn_SearchMsgSearchUser.TabIndex = 7;
            this.btn_SearchMsgSearchUser.Text = "Search messages - Search users";
            this.customizedTooltip1.SetToolTip(this.btn_SearchMsgSearchUser, "Click to search messages in history");
            this.btn_SearchMsgSearchUser.UseVisualStyleBackColor = true;
            this.btn_SearchMsgSearchUser.Click += new System.EventHandler(this.btn_LoadMessagesTable_Click);
            // 
            // customizedTooltip1
            // 
            this.customizedTooltip1.BackColor = System.Drawing.Color.Bisque;
            this.customizedTooltip1.ForeColor = System.Drawing.Color.BlueViolet;
            this.customizedTooltip1.OwnerDraw = true;
            // 
            // ServerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(755, 352);
            this.Controls.Add(this.btn_SearchMsgSearchUser);
            this.Controls.Add(this.txtBoxMsgLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ServerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerGUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMsgLog;
        private System.Windows.Forms.Button btn_SearchMsgSearchUser;
        private CustomizedTooltip customizedTooltip1;
    }
}