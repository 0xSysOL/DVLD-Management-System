namespace DVLD.Sub_Forms.Application.Manage_Applications
{
    partial class Frm_NewInternationalLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NewInternationalLicenseApplication));
            this.Label_Const_FormTitle = new System.Windows.Forms.Label();
            this.Btn_Issue = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.UC_ApplicationInfo = new DVLD.User_Controls.UC_ApplicationInfo();
            this.UC_LicenseInfo = new DVLD.User_Controls.LicenseInfo.UC_LicenseInfo();
            this.UC_LicenseFilter = new DVLD.User_Controls.UC_LicenseFilter();
            this.LinkLabel_LicenseHistory = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_LicenseInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(134, 20);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(504, 31);
            this.Label_Const_FormTitle.TabIndex = 5;
            this.Label_Const_FormTitle.Text = "International Driving License Application ";
            // 
            // Btn_Issue
            // 
            this.Btn_Issue.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Issue.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Issue.Location = new System.Drawing.Point(655, 740);
            this.Btn_Issue.Name = "Btn_Issue";
            this.Btn_Issue.Size = new System.Drawing.Size(108, 29);
            this.Btn_Issue.TabIndex = 23;
            this.Btn_Issue.Text = "Issue";
            this.Btn_Issue.UseVisualStyleBackColor = true;
            this.Btn_Issue.Click += new System.EventHandler(this.Btn_Issue_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Close.Location = new System.Drawing.Point(549, 740);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(100, 29);
            this.Btn_Close.TabIndex = 22;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // UC_ApplicationInfo
            // 
            this.UC_ApplicationInfo.Location = new System.Drawing.Point(75, 486);
            this.UC_ApplicationInfo.Name = "UC_ApplicationInfo";
            this.UC_ApplicationInfo.Size = new System.Drawing.Size(608, 230);
            this.UC_ApplicationInfo.TabIndex = 7;
            this.UC_ApplicationInfo.Load += new System.EventHandler(this.UC_ApplicationInfo_Load);
            // 
            // UC_LicenseInfo
            // 
            this.UC_LicenseInfo.Location = new System.Drawing.Point(12, 126);
            this.UC_LicenseInfo.Name = "UC_LicenseInfo";
            this.UC_LicenseInfo.Size = new System.Drawing.Size(751, 372);
            this.UC_LicenseInfo.TabIndex = 6;
            this.UC_LicenseInfo.Load += new System.EventHandler(this.UC_LicenseInfo_Load);
            // 
            // UC_LicenseFilter
            // 
            this.UC_LicenseFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_LicenseFilter.Location = new System.Drawing.Point(174, 54);
            this.UC_LicenseFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UC_LicenseFilter.Name = "UC_LicenseFilter";
            this.UC_LicenseFilter.Size = new System.Drawing.Size(367, 67);
            this.UC_LicenseFilter.TabIndex = 24;
            this.UC_LicenseFilter.evSendResult += new System.Action<int>(this.UC_LicenseFilter_evSendResult);
            this.UC_LicenseFilter.Load += new System.EventHandler(this.UC_LicenseFilter_Load);
            // 
            // LinkLabel_LicenseHistory
            // 
            this.LinkLabel_LicenseHistory.AutoSize = true;
            this.LinkLabel_LicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_LicenseHistory.Location = new System.Drawing.Point(40, 749);
            this.LinkLabel_LicenseHistory.Name = "LinkLabel_LicenseHistory";
            this.LinkLabel_LicenseHistory.Size = new System.Drawing.Size(169, 20);
            this.LinkLabel_LicenseHistory.TabIndex = 25;
            this.LinkLabel_LicenseHistory.TabStop = true;
            this.LinkLabel_LicenseHistory.Text = "Show Licenses History";
            this.LinkLabel_LicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LicenseHistory_LinkClicked);
            // 
            // LinkLabel_LicenseInfo
            // 
            this.LinkLabel_LicenseInfo.AutoSize = true;
            this.LinkLabel_LicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_LicenseInfo.Location = new System.Drawing.Point(225, 749);
            this.LinkLabel_LicenseInfo.Name = "LinkLabel_LicenseInfo";
            this.LinkLabel_LicenseInfo.Size = new System.Drawing.Size(140, 20);
            this.LinkLabel_LicenseInfo.TabIndex = 26;
            this.LinkLabel_LicenseInfo.TabStop = true;
            this.LinkLabel_LicenseInfo.Text = "Show License Info";
            this.LinkLabel_LicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LicenseInfo_LinkClicked);
            // 
            // Frm_NewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 801);
            this.Controls.Add(this.LinkLabel_LicenseInfo);
            this.Controls.Add(this.LinkLabel_LicenseHistory);
            this.Controls.Add(this.UC_LicenseFilter);
            this.Controls.Add(this.Btn_Issue);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.UC_ApplicationInfo);
            this.Controls.Add(this.UC_LicenseInfo);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Name = "Frm_NewInternationalLicenseApplication";
            this.Text = "Frm_NewInternationalLicenseApplication";
            this.Load += new System.EventHandler(this.Frm_NewInternationalLicenseApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Const_FormTitle;
        private User_Controls.LicenseInfo.UC_LicenseInfo UC_LicenseInfo;
        private User_Controls.UC_ApplicationInfo UC_ApplicationInfo;
        private System.Windows.Forms.Button Btn_Issue;
        private System.Windows.Forms.Button Btn_Close;
        private User_Controls.UC_LicenseFilter UC_LicenseFilter;
        private System.Windows.Forms.LinkLabel LinkLabel_LicenseHistory;
        private System.Windows.Forms.LinkLabel LinkLabel_LicenseInfo;
    }
}