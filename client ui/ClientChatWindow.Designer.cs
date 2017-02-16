using System.Drawing;
using System.Windows.Forms;

namespace client_ui
{
    partial class ClientChatWindow : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientChatWindow));
            this.txtBoxServerIP = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txtBoxNickName = new System.Windows.Forms.TextBox();
            this.lbl1ServerIP = new System.Windows.Forms.Label();
            this.lbl2NickName = new System.Windows.Forms.Label();
            this.lstBoxChatText = new System.Windows.Forms.ListBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtChatText = new System.Windows.Forms.TextBox();
            this.btn_browseToPicture = new System.Windows.Forms.Button();
            this.btn_TextColor = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.btn_Subscribe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxServerIP
            // 
            this.txtBoxServerIP.Location = new System.Drawing.Point(76, 28);
            this.txtBoxServerIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxServerIP.Name = "txtBoxServerIP";
            this.txtBoxServerIP.Size = new System.Drawing.Size(134, 22);
            this.txtBoxServerIP.TabIndex = 0;
            this.txtBoxServerIP.Text = "127.0.0.1";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(76, 88);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(134, 26);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxNickName
            // 
            this.txtBoxNickName.Location = new System.Drawing.Point(76, 58);
            this.txtBoxNickName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNickName.Name = "txtBoxNickName";
            this.txtBoxNickName.Size = new System.Drawing.Size(134, 22);
            this.txtBoxNickName.TabIndex = 2;
            // 
            // lbl1ServerIP
            // 
            this.lbl1ServerIP.AutoSize = true;
            this.lbl1ServerIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1ServerIP.Location = new System.Drawing.Point(5, 33);
            this.lbl1ServerIP.Name = "lbl1ServerIP";
            this.lbl1ServerIP.Size = new System.Drawing.Size(54, 17);
            this.lbl1ServerIP.TabIndex = 3;
            this.lbl1ServerIP.Text = "Server IP";
            // 
            // lbl2NickName
            // 
            this.lbl2NickName.AutoSize = true;
            this.lbl2NickName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2NickName.Location = new System.Drawing.Point(5, 63);
            this.lbl2NickName.Name = "lbl2NickName";
            this.lbl2NickName.Size = new System.Drawing.Size(63, 17);
            this.lbl2NickName.TabIndex = 4;
            this.lbl2NickName.Text = "NickName";
            // 
            // lstBoxChatText
            // 
            this.lstBoxChatText.FormattingEnabled = true;
            this.lstBoxChatText.ItemHeight = 15;
            this.lstBoxChatText.Location = new System.Drawing.Point(5, 135);
            this.lstBoxChatText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBoxChatText.Name = "lstBoxChatText";
            this.lstBoxChatText.Size = new System.Drawing.Size(452, 214);
            this.lstBoxChatText.TabIndex = 5;
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(394, 354);
            this.btn_SendMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(63, 26);
            this.btn_SendMessage.TabIndex = 6;
            this.btn_SendMessage.Text = "Send";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(415, 74);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(135, 22);
            this.txtFilePath.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // txtChatText
            // 
            this.txtChatText.Location = new System.Drawing.Point(5, 357);
            this.txtChatText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChatText.Multiline = true;
            this.txtChatText.Name = "txtChatText";
            this.txtChatText.Size = new System.Drawing.Size(383, 26);
            this.txtChatText.TabIndex = 18;
            // 
            // btn_browseToPicture
            // 
            this.btn_browseToPicture.Location = new System.Drawing.Point(415, 104);
            this.btn_browseToPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_browseToPicture.Name = "btn_browseToPicture";
            this.btn_browseToPicture.Size = new System.Drawing.Size(54, 26);
            this.btn_browseToPicture.TabIndex = 21;
            this.btn_browseToPicture.Text = "Browse";
            this.btn_browseToPicture.UseVisualStyleBackColor = true;
            this.btn_browseToPicture.Click += new System.EventHandler(this.btn_browseToPicture_Click);
            // 
            // btn_TextColor
            // 
            this.btn_TextColor.Location = new System.Drawing.Point(155, 390);
            this.btn_TextColor.Name = "btn_TextColor";
            this.btn_TextColor.Size = new System.Drawing.Size(126, 23);
            this.btn_TextColor.TabIndex = 22;
            this.btn_TextColor.Text = "Choose text color";
            this.btn_TextColor.UseVisualStyleBackColor = true;
            this.btn_TextColor.Click += new System.EventHandler(this.btn_TextColor_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(415, 104);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SendFile.TabIndex = 23;
            this.btn_SendFile.Text = "Send file";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Location = new System.Drawing.Point(6, 25);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(116, 15);
            this.lbl_Register.TabIndex = 24;
            this.lbl_Register.Text = "New User ? Register !";
            // 
            // btn_Subscribe
            // 
            this.btn_Subscribe.Location = new System.Drawing.Point(9, 54);
            this.btn_Subscribe.Name = "btn_Subscribe";
            this.btn_Subscribe.Size = new System.Drawing.Size(113, 23);
            this.btn_Subscribe.TabIndex = 25;
            this.btn_Subscribe.Text = "Register";
            this.btn_Subscribe.UseVisualStyleBackColor = true;
            this.btn_Subscribe.Click += new System.EventHandler(this.btn_Subscribe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Register);
            this.groupBox1.Controls.Add(this.btn_Subscribe);
            this.groupBox1.Location = new System.Drawing.Point(238, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // ClientChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(556, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.btn_TextColor);
            this.Controls.Add(this.btn_browseToPicture);
            this.Controls.Add(this.txtChatText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.lstBoxChatText);
            this.Controls.Add(this.lbl2NickName);
            this.Controls.Add(this.lbl1ServerIP);
            this.Controls.Add(this.txtBoxNickName);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txtBoxServerIP);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientChatWindow";
            this.Text = "Welcome to Client Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientChatWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxServerIP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txtBoxNickName;
        private System.Windows.Forms.Label lbl1ServerIP;
        private System.Windows.Forms.Label lbl2NickName;
        private System.Windows.Forms.ListBox lstBoxChatText;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private Color cmb_ChatColor;
        private System.Windows.Forms.TextBox txtChatText;
        private Button btn_browseToPicture;
        private Button btn_TextColor;
        private Button btn_SendFile;
        private Label lbl_Register;
        private Button btn_Subscribe;
        private GroupBox groupBox1;
    }
}

