namespace DVLD.Sub_Forms.Application.Detained_License
{
    partial class Frm_ReleaseDetainLicense
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
            this.Label_Const_FormTitle = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Detain = new System.Windows.Forms.Button();
            this.LinkLabel_LicenseInfo = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_LicenseHistory = new System.Windows.Forms.LinkLabel();
            this.UC_ShowDetainInfo = new DVLD.User_Controls.Detain.UC_ShowDetainInfo();
            this.UC_LicenseInfo = new DVLD.User_Controls.LicenseInfo.UC_LicenseInfo();
            this.UC_LicenseFilter = new DVLD.User_Controls.UC_LicenseFilter();
            this.SuspendLayout();
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(240, 21);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(301, 31);
            this.Label_Const_FormTitle.TabIndex = 43;
            this.Label_Const_FormTitle.Text = "Release Detain License";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(597, 784);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(92, 37);
            this.Btn_Close.TabIndex = 47;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Detain
            // 
            this.Btn_Detain.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Detain.Location = new System.Drawing.Point(695, 784);
            this.Btn_Detain.Name = "Btn_Detain";
            this.Btn_Detain.Size = new System.Drawing.Size(90, 37);
            this.Btn_Detain.TabIndex = 46;
            this.Btn_Detain.Text = "Release";
            this.Btn_Detain.UseVisualStyleBackColor = true;
            this.Btn_Detain.Click += new System.EventHandler(this.Btn_Release_Click);
            // 
            // LinkLabel_LicenseInfo
            // 
            this.LinkLabel_LicenseInfo.AutoSize = true;
            this.LinkLabel_LicenseInfo.Enabled = false;
            this.LinkLabel_LicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_LicenseInfo.Location = new System.Drawing.Point(206, 791);
            this.LinkLabel_LicenseInfo.Name = "LinkLabel_LicenseInfo";
            this.LinkLabel_LicenseInfo.Size = new System.Drawing.Size(144, 20);
            this.LinkLabel_LicenseInfo.TabIndex = 45;
            this.LinkLabel_LicenseInfo.TabStop = true;
            this.LinkLabel_LicenseInfo.Text = "Show  License Info";
            this.LinkLabel_LicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LicenseInfo_LinkClicked);
            // 
            // LinkLabel_LicenseHistory
            // 
            this.LinkLabel_LicenseHistory.AutoSize = true;
            this.LinkLabel_LicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_LicenseHistory.Location = new System.Drawing.Point(21, 791);
            this.LinkLabel_LicenseHistory.Name = "LinkLabel_LicenseHistory";
            this.LinkLabel_LicenseHistory.Size = new System.Drawing.Size(169, 20);
            this.LinkLabel_LicenseHistory.TabIndex = 44;
            this.LinkLabel_LicenseHistory.TabStop = true;
            this.LinkLabel_LicenseHistory.Text = "Show Licenses History";
            this.LinkLabel_LicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LicenseHistory_LinkClicked);
            // 
            // UC_ShowDetainInfo
            // 
            this.UC_ShowDetainInfo.Location = new System.Drawing.Point(108, 522);
            this.UC_ShowDetainInfo.Name = "UC_ShowDetainInfo";
            this.UC_ShowDetainInfo.Size = new System.Drawing.Size(581, 232);
            this.UC_ShowDetainInfo.TabIndex = 48;
            // 
            // UC_LicenseInfo
            // 
            this.UC_LicenseInfo.Location = new System.Drawing.Point(25, 147);
            this.UC_LicenseInfo.Name = "UC_LicenseInfo";
            this.UC_LicenseInfo.Size = new System.Drawing.Size(751, 369);
            this.UC_LicenseInfo.TabIndex = 42;
            // 
            // UC_LicenseFilter
            // 
            this.UC_LicenseFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_LicenseFilter.Location = new System.Drawing.Point(198, 56);
            this.UC_LicenseFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UC_LicenseFilter.Name = "UC_LicenseFilter";
            this.UC_LicenseFilter.Size = new System.Drawing.Size(361, 84);
            this.UC_LicenseFilter.TabIndex = 41;
            this.UC_LicenseFilter.evSendResult += new System.Action<int>(this.UC_LicenseFilter_evSendResult);
            // 
            // Frm_ReleaseDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 835);
            this.Controls.Add(this.UC_ShowDetainInfo);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Detain);
            this.Controls.Add(this.LinkLabel_LicenseInfo);
            this.Controls.Add(this.LinkLabel_LicenseHistory);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Controls.Add(this.UC_LicenseInfo);
            this.Controls.Add(this.UC_LicenseFilter);
            this.Name = "Frm_ReleaseDetainLicense";
            this.Text = "Frm_RelaeseDetainLicense";
            this.Load += new System.EventHandler(this.Frm_ReleaseDetainLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Const_FormTitle;
        private User_Controls.LicenseInfo.UC_LicenseInfo UC_LicenseInfo;
        private User_Controls.UC_LicenseFilter UC_LicenseFilter;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Detain;
        private System.Windows.Forms.LinkLabel LinkLabel_LicenseInfo;
        private System.Windows.Forms.LinkLabel LinkLabel_LicenseHistory;
        private User_Controls.Detain.UC_ShowDetainInfo UC_ShowDetainInfo;
    }
}