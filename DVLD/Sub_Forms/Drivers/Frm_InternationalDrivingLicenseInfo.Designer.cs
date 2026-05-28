namespace DVLD.Sub_Forms.Drivers
{
    partial class Frm_InternationalDrivingLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InternationalDrivingLicenseInfo));
            this.Label_Const_FormTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.int_LicenseInfo = new DVLD.User_Controls.LicenseInfo.Int_LicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(186, 137);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(410, 31);
            this.Label_Const_FormTitle.TabIndex = 22;
            this.Label_Const_FormTitle.Text = "International Driving License Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // int_LicenseInfo
            // 
            this.int_LicenseInfo.Location = new System.Drawing.Point(3, 212);
            this.int_LicenseInfo.Name = "int_LicenseInfo1";
            this.int_LicenseInfo.Size = new System.Drawing.Size(759, 266);
            this.int_LicenseInfo.TabIndex = 0;
            // 
            // Frm_InternationalDrivingLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 520);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.int_LicenseInfo);
            this.Name = "Frm_InternationalDrivingLicenseInfo";
            this.Text = "International Driving License Info";
            this.Load += new System.EventHandler(this.Frm_InternationalDrivingLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.LicenseInfo.Int_LicenseInfo int_LicenseInfo;
        private System.Windows.Forms.Label Label_Const_FormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}