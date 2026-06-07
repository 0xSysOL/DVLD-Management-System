namespace DVLD.Sub_Forms.Application.Detained_License
{
    partial class Frm_DetainLicense
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
            this.LinkLabel_LicenseInfo = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_LicenseHistory = new System.Windows.Forms.LinkLabel();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Detain = new System.Windows.Forms.Button();
            this.UC_DetainInfo = new DVLD.User_Controls.Detain.UC_DetainInfo();
            this.UC_LicenseInfo = new DVLD.User_Controls.LicenseInfo.UC_LicenseInfo();
            this.UC_LicenseFilter = new DVLD.User_Controls.UC_LicenseFilter();
            this.SuspendLayout();
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(312, 34);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(194, 31);
            this.Label_Const_FormTitle.TabIndex = 35;
            this.Label_Const_FormTitle.Text = "Detain License";
            // 
            // LinkLabel_LicenseInfo
            // 
            this.LinkLabel_LicenseInfo.AutoSize = true;
            this.LinkLabel_LicenseInfo.Enabled = false;
            this.LinkLabel_LicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_LicenseInfo.Location = new System.Drawing.Point(197, 783);
            this.LinkLabel_LicenseInfo.Name = "LinkLabel_LicenseInfo";
            this.LinkLabel_LicenseInfo.Size = new System.Drawing.Size(144, 20);
            this.LinkLabel_LicenseInfo.TabIndex = 37;
            this.LinkLabel_LicenseInfo.TabStop = true;
            this.LinkLabel_LicenseInfo.Text = "Show  License Info";
            this.LinkLabel_LicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LicenseInfo_LinkClicked);
            // 
            // LinkLabel_LicenseHistory
            // 
            this.LinkLabel_LicenseHistory.AutoSize = true;
            this.LinkLabel_LicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_LicenseHistory.Location = new System.Drawing.Point(12, 783);
            this.LinkLabel_LicenseHistory.Name = "LinkLabel_LicenseHistory";
            this.LinkLabel_LicenseHistory.Size = new System.Drawing.Size(169, 20);
            this.LinkLabel_LicenseHistory.TabIndex = 36;
            this.LinkLabel_LicenseHistory.TabStop = true;
            this.LinkLabel_LicenseHistory.Text = "Show Licenses History";
            this.LinkLabel_LicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LicenseHistory_LinkClicked);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(588, 776);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(92, 37);
            this.Btn_Close.TabIndex = 39;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // Btn_Detain
            // 
            this.Btn_Detain.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Detain.Location = new System.Drawing.Point(686, 776);
            this.Btn_Detain.Name = "Btn_Detain";
            this.Btn_Detain.Size = new System.Drawing.Size(90, 37);
            this.Btn_Detain.TabIndex = 38;
            this.Btn_Detain.Text = "Detain";
            this.Btn_Detain.UseVisualStyleBackColor = true;
            this.Btn_Detain.Click += new System.EventHandler(this.Btn_Detain_Click);
            // 
            // UC_DetainInfo
            // 
            this.UC_DetainInfo.Location = new System.Drawing.Point(150, 544);
            this.UC_DetainInfo.Name = "UC_DetainInfo";
            this.UC_DetainInfo.Size = new System.Drawing.Size(464, 199);
            this.UC_DetainInfo.TabIndex = 40;
            // 
            // UC_LicenseInfo
            // 
            this.UC_LicenseInfo.Location = new System.Drawing.Point(37, 169);
            this.UC_LicenseInfo.Name = "UC_LicenseInfo";
            this.UC_LicenseInfo.Size = new System.Drawing.Size(751, 369);
            this.UC_LicenseInfo.TabIndex = 3;
            // 
            // UC_LicenseFilter
            // 
            this.UC_LicenseFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_LicenseFilter.Location = new System.Drawing.Point(210, 78);
            this.UC_LicenseFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UC_LicenseFilter.Name = "UC_LicenseFilter";
            this.UC_LicenseFilter.Size = new System.Drawing.Size(361, 84);
            this.UC_LicenseFilter.TabIndex = 2;
            this.UC_LicenseFilter.evSendResult += new System.Action<int>(this.UC_LicenseFilter_evSendResult);
            // 
            // Frm_DetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 827);
            this.Controls.Add(this.UC_DetainInfo);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Detain);
            this.Controls.Add(this.LinkLabel_LicenseInfo);
            this.Controls.Add(this.LinkLabel_LicenseHistory);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Controls.Add(this.UC_LicenseInfo);
            this.Controls.Add(this.UC_LicenseFilter);
            this.Name = "Frm_DetainLicense";
            this.Text = "Frm_DetainLicense";
            this.Load += new System.EventHandler(this.Frm_DetainLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.LicenseInfo.UC_LicenseInfo UC_LicenseInfo;
        private User_Controls.UC_LicenseFilter UC_LicenseFilter;
        private System.Windows.Forms.Label Label_Const_FormTitle;
        private System.Windows.Forms.LinkLabel LinkLabel_LicenseInfo;
        private System.Windows.Forms.LinkLabel LinkLabel_LicenseHistory;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Detain;
        private User_Controls.Detain.UC_DetainInfo UC_DetainInfo;
    }
}