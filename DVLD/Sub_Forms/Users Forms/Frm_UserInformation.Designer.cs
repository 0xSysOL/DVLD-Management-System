namespace DVLD.Sub_Forms.Users_Forms
{
    partial class Frm_UserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UserInformation));
            this.UC_LoginInfo_2 = new DVLD.User_Controls.Users_User_Control.UC_LoginInfo();
            this.UC_ShowPersonInfo_1 = new DVLD.User_Controls.UC_ShowPersonInfo();
            this.SuspendLayout();
            // 
            // UC_LoginInfo_2
            // 
            this.UC_LoginInfo_2.Location = new System.Drawing.Point(122, 306);
            this.UC_LoginInfo_2.Name = "UC_LoginInfo_2";
            this.UC_LoginInfo_2.Size = new System.Drawing.Size(571, 113);
            this.UC_LoginInfo_2.TabIndex = 1;
            this.UC_LoginInfo_2.Load += new System.EventHandler(this.UC_LoginInfo_2_Load);
            // 
            // UC_ShowPersonInfo_1
            // 
            this.UC_ShowPersonInfo_1.Location = new System.Drawing.Point(26, 0);
            this.UC_ShowPersonInfo_1.Name = "UC_ShowPersonInfo_1";
            this.UC_ShowPersonInfo_1.Size = new System.Drawing.Size(751, 341);
            this.UC_ShowPersonInfo_1.TabIndex = 0;
            this.UC_ShowPersonInfo_1.SendRequestToGetImage += new System.Action<bool, string>(this.UC_ShowPersonInfo_1_SendRequestToGetImage);
            this.UC_ShowPersonInfo_1.Load += new System.EventHandler(this.UC_ShowPersonInfo_1_Load);
            // 
            // Frm_UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UC_LoginInfo_2);
            this.Controls.Add(this.UC_ShowPersonInfo_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_UserInformation";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.Frm_UserInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.UC_ShowPersonInfo UC_ShowPersonInfo_1;
        private User_Controls.Users_User_Control.UC_LoginInfo UC_LoginInfo_2;
    }
}