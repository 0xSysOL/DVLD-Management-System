namespace DVLD.Sub_Forms.Application.Drving_Licenses_Services.New_Driving_License
{
    partial class Frm_NewLocalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NewLocalLicense));
            this.TC_PersonalInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Pic_AddNewPerson = new System.Windows.Forms.PictureBox();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.UC_Filter = new DVLD.User_Controls.UC_Filter();
            this.UC_ShowPersonInfo = new DVLD.User_Controls.UC_ShowPersonInfo();
            this.AppInfo = new System.Windows.Forms.TabPage();
            this.Pic_Const_CreateBy = new System.Windows.Forms.PictureBox();
            this.Pic_Const_ApplicationFees = new System.Windows.Forms.PictureBox();
            this.Pic_Const_LicenseClass = new System.Windows.Forms.PictureBox();
            this.Pic_Const_ApplicationDate = new System.Windows.Forms.PictureBox();
            this.Pic_PersonID = new System.Windows.Forms.PictureBox();
            this.ComboBox_LicenseClass = new System.Windows.Forms.ComboBox();
            this.Label_Const_LicenseClass = new System.Windows.Forms.Label();
            this.Label_Variable_CreateBy = new System.Windows.Forms.Label();
            this.Label_Const_CreateBy = new System.Windows.Forms.Label();
            this.Label_Variable_ApplicationFees = new System.Windows.Forms.Label();
            this.Label_Const_ApplicationFees = new System.Windows.Forms.Label();
            this.Label_Variable_ApplicationDate = new System.Windows.Forms.Label();
            this.Label_Const_ApplicationDate = new System.Windows.Forms.Label();
            this.Label_Variable_DL_AppID = new System.Windows.Forms.Label();
            this.Label_Const_DL_AppID = new System.Windows.Forms.Label();
            this.Label_Const_FormTitle = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.TC_PersonalInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_AddNewPerson)).BeginInit();
            this.AppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Const_CreateBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Const_ApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Const_LicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Const_ApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonID)).BeginInit();
            this.SuspendLayout();
            // 
            // TC_PersonalInfo
            // 
            this.TC_PersonalInfo.Controls.Add(this.tabPage1);
            this.TC_PersonalInfo.Controls.Add(this.AppInfo);
            this.TC_PersonalInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TC_PersonalInfo.Location = new System.Drawing.Point(12, 98);
            this.TC_PersonalInfo.Name = "TC_PersonalInfo";
            this.TC_PersonalInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TC_PersonalInfo.SelectedIndex = 0;
            this.TC_PersonalInfo.Size = new System.Drawing.Size(830, 445);
            this.TC_PersonalInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Pic_AddNewPerson);
            this.tabPage1.Controls.Add(this.Btn_Next);
            this.tabPage1.Controls.Add(this.UC_Filter);
            this.tabPage1.Controls.Add(this.UC_ShowPersonInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Pic_AddNewPerson
            // 
            this.Pic_AddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("Pic_AddNewPerson.Image")));
            this.Pic_AddNewPerson.Location = new System.Drawing.Point(756, 28);
            this.Pic_AddNewPerson.Name = "Pic_AddNewPerson";
            this.Pic_AddNewPerson.Size = new System.Drawing.Size(38, 38);
            this.Pic_AddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_AddNewPerson.TabIndex = 16;
            this.Pic_AddNewPerson.TabStop = false;
            this.Pic_AddNewPerson.Click += new System.EventHandler(this.Pic_AddNewPerson_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Next.Image")));
            this.Btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Next.Location = new System.Drawing.Point(718, 382);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(76, 25);
            this.Btn_Next.TabIndex = 15;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // UC_Filter
            // 
            this.UC_Filter.Location = new System.Drawing.Point(43, 28);
            this.UC_Filter.Name = "UC_Filter";
            this.UC_Filter.Size = new System.Drawing.Size(481, 45);
            this.UC_Filter.TabIndex = 1;
            this.UC_Filter.Ev_IsInt += new System.Action<int>(this.UC_Filter_Ev_IsInt);
            this.UC_Filter.EvClickedSearchButton += new System.Action<string>(this.UC_Filter_EvClickedSearchButton);
            // 
            // UC_ShowPersonInfo
            // 
            this.UC_ShowPersonInfo.Location = new System.Drawing.Point(43, 79);
            this.UC_ShowPersonInfo.Name = "UC_ShowPersonInfo";
            this.UC_ShowPersonInfo.Size = new System.Drawing.Size(751, 297);
            this.UC_ShowPersonInfo.TabIndex = 0;
            this.UC_ShowPersonInfo.SendRequestToGetImage += new System.Action<bool, string>(this.UC_ShowPersonInfo_SendRequestToGetImage);
            // 
            // AppInfo
            // 
            this.AppInfo.Controls.Add(this.Pic_Const_CreateBy);
            this.AppInfo.Controls.Add(this.Pic_Const_ApplicationFees);
            this.AppInfo.Controls.Add(this.Pic_Const_LicenseClass);
            this.AppInfo.Controls.Add(this.Pic_Const_ApplicationDate);
            this.AppInfo.Controls.Add(this.Pic_PersonID);
            this.AppInfo.Controls.Add(this.ComboBox_LicenseClass);
            this.AppInfo.Controls.Add(this.Label_Const_LicenseClass);
            this.AppInfo.Controls.Add(this.Label_Variable_CreateBy);
            this.AppInfo.Controls.Add(this.Label_Const_CreateBy);
            this.AppInfo.Controls.Add(this.Label_Variable_ApplicationFees);
            this.AppInfo.Controls.Add(this.Label_Const_ApplicationFees);
            this.AppInfo.Controls.Add(this.Label_Variable_ApplicationDate);
            this.AppInfo.Controls.Add(this.Label_Const_ApplicationDate);
            this.AppInfo.Controls.Add(this.Label_Variable_DL_AppID);
            this.AppInfo.Controls.Add(this.Label_Const_DL_AppID);
            this.AppInfo.Location = new System.Drawing.Point(4, 22);
            this.AppInfo.Name = "AppInfo";
            this.AppInfo.Padding = new System.Windows.Forms.Padding(3);
            this.AppInfo.Size = new System.Drawing.Size(822, 419);
            this.AppInfo.TabIndex = 1;
            this.AppInfo.Text = "Applicaton Info";
            this.AppInfo.UseVisualStyleBackColor = true;
            // 
            // Pic_Const_CreateBy
            // 
            this.Pic_Const_CreateBy.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Const_CreateBy.Image")));
            this.Pic_Const_CreateBy.Location = new System.Drawing.Point(216, 221);
            this.Pic_Const_CreateBy.Name = "Pic_Const_CreateBy";
            this.Pic_Const_CreateBy.Size = new System.Drawing.Size(30, 16);
            this.Pic_Const_CreateBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Const_CreateBy.TabIndex = 42;
            this.Pic_Const_CreateBy.TabStop = false;
            // 
            // Pic_Const_ApplicationFees
            // 
            this.Pic_Const_ApplicationFees.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Const_ApplicationFees.Image")));
            this.Pic_Const_ApplicationFees.Location = new System.Drawing.Point(217, 186);
            this.Pic_Const_ApplicationFees.Name = "Pic_Const_ApplicationFees";
            this.Pic_Const_ApplicationFees.Size = new System.Drawing.Size(30, 16);
            this.Pic_Const_ApplicationFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Const_ApplicationFees.TabIndex = 41;
            this.Pic_Const_ApplicationFees.TabStop = false;
            // 
            // Pic_Const_LicenseClass
            // 
            this.Pic_Const_LicenseClass.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Const_LicenseClass.Image")));
            this.Pic_Const_LicenseClass.Location = new System.Drawing.Point(216, 142);
            this.Pic_Const_LicenseClass.Name = "Pic_Const_LicenseClass";
            this.Pic_Const_LicenseClass.Size = new System.Drawing.Size(30, 21);
            this.Pic_Const_LicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Const_LicenseClass.TabIndex = 40;
            this.Pic_Const_LicenseClass.TabStop = false;
            // 
            // Pic_Const_ApplicationDate
            // 
            this.Pic_Const_ApplicationDate.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Const_ApplicationDate.Image")));
            this.Pic_Const_ApplicationDate.Location = new System.Drawing.Point(216, 107);
            this.Pic_Const_ApplicationDate.Name = "Pic_Const_ApplicationDate";
            this.Pic_Const_ApplicationDate.Size = new System.Drawing.Size(30, 16);
            this.Pic_Const_ApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Const_ApplicationDate.TabIndex = 39;
            this.Pic_Const_ApplicationDate.TabStop = false;
            // 
            // Pic_PersonID
            // 
            this.Pic_PersonID.Image = global::DVLD.Properties.Resources.id;
            this.Pic_PersonID.Location = new System.Drawing.Point(216, 67);
            this.Pic_PersonID.Name = "Pic_PersonID";
            this.Pic_PersonID.Size = new System.Drawing.Size(30, 16);
            this.Pic_PersonID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_PersonID.TabIndex = 38;
            this.Pic_PersonID.TabStop = false;
            // 
            // ComboBox_LicenseClass
            // 
            this.ComboBox_LicenseClass.FormattingEnabled = true;
            this.ComboBox_LicenseClass.Location = new System.Drawing.Point(255, 142);
            this.ComboBox_LicenseClass.Name = "ComboBox_LicenseClass";
            this.ComboBox_LicenseClass.Size = new System.Drawing.Size(198, 21);
            this.ComboBox_LicenseClass.TabIndex = 37;
            // 
            // Label_Const_LicenseClass
            // 
            this.Label_Const_LicenseClass.AutoSize = true;
            this.Label_Const_LicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_LicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_LicenseClass.Location = new System.Drawing.Point(97, 142);
            this.Label_Const_LicenseClass.Name = "Label_Const_LicenseClass";
            this.Label_Const_LicenseClass.Size = new System.Drawing.Size(94, 16);
            this.Label_Const_LicenseClass.TabIndex = 36;
            this.Label_Const_LicenseClass.Text = "License Class:";
            // 
            // Label_Variable_CreateBy
            // 
            this.Label_Variable_CreateBy.AutoSize = true;
            this.Label_Variable_CreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_CreateBy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Variable_CreateBy.Location = new System.Drawing.Point(252, 221);
            this.Label_Variable_CreateBy.Name = "Label_Variable_CreateBy";
            this.Label_Variable_CreateBy.Size = new System.Drawing.Size(79, 16);
            this.Label_Variable_CreateBy.TabIndex = 35;
            this.Label_Variable_CreateBy.Text = "........................";
            this.Label_Variable_CreateBy.Click += new System.EventHandler(this.Label_Variable_CreateBy_Click);
            // 
            // Label_Const_CreateBy
            // 
            this.Label_Const_CreateBy.AutoSize = true;
            this.Label_Const_CreateBy.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_CreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_CreateBy.Location = new System.Drawing.Point(97, 221);
            this.Label_Const_CreateBy.Name = "Label_Const_CreateBy";
            this.Label_Const_CreateBy.Size = new System.Drawing.Size(72, 16);
            this.Label_Const_CreateBy.TabIndex = 34;
            this.Label_Const_CreateBy.Text = "Create By: ";
            // 
            // Label_Variable_ApplicationFees
            // 
            this.Label_Variable_ApplicationFees.AutoSize = true;
            this.Label_Variable_ApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_ApplicationFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Variable_ApplicationFees.Location = new System.Drawing.Point(252, 186);
            this.Label_Variable_ApplicationFees.Name = "Label_Variable_ApplicationFees";
            this.Label_Variable_ApplicationFees.Size = new System.Drawing.Size(79, 16);
            this.Label_Variable_ApplicationFees.TabIndex = 33;
            this.Label_Variable_ApplicationFees.Text = "........................";
            // 
            // Label_Const_ApplicationFees
            // 
            this.Label_Const_ApplicationFees.AutoSize = true;
            this.Label_Const_ApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_ApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_ApplicationFees.Location = new System.Drawing.Point(97, 186);
            this.Label_Const_ApplicationFees.Name = "Label_Const_ApplicationFees";
            this.Label_Const_ApplicationFees.Size = new System.Drawing.Size(114, 16);
            this.Label_Const_ApplicationFees.TabIndex = 32;
            this.Label_Const_ApplicationFees.Text = "Application Fees: ";
            // 
            // Label_Variable_ApplicationDate
            // 
            this.Label_Variable_ApplicationDate.AutoSize = true;
            this.Label_Variable_ApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_ApplicationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Variable_ApplicationDate.Location = new System.Drawing.Point(252, 107);
            this.Label_Variable_ApplicationDate.Name = "Label_Variable_ApplicationDate";
            this.Label_Variable_ApplicationDate.Size = new System.Drawing.Size(79, 16);
            this.Label_Variable_ApplicationDate.TabIndex = 31;
            this.Label_Variable_ApplicationDate.Text = "........................";
            // 
            // Label_Const_ApplicationDate
            // 
            this.Label_Const_ApplicationDate.AutoSize = true;
            this.Label_Const_ApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_ApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_ApplicationDate.Location = new System.Drawing.Point(97, 107);
            this.Label_Const_ApplicationDate.Name = "Label_Const_ApplicationDate";
            this.Label_Const_ApplicationDate.Size = new System.Drawing.Size(109, 16);
            this.Label_Const_ApplicationDate.TabIndex = 30;
            this.Label_Const_ApplicationDate.Text = "Applcation Date: ";
            // 
            // Label_Variable_DL_AppID
            // 
            this.Label_Variable_DL_AppID.AutoSize = true;
            this.Label_Variable_DL_AppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_DL_AppID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Variable_DL_AppID.Location = new System.Drawing.Point(252, 67);
            this.Label_Variable_DL_AppID.Name = "Label_Variable_DL_AppID";
            this.Label_Variable_DL_AppID.Size = new System.Drawing.Size(79, 16);
            this.Label_Variable_DL_AppID.TabIndex = 29;
            this.Label_Variable_DL_AppID.Text = "........................";
            this.Label_Variable_DL_AppID.Click += new System.EventHandler(this.Label_Variable_UserID_Click);
            // 
            // Label_Const_DL_AppID
            // 
            this.Label_Const_DL_AppID.AutoSize = true;
            this.Label_Const_DL_AppID.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_DL_AppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_DL_AppID.Location = new System.Drawing.Point(97, 67);
            this.Label_Const_DL_AppID.Name = "Label_Const_DL_AppID";
            this.Label_Const_DL_AppID.Size = new System.Drawing.Size(122, 16);
            this.Label_Const_DL_AppID.TabIndex = 28;
            this.Label_Const_DL_AppID.Text = "D.L Application  ID: ";
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(194, 40);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(481, 31);
            this.Label_Const_FormTitle.TabIndex = 2;
            this.Label_Const_FormTitle.Text = "New Local Driving License Application ";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Enabled = false;
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.Image")));
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Save.Location = new System.Drawing.Point(762, 549);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(76, 25);
            this.Btn_Save.TabIndex = 14;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Close.Location = new System.Drawing.Point(680, 549);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(76, 25);
            this.Btn_Close.TabIndex = 13;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Frm_NewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 585);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Controls.Add(this.TC_PersonalInfo);
            this.Name = "Frm_NewLocalLicense";
            this.Text = "New Local License";
            this.Load += new System.EventHandler(this.Frm_NewLocalLicense_Load);
            this.TC_PersonalInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_AddNewPerson)).EndInit();
            this.AppInfo.ResumeLayout(false);
            this.AppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Const_CreateBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Const_ApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Const_LicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Const_ApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_PersonID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TC_PersonalInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private User_Controls.UC_Filter UC_Filter;
        private User_Controls.UC_ShowPersonInfo UC_ShowPersonInfo;
        private System.Windows.Forms.TabPage AppInfo;
        private System.Windows.Forms.Label Label_Const_FormTitle;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.PictureBox Pic_AddNewPerson;
        private System.Windows.Forms.Label Label_Const_LicenseClass;
        private System.Windows.Forms.Label Label_Variable_CreateBy;
        private System.Windows.Forms.Label Label_Const_CreateBy;
        private System.Windows.Forms.Label Label_Variable_ApplicationFees;
        private System.Windows.Forms.Label Label_Const_ApplicationFees;
        private System.Windows.Forms.Label Label_Variable_ApplicationDate;
        private System.Windows.Forms.Label Label_Const_ApplicationDate;
        private System.Windows.Forms.Label Label_Variable_DL_AppID;
        private System.Windows.Forms.Label Label_Const_DL_AppID;
        private System.Windows.Forms.ComboBox ComboBox_LicenseClass;
        private System.Windows.Forms.PictureBox Pic_Const_CreateBy;
        private System.Windows.Forms.PictureBox Pic_Const_ApplicationFees;
        private System.Windows.Forms.PictureBox Pic_Const_LicenseClass;
        private System.Windows.Forms.PictureBox Pic_Const_ApplicationDate;
        private System.Windows.Forms.PictureBox Pic_PersonID;
    }
}