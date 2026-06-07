namespace DVLD.Sub_Forms.Application
{
    partial class Frm_ApplicationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ApplicationDetails));
            this.UC_ApplicationBasic_Info = new DVLD.User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_ApplicationBasic_Info();
            this.UC_DrivingLicenseApplication_Info = new DVLD.User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_DrivingLicenseApplication_Info();
            this.Pic_Form = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Form)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_ApplicationBasic_Info
            // 
            this.UC_ApplicationBasic_Info.Location = new System.Drawing.Point(12, 209);
            this.UC_ApplicationBasic_Info.Name = "UC_ApplicationBasic_Info";
            this.UC_ApplicationBasic_Info.Size = new System.Drawing.Size(764, 229);
            this.UC_ApplicationBasic_Info.TabIndex = 0;
            this.UC_ApplicationBasic_Info.SendEventToOpenPersonInfo += new System.Action(this.uC_ApplicationBasic_Info1_SendEventToOpenPersonInfo);
            // 
            // UC_DrivingLicenseApplication_Info
            // 
            this.UC_DrivingLicenseApplication_Info.Location = new System.Drawing.Point(12, 45);
            this.UC_DrivingLicenseApplication_Info.Name = "UC_DrivingLicenseApplication_Info";
            this.UC_DrivingLicenseApplication_Info.Size = new System.Drawing.Size(780, 130);
            this.UC_DrivingLicenseApplication_Info.TabIndex = 1;
            // 
            // Pic_Form
            // 
            this.Pic_Form.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Form.Image")));
            this.Pic_Form.Location = new System.Drawing.Point(206, 30);
            this.Pic_Form.Name = "Pic_Form";
            this.Pic_Form.Size = new System.Drawing.Size(400, 173);
            this.Pic_Form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Form.TabIndex = 20;
            this.Pic_Form.TabStop = false;
            this.Pic_Form.Visible = false;
            // 
            // Frm_ApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.Pic_Form);
            this.Controls.Add(this.UC_DrivingLicenseApplication_Info);
            this.Controls.Add(this.UC_ApplicationBasic_Info);
            this.Name = "Frm_ApplicationDetails";
            this.Text = "Application Details";
            this.Load += new System.EventHandler(this.Frm_ApplicationDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Form)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_ApplicationBasic_Info UC_ApplicationBasic_Info;
        private User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_DrivingLicenseApplication_Info UC_DrivingLicenseApplication_Info;
        private System.Windows.Forms.PictureBox Pic_Form;
    }
}