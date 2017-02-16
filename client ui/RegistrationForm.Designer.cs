namespace client_ui
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_UserRegistration = new System.Windows.Forms.TextBox();
            this.txt_NickNameRegistration = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_ExitRegistrationForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(13, 13);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Location = new System.Drawing.Point(12, 51);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(57, 13);
            this.lbl_NickName.TabIndex = 1;
            this.lbl_NickName.Text = "NickName";
            // 
            // txt_UserRegistration
            // 
            this.txt_UserRegistration.Location = new System.Drawing.Point(104, 13);
            this.txt_UserRegistration.Name = "txt_UserRegistration";
            this.txt_UserRegistration.Size = new System.Drawing.Size(205, 20);
            this.txt_UserRegistration.TabIndex = 2;
            // 
            // txt_NickNameRegistration
            // 
            this.txt_NickNameRegistration.Location = new System.Drawing.Point(104, 48);
            this.txt_NickNameRegistration.Name = "txt_NickNameRegistration";
            this.txt_NickNameRegistration.Size = new System.Drawing.Size(205, 20);
            this.txt_NickNameRegistration.TabIndex = 3;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(104, 87);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 4;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_ExitRegistrationForm
            // 
            this.btn_ExitRegistrationForm.Location = new System.Drawing.Point(232, 86);
            this.btn_ExitRegistrationForm.Name = "btn_ExitRegistrationForm";
            this.btn_ExitRegistrationForm.Size = new System.Drawing.Size(75, 23);
            this.btn_ExitRegistrationForm.TabIndex = 5;
            this.btn_ExitRegistrationForm.Text = "Exit";
            this.btn_ExitRegistrationForm.UseVisualStyleBackColor = true;
            this.btn_ExitRegistrationForm.Click += new System.EventHandler(this.btn_ExitRegistrationForm_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(440, 261);
            this.Controls.Add(this.btn_ExitRegistrationForm);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_NickNameRegistration);
            this.Controls.Add(this.txt_UserRegistration);
            this.Controls.Add(this.lbl_NickName);
            this.Controls.Add(this.lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_UserRegistration;
        private System.Windows.Forms.TextBox txt_NickNameRegistration;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_ExitRegistrationForm;
    }
}