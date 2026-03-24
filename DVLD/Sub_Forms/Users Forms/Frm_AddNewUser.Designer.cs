namespace DVLD.Sub_Forms.Users_Forms
{
    partial class Frm_AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddNewUser));
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage_1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.UC_ShowPersonInfo = new DVLD.User_Controls.UC_ShowPersonInfo();
            this.UC_Filter = new DVLD.User_Controls.UC_Filter();
            this.TabPage_2 = new System.Windows.Forms.TabPage();
            this.CheckBox_Active = new System.Windows.Forms.CheckBox();
            this.TB_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.Pic_PersonID = new System.Windows.Forms.PictureBox();
            this.Pic_PersonGendor = new System.Windows.Forms.PictureBox();
            this.Pic_PersonNationalNo = new System.Windows.Forms.PictureBox();
            this.Pic_PersonName = new System.Windows.Forms.PictureBox();
            this.Label_Const_ConfirmPass = new System.Windows.Forms.Label();
            this.Label_Const_Password = new System.Windows.Forms.Label();
            this.Label_Const_PersonName = new System.Windows.Forms.Label();
            this.Label_Variable_UserID = new System.Windows.Forms.Label();
            this.Label_Const_UserID = new System.Windows.Forms.Label();
            this.Pic_FormImageTitle = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.ErrorProvider_Fail = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabControl.SuspendLayout();
            this.TabPage_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabPage_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonGendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonNationalNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Fail)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.AutoSize = true;
            this.Label_FormTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Location = new System.Drawing.Point(297, 141);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(180, 31);
            this.Label_FormTitle.TabIndex = 5;
            this.Label_FormTitle.Text = "Add New User";
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.TabPage_1);
            this.TabControl.Controls.Add(this.TabPage_2);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 190);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(775, 403);
            this.TabControl.TabIndex = 8;
            this.TabControl.Tag = "";
            // 
            // TabPage_1
            // 
            this.TabPage_1.Controls.Add(this.pictureBox1);
            this.TabPage_1.Controls.Add(this.Btn_Next);
            this.TabPage_1.Controls.Add(this.UC_ShowPersonInfo);
            this.TabPage_1.Controls.Add(this.UC_Filter);
            this.TabPage_1.Location = new System.Drawing.Point(4, 30);
            this.TabPage_1.Name = "TabPage_1";
            this.TabPage_1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_1.Size = new System.Drawing.Size(767, 369);
            this.TabPage_1.TabIndex = 0;
            this.TabPage_1.Tag = "Page_1";
            this.TabPage_1.Text = "Person Info";
            this.TabPage_1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Pic_AddEditPerson_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Next.Image")));
            this.Btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Next.Location = new System.Drawing.Point(673, 339);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(76, 25);
            this.Btn_Next.TabIndex = 10;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // UC_ShowPersonInfo
            // 
            this.UC_ShowPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_ShowPersonInfo.Location = new System.Drawing.Point(11, 45);
            this.UC_ShowPersonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.UC_ShowPersonInfo.Name = "UC_ShowPersonInfo";
            this.UC_ShowPersonInfo.Size = new System.Drawing.Size(747, 287);
            this.UC_ShowPersonInfo.TabIndex = 9;
            this.UC_ShowPersonInfo.SendPersonID += new System.Action<int>(this.UC_ShowPersonInfo_SendPersonID);
            this.UC_ShowPersonInfo.SendRequestToGetImage += new System.Action<bool, string>(this.UC_ShowPersonInfo_SendRequestToGetImage);
            // 
            // UC_Filter
            // 
            this.UC_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_Filter.Location = new System.Drawing.Point(11, 7);
            this.UC_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.UC_Filter.Name = "UC_Filter";
            this.UC_Filter.Size = new System.Drawing.Size(380, 45);
            this.UC_Filter.TabIndex = 8;
            this.UC_Filter.Ev_IsInt += new System.Action<int>(this.UC_Filter_Ev_IsInt);
            this.UC_Filter.EvClickedSearchButton += new System.Action<string>(this.UC_Filter_EvClickedSearchButton);
            // 
            // TabPage_2
            // 
            this.TabPage_2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TabPage_2.Controls.Add(this.CheckBox_Active);
            this.TabPage_2.Controls.Add(this.TB_ConfirmPassword);
            this.TabPage_2.Controls.Add(this.TB_Password);
            this.TabPage_2.Controls.Add(this.TB_Username);
            this.TabPage_2.Controls.Add(this.Pic_PersonID);
            this.TabPage_2.Controls.Add(this.Pic_PersonGendor);
            this.TabPage_2.Controls.Add(this.Pic_PersonNationalNo);
            this.TabPage_2.Controls.Add(this.Pic_PersonName);
            this.TabPage_2.Controls.Add(this.Label_Const_ConfirmPass);
            this.TabPage_2.Controls.Add(this.Label_Const_Password);
            this.TabPage_2.Controls.Add(this.Label_Const_PersonName);
            this.TabPage_2.Controls.Add(this.Label_Variable_UserID);
            this.TabPage_2.Controls.Add(this.Label_Const_UserID);
            this.TabPage_2.Location = new System.Drawing.Point(4, 30);
            this.TabPage_2.Name = "TabPage_2";
            this.TabPage_2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_2.Size = new System.Drawing.Size(767, 369);
            this.TabPage_2.TabIndex = 1;
            this.TabPage_2.Tag = "Page_2";
            this.TabPage_2.Text = "Login Info";
            this.TabPage_2.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Active
            // 
            this.CheckBox_Active.AutoSize = true;
            this.CheckBox_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_Active.Location = new System.Drawing.Point(223, 218);
            this.CheckBox_Active.Name = "CheckBox_Active";
            this.CheckBox_Active.Size = new System.Drawing.Size(76, 20);
            this.CheckBox_Active.TabIndex = 41;
            this.CheckBox_Active.Text = "Is Active";
            this.CheckBox_Active.UseVisualStyleBackColor = true;
            // 
            // TB_ConfirmPassword
            // 
            this.TB_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ConfirmPassword.Location = new System.Drawing.Point(224, 178);
            this.TB_ConfirmPassword.Name = "TB_ConfirmPassword";
            this.TB_ConfirmPassword.PasswordChar = '●';
            this.TB_ConfirmPassword.Size = new System.Drawing.Size(100, 21);
            this.TB_ConfirmPassword.TabIndex = 40;
            this.TB_ConfirmPassword.Validated += new System.EventHandler(this.TB_ConfirmPassword_Validated);
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(224, 140);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '●';
            this.TB_Password.Size = new System.Drawing.Size(100, 21);
            this.TB_Password.TabIndex = 39;
            this.TB_Password.Validated += new System.EventHandler(this.TB_ConfirmPassword_Validated);
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(224, 96);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(100, 21);
            this.TB_Username.TabIndex = 38;
            this.TB_Username.Validated += new System.EventHandler(this.TB_Username_Validated);
            // 
            // Pic_PersonID
            // 
            this.Pic_PersonID.Image = global::DVLD.Properties.Resources.id;
            this.Pic_PersonID.Location = new System.Drawing.Point(127, 59);
            this.Pic_PersonID.Name = "Pic_PersonID";
            this.Pic_PersonID.Size = new System.Drawing.Size(30, 16);
            this.Pic_PersonID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_PersonID.TabIndex = 37;
            this.Pic_PersonID.TabStop = false;
            // 
            // Pic_PersonGendor
            // 
            this.Pic_PersonGendor.Image = global::DVLD.Properties.Resources.approve;
            this.Pic_PersonGendor.Location = new System.Drawing.Point(54, 178);
            this.Pic_PersonGendor.Name = "Pic_PersonGendor";
            this.Pic_PersonGendor.Size = new System.Drawing.Size(30, 16);
            this.Pic_PersonGendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_PersonGendor.TabIndex = 36;
            this.Pic_PersonGendor.TabStop = false;
            // 
            // Pic_PersonNationalNo
            // 
            this.Pic_PersonNationalNo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_PersonNationalNo.Image")));
            this.Pic_PersonNationalNo.Location = new System.Drawing.Point(106, 140);
            this.Pic_PersonNationalNo.Name = "Pic_PersonNationalNo";
            this.Pic_PersonNationalNo.Size = new System.Drawing.Size(30, 16);
            this.Pic_PersonNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_PersonNationalNo.TabIndex = 35;
            this.Pic_PersonNationalNo.TabStop = false;
            // 
            // Pic_PersonName
            // 
            this.Pic_PersonName.Image = global::DVLD.Properties.Resources.user;
            this.Pic_PersonName.Location = new System.Drawing.Point(106, 96);
            this.Pic_PersonName.Name = "Pic_PersonName";
            this.Pic_PersonName.Size = new System.Drawing.Size(30, 16);
            this.Pic_PersonName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_PersonName.TabIndex = 34;
            this.Pic_PersonName.TabStop = false;
            // 
            // Label_Const_ConfirmPass
            // 
            this.Label_Const_ConfirmPass.AutoSize = true;
            this.Label_Const_ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_ConfirmPass.Location = new System.Drawing.Point(90, 178);
            this.Label_Const_ConfirmPass.Name = "Label_Const_ConfirmPass";
            this.Label_Const_ConfirmPass.Size = new System.Drawing.Size(118, 16);
            this.Label_Const_ConfirmPass.TabIndex = 30;
            this.Label_Const_ConfirmPass.Text = "Confirm Password:";
            // 
            // Label_Const_Password
            // 
            this.Label_Const_Password.AutoSize = true;
            this.Label_Const_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Password.Location = new System.Drawing.Point(142, 140);
            this.Label_Const_Password.Name = "Label_Const_Password";
            this.Label_Const_Password.Size = new System.Drawing.Size(70, 16);
            this.Label_Const_Password.TabIndex = 29;
            this.Label_Const_Password.Text = "Password:";
            // 
            // Label_Const_PersonName
            // 
            this.Label_Const_PersonName.AutoSize = true;
            this.Label_Const_PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_PersonName.Location = new System.Drawing.Point(142, 96);
            this.Label_Const_PersonName.Name = "Label_Const_PersonName";
            this.Label_Const_PersonName.Size = new System.Drawing.Size(76, 16);
            this.Label_Const_PersonName.TabIndex = 28;
            this.Label_Const_PersonName.Text = "Username: ";
            // 
            // Label_Variable_UserID
            // 
            this.Label_Variable_UserID.AutoSize = true;
            this.Label_Variable_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_UserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Variable_UserID.Location = new System.Drawing.Point(224, 59);
            this.Label_Variable_UserID.Name = "Label_Variable_UserID";
            this.Label_Variable_UserID.Size = new System.Drawing.Size(79, 16);
            this.Label_Variable_UserID.TabIndex = 27;
            this.Label_Variable_UserID.Text = "........................";
            // 
            // Label_Const_UserID
            // 
            this.Label_Const_UserID.AutoSize = true;
            this.Label_Const_UserID.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_UserID.Location = new System.Drawing.Point(163, 59);
            this.Label_Const_UserID.Name = "Label_Const_UserID";
            this.Label_Const_UserID.Size = new System.Drawing.Size(55, 16);
            this.Label_Const_UserID.TabIndex = 26;
            this.Label_Const_UserID.Text = "User ID:";
            // 
            // Pic_FormImageTitle
            // 
            this.Pic_FormImageTitle.Image = ((System.Drawing.Image)(resources.GetObject("Pic_FormImageTitle.Image")));
            this.Pic_FormImageTitle.Location = new System.Drawing.Point(227, 12);
            this.Pic_FormImageTitle.Name = "Pic_FormImageTitle";
            this.Pic_FormImageTitle.Size = new System.Drawing.Size(316, 115);
            this.Pic_FormImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_FormImageTitle.TabIndex = 4;
            this.Pic_FormImageTitle.TabStop = false;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Close.Location = new System.Drawing.Point(570, 599);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(76, 25);
            this.Btn_Close.TabIndex = 11;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Enabled = false;
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.Image")));
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Save.Location = new System.Drawing.Point(652, 599);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(76, 25);
            this.Btn_Save.TabIndex = 12;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // ErrorProvider_Fail
            // 
            this.ErrorProvider_Fail.ContainerControl = this;
            this.ErrorProvider_Fail.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider_Fail.Icon")));
            // 
            // Frm_AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 634);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Label_FormTitle);
            this.Controls.Add(this.Pic_FormImageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_AddNewUser";
            this.Text = "Frm_AddNewUser";
            this.Load += new System.EventHandler(this.Frm_AddNewUser_Load);
            this.TabControl.ResumeLayout(false);
            this.TabPage_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabPage_2.ResumeLayout(false);
            this.TabPage_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonGendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonNationalNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Fail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_FormImageTitle;
        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPage_1;
        private System.Windows.Forms.TabPage TabPage_2;
        private User_Controls.UC_Filter UC_Filter;
        private User_Controls.UC_ShowPersonInfo UC_ShowPersonInfo;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.PictureBox Pic_PersonID;
        private System.Windows.Forms.PictureBox Pic_PersonGendor;
        private System.Windows.Forms.PictureBox Pic_PersonNationalNo;
        private System.Windows.Forms.PictureBox Pic_PersonName;
        private System.Windows.Forms.Label Label_Const_ConfirmPass;
        private System.Windows.Forms.Label Label_Const_Password;
        private System.Windows.Forms.Label Label_Const_PersonName;
        private System.Windows.Forms.Label Label_Variable_UserID;
        private System.Windows.Forms.Label Label_Const_UserID;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_ConfirmPassword;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.CheckBox CheckBox_Active;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.ErrorProvider ErrorProvider_Fail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }


} 