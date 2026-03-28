namespace DVLD.Sub_Forms.Users_Forms
{
    partial class Frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChangePassword));
            this.TB_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_CurrentPassword = new System.Windows.Forms.TextBox();
            this.Pic_ConfirmPassword = new System.Windows.Forms.PictureBox();
            this.Pic_Password = new System.Windows.Forms.PictureBox();
            this.Label_Const_ConfirmPass = new System.Windows.Forms.Label();
            this.Label_Const_Password = new System.Windows.Forms.Label();
            this.Label_Const_CurrentPassword = new System.Windows.Forms.Label();
            this.Pic_CurrentPassword = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.uC_ShowPersonInfo = new DVLD.User_Controls.UC_ShowPersonInfo();
            this._UC_ChangeUserPassword = new DVLD.User_Controls.Users_User_Control.UC_LoginInfo();
            this.ErrorProfider_1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_CurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProfider_1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_ConfirmPassword
            // 
            this.TB_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ConfirmPassword.Location = new System.Drawing.Point(274, 592);
            this.TB_ConfirmPassword.Name = "TB_ConfirmPassword";
            this.TB_ConfirmPassword.PasswordChar = '●';
            this.TB_ConfirmPassword.Size = new System.Drawing.Size(100, 21);
            this.TB_ConfirmPassword.TabIndex = 49;
            this.TB_ConfirmPassword.TextChanged += new System.EventHandler(this.TB_ConfirmPassword_TextChanged);
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(274, 554);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '●';
            this.TB_Password.Size = new System.Drawing.Size(100, 21);
            this.TB_Password.TabIndex = 48;
            this.TB_Password.TextChanged += new System.EventHandler(this.TB_ConfirmPassword_TextChanged);
            // 
            // TB_CurrentPassword
            // 
            this.TB_CurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CurrentPassword.Location = new System.Drawing.Point(274, 510);
            this.TB_CurrentPassword.Name = "TB_CurrentPassword";
            this.TB_CurrentPassword.PasswordChar = '●';
            this.TB_CurrentPassword.Size = new System.Drawing.Size(100, 21);
            this.TB_CurrentPassword.TabIndex = 47;
            this.TB_CurrentPassword.TextChanged += new System.EventHandler(this.TB_CurrentPassword_TextChanged);
            // 
            // Pic_ConfirmPassword
            // 
            this.Pic_ConfirmPassword.Image = global::DVLD.Properties.Resources.approve;
            this.Pic_ConfirmPassword.Location = new System.Drawing.Point(104, 592);
            this.Pic_ConfirmPassword.Name = "Pic_ConfirmPassword";
            this.Pic_ConfirmPassword.Size = new System.Drawing.Size(30, 16);
            this.Pic_ConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_ConfirmPassword.TabIndex = 46;
            this.Pic_ConfirmPassword.TabStop = false;
            // 
            // Pic_Password
            // 
            this.Pic_Password.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Password.Image")));
            this.Pic_Password.Location = new System.Drawing.Point(156, 554);
            this.Pic_Password.Name = "Pic_Password";
            this.Pic_Password.Size = new System.Drawing.Size(30, 16);
            this.Pic_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Password.TabIndex = 45;
            this.Pic_Password.TabStop = false;
            // 
            // Label_Const_ConfirmPass
            // 
            this.Label_Const_ConfirmPass.AutoSize = true;
            this.Label_Const_ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_ConfirmPass.Location = new System.Drawing.Point(140, 592);
            this.Label_Const_ConfirmPass.Name = "Label_Const_ConfirmPass";
            this.Label_Const_ConfirmPass.Size = new System.Drawing.Size(118, 16);
            this.Label_Const_ConfirmPass.TabIndex = 43;
            this.Label_Const_ConfirmPass.Text = "Confirm Password:";
            // 
            // Label_Const_Password
            // 
            this.Label_Const_Password.AutoSize = true;
            this.Label_Const_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Password.Location = new System.Drawing.Point(192, 554);
            this.Label_Const_Password.Name = "Label_Const_Password";
            this.Label_Const_Password.Size = new System.Drawing.Size(70, 16);
            this.Label_Const_Password.TabIndex = 42;
            this.Label_Const_Password.Text = "Password:";
            // 
            // Label_Const_CurrentPassword
            // 
            this.Label_Const_CurrentPassword.AutoSize = true;
            this.Label_Const_CurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_CurrentPassword.Location = new System.Drawing.Point(156, 510);
            this.Label_Const_CurrentPassword.Name = "Label_Const_CurrentPassword";
            this.Label_Const_CurrentPassword.Size = new System.Drawing.Size(112, 16);
            this.Label_Const_CurrentPassword.TabIndex = 41;
            this.Label_Const_CurrentPassword.Text = "Current Password";
            // 
            // Pic_CurrentPassword
            // 
            this.Pic_CurrentPassword.Image = ((System.Drawing.Image)(resources.GetObject("Pic_CurrentPassword.Image")));
            this.Pic_CurrentPassword.Location = new System.Drawing.Point(120, 510);
            this.Pic_CurrentPassword.Name = "Pic_CurrentPassword";
            this.Pic_CurrentPassword.Size = new System.Drawing.Size(30, 16);
            this.Pic_CurrentPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_CurrentPassword.TabIndex = 50;
            this.Pic_CurrentPassword.TabStop = false;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(446, 626);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(90, 28);
            this.Btn_Close.TabIndex = 52;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(542, 626);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(90, 28);
            this.Btn_Save.TabIndex = 51;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // uC_ShowPersonInfo
            // 
            this.uC_ShowPersonInfo.Location = new System.Drawing.Point(22, 28);
            this.uC_ShowPersonInfo.Name = "uC_ShowPersonInfo";
            this.uC_ShowPersonInfo.Size = new System.Drawing.Size(751, 341);
            this.uC_ShowPersonInfo.TabIndex = 53;
            this.uC_ShowPersonInfo.SendRequestToGetImage += new System.Action<bool, string>(this.uC_ShowPersonInfo_SendRequestToGetImage);
            // 
            // _UC_ChangeUserPassword
            // 
            this._UC_ChangeUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._UC_ChangeUserPassword.Location = new System.Drawing.Point(104, 362);
            this._UC_ChangeUserPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._UC_ChangeUserPassword.Name = "_UC_ChangeUserPassword";
            this._UC_ChangeUserPassword.Size = new System.Drawing.Size(587, 101);
            this._UC_ChangeUserPassword.TabIndex = 0;
            // 
            // ErrorProfider_1
            // 
            this.ErrorProfider_1.BlinkRate = 0;
            this.ErrorProfider_1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProfider_1.ContainerControl = this;
            this.ErrorProfider_1.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProfider_1.Icon")));
            // 
            // Frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.uC_ShowPersonInfo);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Pic_CurrentPassword);
            this.Controls.Add(this.TB_ConfirmPassword);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_CurrentPassword);
            this.Controls.Add(this.Pic_ConfirmPassword);
            this.Controls.Add(this.Pic_Password);
            this.Controls.Add(this.Label_Const_ConfirmPass);
            this.Controls.Add(this.Label_Const_Password);
            this.Controls.Add(this.Label_Const_CurrentPassword);
            this.Controls.Add(this._UC_ChangeUserPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ChangePassword";
            this.Text = "Change User Password";
            this.Load += new System.EventHandler(this.Frm_ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_CurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProfider_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Users_User_Control.UC_LoginInfo _UC_ChangeUserPassword;
        private System.Windows.Forms.TextBox TB_ConfirmPassword;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_CurrentPassword;
        private System.Windows.Forms.PictureBox Pic_ConfirmPassword;
        private System.Windows.Forms.PictureBox Pic_Password;
        private System.Windows.Forms.Label Label_Const_ConfirmPass;
        private System.Windows.Forms.Label Label_Const_Password;
        private System.Windows.Forms.Label Label_Const_CurrentPassword;
        private System.Windows.Forms.PictureBox Pic_CurrentPassword;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Save;
        private User_Controls.UC_ShowPersonInfo uC_ShowPersonInfo;
        private System.Windows.Forms.ErrorProvider ErrorProfider_1;
    }
}