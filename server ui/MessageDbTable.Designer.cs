namespace server_ui
{
    partial class SearchDbTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDbTable));
            this.lbl_SearchMessage = new System.Windows.Forms.Label();
            this.lbl_SearchUser = new System.Windows.Forms.Label();
            this.cmb1_msgSearch = new System.Windows.Forms.ComboBox();
            this.cmb2_UserSearch = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.txtBox_MessageValue = new System.Windows.Forms.TextBox();
            this.lbl_SearchByWord = new System.Windows.Forms.Label();
            this.lbl_SearchByNameOrId = new System.Windows.Forms.Label();
            this.lbl_MessagesSearch = new System.Windows.Forms.Label();
            this.lbl_UserSearch = new System.Windows.Forms.Label();
            this.lbl_DeleteUser = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBox_UserOrIdValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_DeleteUser = new System.Windows.Forms.TextBox();
            this.customizedTooltip = new server_ui.CustomizedTooltip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SearchMessage
            // 
            this.lbl_SearchMessage.AutoSize = true;
            this.lbl_SearchMessage.Location = new System.Drawing.Point(12, 47);
            this.lbl_SearchMessage.Name = "lbl_SearchMessage";
            this.lbl_SearchMessage.Size = new System.Drawing.Size(72, 13);
            this.lbl_SearchMessage.TabIndex = 0;
            this.lbl_SearchMessage.Text = "Select search";
            this.customizedTooltip.SetToolTip(this.lbl_SearchMessage, "Search by Word or By Date");
            // 
            // lbl_SearchUser
            // 
            this.lbl_SearchUser.AutoSize = true;
            this.lbl_SearchUser.Location = new System.Drawing.Point(12, 352);
            this.lbl_SearchUser.Name = "lbl_SearchUser";
            this.lbl_SearchUser.Size = new System.Drawing.Size(74, 13);
            this.lbl_SearchUser.TabIndex = 1;
            this.lbl_SearchUser.Text = "Select Search";
            // 
            // cmb1_msgSearch
            // 
            this.cmb1_msgSearch.FormattingEnabled = true;
            this.cmb1_msgSearch.Items.AddRange(new object[] {
            "Word",
            "Date"});
            this.cmb1_msgSearch.Location = new System.Drawing.Point(143, 44);
            this.cmb1_msgSearch.Name = "cmb1_msgSearch";
            this.cmb1_msgSearch.Size = new System.Drawing.Size(121, 21);
            this.cmb1_msgSearch.TabIndex = 2;
            this.cmb1_msgSearch.SelectedIndexChanged += new System.EventHandler(this.cmb1_msgSearch_SelectedIndexChanged);
            // 
            // cmb2_UserSearch
            // 
            this.cmb2_UserSearch.FormattingEnabled = true;
            this.cmb2_UserSearch.Items.AddRange(new object[] {
            "Id",
            "NickName"});
            this.cmb2_UserSearch.Location = new System.Drawing.Point(143, 349);
            this.cmb2_UserSearch.Name = "cmb2_UserSearch";
            this.cmb2_UserSearch.Size = new System.Drawing.Size(121, 21);
            this.cmb2_UserSearch.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 181);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 417);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(475, 184);
            this.dataGridView2.TabIndex = 5;
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.Red;
            this.btn_DeleteUser.Location = new System.Drawing.Point(580, 389);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteUser.TabIndex = 6;
            this.btn_DeleteUser.Text = "Delete User";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // txtBox_MessageValue
            // 
            this.txtBox_MessageValue.Location = new System.Drawing.Point(143, 71);
            this.txtBox_MessageValue.Name = "txtBox_MessageValue";
            this.txtBox_MessageValue.Size = new System.Drawing.Size(121, 20);
            this.txtBox_MessageValue.TabIndex = 9;
            this.customizedTooltip.SetToolTip(this.txtBox_MessageValue, "Type the word to search");
            this.txtBox_MessageValue.TextChanged += new System.EventHandler(this.txtBox_MessageValue_TextChanged);
            // 
            // lbl_SearchByWord
            // 
            this.lbl_SearchByWord.AutoSize = true;
            this.lbl_SearchByWord.Location = new System.Drawing.Point(12, 71);
            this.lbl_SearchByWord.Name = "lbl_SearchByWord";
            this.lbl_SearchByWord.Size = new System.Drawing.Size(84, 13);
            this.lbl_SearchByWord.TabIndex = 10;
            this.lbl_SearchByWord.Text = "Search by word ";
            // 
            // lbl_SearchByNameOrId
            // 
            this.lbl_SearchByNameOrId.AutoSize = true;
            this.lbl_SearchByNameOrId.Location = new System.Drawing.Point(12, 379);
            this.lbl_SearchByNameOrId.Name = "lbl_SearchByNameOrId";
            this.lbl_SearchByNameOrId.Size = new System.Drawing.Size(125, 13);
            this.lbl_SearchByNameOrId.TabIndex = 11;
            this.lbl_SearchByNameOrId.Text = "Search user by Name/ID";
            // 
            // lbl_MessagesSearch
            // 
            this.lbl_MessagesSearch.AutoSize = true;
            this.lbl_MessagesSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MessagesSearch.Location = new System.Drawing.Point(141, 9);
            this.lbl_MessagesSearch.Name = "lbl_MessagesSearch";
            this.lbl_MessagesSearch.Size = new System.Drawing.Size(145, 23);
            this.lbl_MessagesSearch.TabIndex = 12;
            this.lbl_MessagesSearch.Text = "Messages Search";
            // 
            // lbl_UserSearch
            // 
            this.lbl_UserSearch.AutoSize = true;
            this.lbl_UserSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserSearch.Location = new System.Drawing.Point(140, 315);
            this.lbl_UserSearch.Name = "lbl_UserSearch";
            this.lbl_UserSearch.Size = new System.Drawing.Size(116, 23);
            this.lbl_UserSearch.TabIndex = 13;
            this.lbl_UserSearch.Text = "Users Search";
            // 
            // lbl_DeleteUser
            // 
            this.lbl_DeleteUser.AutoSize = true;
            this.lbl_DeleteUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeleteUser.Location = new System.Drawing.Point(563, 315);
            this.lbl_DeleteUser.Name = "lbl_DeleteUser";
            this.lbl_DeleteUser.Size = new System.Drawing.Size(116, 23);
            this.lbl_DeleteUser.TabIndex = 14;
            this.lbl_DeleteUser.Text = "User Deletion";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(556, 44);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker.TabIndex = 16;
            this.customizedTooltip.SetToolTip(this.dateTimePicker, "Select your search first then select a date from the calendar");
            // 
            // txtBox_UserOrIdValue
            // 
            this.txtBox_UserOrIdValue.Location = new System.Drawing.Point(143, 379);
            this.txtBox_UserOrIdValue.Name = "txtBox_UserOrIdValue";
            this.txtBox_UserOrIdValue.Size = new System.Drawing.Size(121, 20);
            this.txtBox_UserOrIdValue.TabIndex = 17;
            this.customizedTooltip.SetToolTip(this.txtBox_UserOrIdValue, "Type NickName or User ID");
            this.txtBox_UserOrIdValue.TextChanged += new System.EventHandler(this.txtBox_UserOrIdValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Calendar";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(556, 82);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtBox_DeleteUser
            // 
            this.txtBox_DeleteUser.Location = new System.Drawing.Point(567, 349);
            this.txtBox_DeleteUser.Name = "txtBox_DeleteUser";
            this.txtBox_DeleteUser.Size = new System.Drawing.Size(100, 20);
            this.txtBox_DeleteUser.TabIndex = 20;
            this.customizedTooltip.SetToolTip(this.txtBox_DeleteUser, "Press the button  to delete the selected user");
            // 
            // customizedTooltip
            // 
            this.customizedTooltip.AutoPopDelay = 5000;
            this.customizedTooltip.BackColor = System.Drawing.Color.PaleTurquoise;
            this.customizedTooltip.ForeColor = System.Drawing.Color.BlueViolet;
            this.customizedTooltip.InitialDelay = 100;
            this.customizedTooltip.OwnerDraw = true;
            this.customizedTooltip.ReshowDelay = 100;
            // 
            // SearchDbTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 642);
            this.Controls.Add(this.txtBox_DeleteUser);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_UserOrIdValue);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lbl_DeleteUser);
            this.Controls.Add(this.lbl_UserSearch);
            this.Controls.Add(this.lbl_MessagesSearch);
            this.Controls.Add(this.lbl_SearchByNameOrId);
            this.Controls.Add(this.lbl_SearchByWord);
            this.Controls.Add(this.txtBox_MessageValue);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb2_UserSearch);
            this.Controls.Add(this.cmb1_msgSearch);
            this.Controls.Add(this.lbl_SearchUser);
            this.Controls.Add(this.lbl_SearchMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchDbTable";
            this.Text = "MessageDbTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SearchMessage;
        private System.Windows.Forms.Label lbl_SearchUser;
        private System.Windows.Forms.ComboBox cmb1_msgSearch;
        private System.Windows.Forms.ComboBox cmb2_UserSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.TextBox txtBox_MessageValue;
        private System.Windows.Forms.Label lbl_SearchByWord;
        private System.Windows.Forms.Label lbl_SearchByNameOrId;
        private System.Windows.Forms.Label lbl_MessagesSearch;
        private System.Windows.Forms.Label lbl_UserSearch;
        private System.Windows.Forms.Label lbl_DeleteUser;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtBox_UserOrIdValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_DeleteUser;
        private CustomizedTooltip customizedTooltip;
    }
}