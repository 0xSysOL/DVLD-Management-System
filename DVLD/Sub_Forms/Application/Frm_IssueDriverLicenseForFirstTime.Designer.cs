namespace DVLD.Sub_Forms.Application
{
    partial class Frm_IssueDriverLicenseForFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IssueDriverLicenseForFirstTime));
            this.TB_Note = new System.Windows.Forms.TextBox();
            this.Label_Const_Note = new System.Windows.Forms.Label();
            this.Btn_Issue = new System.Windows.Forms.Button();
            this.UC_DrivingLicenseApplication_Info = new DVLD.User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_DrivingLicenseApplication_Info();
            this.UC_ApplicationBasic_Info = new DVLD.User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_ApplicationBasic_Info();
            this.Label_Variable_FormTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pic_NewLocalDrivingLicense = new System.Windows.Forms.PictureBox();
            this.Label_Const_LicensePrice = new System.Windows.Forms.Label();
            this.Label_Variable_LicensePrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_NewLocalDrivingLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Note
            // 
            this.TB_Note.Location = new System.Drawing.Point(154, 592);
            this.TB_Note.Multiline = true;
            this.TB_Note.Name = "TB_Note";
            this.TB_Note.Size = new System.Drawing.Size(622, 111);
            this.TB_Note.TabIndex = 2;
            // 
            // Label_Const_Note
            // 
            this.Label_Const_Note.AutoSize = true;
            this.Label_Const_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Note.Location = new System.Drawing.Point(77, 591);
            this.Label_Const_Note.Name = "Label_Const_Note";
            this.Label_Const_Note.Size = new System.Drawing.Size(44, 18);
            this.Label_Const_Note.TabIndex = 3;
            this.Label_Const_Note.Text = "Note:";
            // 
            // Btn_Issue
            // 
            this.Btn_Issue.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Issue.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Issue.Location = new System.Drawing.Point(702, 709);
            this.Btn_Issue.Name = "Btn_Issue";
            this.Btn_Issue.Size = new System.Drawing.Size(76, 25);
            this.Btn_Issue.TabIndex = 21;
            this.Btn_Issue.Text = "Issue";
            this.Btn_Issue.UseVisualStyleBackColor = true;
            this.Btn_Issue.Click += new System.EventHandler(this.Btn_Issue_Click);
            // 
            // UC_DrivingLicenseApplication_Info
            // 
            this.UC_DrivingLicenseApplication_Info.Location = new System.Drawing.Point(8, 165);
            this.UC_DrivingLicenseApplication_Info.Name = "UC_DrivingLicenseApplication_Info";
            this.UC_DrivingLicenseApplication_Info.Size = new System.Drawing.Size(780, 130);
            this.UC_DrivingLicenseApplication_Info.TabIndex = 1;
            this.UC_DrivingLicenseApplication_Info.Load += new System.EventHandler(this.uC_DrivingLicenseApplication_Info1_Load);
            // 
            // UC_ApplicationBasic_Info
            // 
            this.UC_ApplicationBasic_Info.Location = new System.Drawing.Point(12, 301);
            this.UC_ApplicationBasic_Info.Name = "UC_ApplicationBasic_Info";
            this.UC_ApplicationBasic_Info.Size = new System.Drawing.Size(764, 229);
            this.UC_ApplicationBasic_Info.TabIndex = 0;
            this.UC_ApplicationBasic_Info.SendEventToOpenPersonInfo += new System.Action(this.UC_ApplicationBasic_Info_SendEventToOpenPersonInfo);
            this.UC_ApplicationBasic_Info.Load += new System.EventHandler(this.UC_ApplicationBasic_Info_Load);
            // 
            // Label_Variable_FormTitle
            // 
            this.Label_Variable_FormTitle.AutoSize = true;
            this.Label_Variable_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Variable_FormTitle.Location = new System.Drawing.Point(164, 131);
            this.Label_Variable_FormTitle.Name = "Label_Variable_FormTitle";
            this.Label_Variable_FormTitle.Size = new System.Drawing.Size(419, 31);
            this.Label_Variable_FormTitle.TabIndex = 23;
            this.Label_Variable_FormTitle.Text = "Issue Driving License (First Time)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.drivers_license;
            this.pictureBox1.Location = new System.Drawing.Point(286, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Close.Location = new System.Drawing.Point(620, 709);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(76, 25);
            this.Btn_Close.TabIndex = 20;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // Pic_NewLocalDrivingLicense
            // 
            this.Pic_NewLocalDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("Pic_NewLocalDrivingLicense.Image")));
            this.Pic_NewLocalDrivingLicense.Location = new System.Drawing.Point(118, 592);
            this.Pic_NewLocalDrivingLicense.Name = "Pic_NewLocalDrivingLicense";
            this.Pic_NewLocalDrivingLicense.Size = new System.Drawing.Size(30, 17);
            this.Pic_NewLocalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_NewLocalDrivingLicense.TabIndex = 19;
            this.Pic_NewLocalDrivingLicense.TabStop = false;
            // 
            // Label_Const_LicensePrice
            // 
            this.Label_Const_LicensePrice.AutoSize = true;
            this.Label_Const_LicensePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_LicensePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_LicensePrice.Location = new System.Drawing.Point(164, 547);
            this.Label_Const_LicensePrice.Name = "Label_Const_LicensePrice";
            this.Label_Const_LicensePrice.Size = new System.Drawing.Size(185, 31);
            this.Label_Const_LicensePrice.TabIndex = 24;
            this.Label_Const_LicensePrice.Text = "License Price:";
            this.Label_Const_LicensePrice.Click += new System.EventHandler(this.Label_Const_LicensePrice_Click);
            // 
            // Label_Variable_LicensePrice
            // 
            this.Label_Variable_LicensePrice.AutoSize = true;
            this.Label_Variable_LicensePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_LicensePrice.ForeColor = System.Drawing.Color.Black;
            this.Label_Variable_LicensePrice.Location = new System.Drawing.Point(347, 547);
            this.Label_Variable_LicensePrice.Name = "Label_Variable_LicensePrice";
            this.Label_Variable_LicensePrice.Size = new System.Drawing.Size(83, 31);
            this.Label_Variable_LicensePrice.TabIndex = 25;
            this.Label_Variable_LicensePrice.Text = "Value";
            // 
            // Frm_IssueDriverLicenseForFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.Label_Variable_LicensePrice);
            this.Controls.Add(this.Label_Const_LicensePrice);
            this.Controls.Add(this.Label_Variable_FormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Issue);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Pic_NewLocalDrivingLicense);
            this.Controls.Add(this.Label_Const_Note);
            this.Controls.Add(this.TB_Note);
            this.Controls.Add(this.UC_DrivingLicenseApplication_Info);
            this.Controls.Add(this.UC_ApplicationBasic_Info);
            this.Name = "Frm_IssueDriverLicenseForFirstTime";
            this.Text = "Issue Driver License For First Time";
            this.Load += new System.EventHandler(this.Frm_IssueDriverLicenseForFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_NewLocalDrivingLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_ApplicationBasic_Info UC_ApplicationBasic_Info;
        private User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_DrivingLicenseApplication_Info UC_DrivingLicenseApplication_Info;
        private System.Windows.Forms.TextBox TB_Note;
        private System.Windows.Forms.Label Label_Const_Note;
        private System.Windows.Forms.PictureBox Pic_NewLocalDrivingLicense;
        private System.Windows.Forms.Button Btn_Issue;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Label_Variable_FormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Const_LicensePrice;
        private System.Windows.Forms.Label Label_Variable_LicensePrice;
    }
}