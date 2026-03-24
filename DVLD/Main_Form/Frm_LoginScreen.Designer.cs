namespace DVLD.Sub_Forms.Users_Forms
{
    partial class Frm_LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoginScreen));
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.Pic_UserLogin = new System.Windows.Forms.PictureBox();
            this.CheckBox_RememberMe = new System.Windows.Forms.CheckBox();
            this.Label_Const_UserName = new System.Windows.Forms.Label();
            this.Label_Const_Password = new System.Windows.Forms.Label();
            this.Pic_CloseForm = new System.Windows.Forms.PictureBox();
            this.Label_Const_Version = new System.Windows.Forms.Label();
            this.ErrorProvider_Input = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_UserLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_CloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(275, 248);
            this.TB_Password.MaxLength = 25;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '●';
            this.TB_Password.Size = new System.Drawing.Size(116, 21);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Password_Validating);
            this.TB_Password.Validated += new System.EventHandler(this.TB_Password_Validated);
            // 
            // TB_UserName
            // 
            this.TB_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserName.Location = new System.Drawing.Point(275, 200);
            this.TB_UserName.MaxLength = 49;
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(116, 21);
            this.TB_UserName.TabIndex = 0;
            this.TB_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.TB_UserName_Validating);
            this.TB_UserName.Validated += new System.EventHandler(this.TB_UserName_Validated);
            // 
            // Pic_UserLogin
            // 
            this.Pic_UserLogin.BackColor = System.Drawing.Color.Transparent;
            this.Pic_UserLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_UserLogin.BackgroundImage")));
            this.Pic_UserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic_UserLogin.Location = new System.Drawing.Point(275, 53);
            this.Pic_UserLogin.Name = "Pic_UserLogin";
            this.Pic_UserLogin.Size = new System.Drawing.Size(116, 99);
            this.Pic_UserLogin.TabIndex = 2;
            this.Pic_UserLogin.TabStop = false;
            // 
            // CheckBox_RememberMe
            // 
            this.CheckBox_RememberMe.AutoSize = true;
            this.CheckBox_RememberMe.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_RememberMe.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_RememberMe.ForeColor = System.Drawing.Color.Transparent;
            this.CheckBox_RememberMe.Location = new System.Drawing.Point(275, 276);
            this.CheckBox_RememberMe.Name = "CheckBox_RememberMe";
            this.CheckBox_RememberMe.Size = new System.Drawing.Size(113, 20);
            this.CheckBox_RememberMe.TabIndex = 2;
            this.CheckBox_RememberMe.Text = "Remember Me";
            this.CheckBox_RememberMe.UseVisualStyleBackColor = false;
            // 
            // Label_Const_UserName
            // 
            this.Label_Const_UserName.AutoSize = true;
            this.Label_Const_UserName.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_UserName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_UserName.ForeColor = System.Drawing.Color.Transparent;
            this.Label_Const_UserName.Location = new System.Drawing.Point(272, 181);
            this.Label_Const_UserName.Name = "Label_Const_UserName";
            this.Label_Const_UserName.Size = new System.Drawing.Size(73, 16);
            this.Label_Const_UserName.TabIndex = 5;
            this.Label_Const_UserName.Text = "User Name";
            // 
            // Label_Const_Password
            // 
            this.Label_Const_Password.AutoSize = true;
            this.Label_Const_Password.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Password.ForeColor = System.Drawing.Color.Transparent;
            this.Label_Const_Password.Location = new System.Drawing.Point(272, 229);
            this.Label_Const_Password.Name = "Label_Const_Password";
            this.Label_Const_Password.Size = new System.Drawing.Size(63, 16);
            this.Label_Const_Password.TabIndex = 6;
            this.Label_Const_Password.Text = "Password";
            // 
            // Pic_CloseForm
            // 
            this.Pic_CloseForm.BackColor = System.Drawing.Color.Transparent;
            this.Pic_CloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_CloseForm.BackgroundImage")));
            this.Pic_CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic_CloseForm.Location = new System.Drawing.Point(636, 0);
            this.Pic_CloseForm.Name = "Pic_CloseForm";
            this.Pic_CloseForm.Size = new System.Drawing.Size(21, 26);
            this.Pic_CloseForm.TabIndex = 7;
            this.Pic_CloseForm.TabStop = false;
            this.Pic_CloseForm.Click += new System.EventHandler(this.Pic_CloseForm_Click);
            // 
            // Label_Const_Version
            // 
            this.Label_Const_Version.AutoSize = true;
            this.Label_Const_Version.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_Version.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Version.ForeColor = System.Drawing.Color.Transparent;
            this.Label_Const_Version.Location = new System.Drawing.Point(12, 357);
            this.Label_Const_Version.Name = "Label_Const_Version";
            this.Label_Const_Version.Size = new System.Drawing.Size(67, 16);
            this.Label_Const_Version.TabIndex = 8;
            this.Label_Const_Version.Text = "Version: 1.0";
            // 
            // ErrorProvider_Input
            // 
            this.ErrorProvider_Input.ContainerControl = this;
            this.ErrorProvider_Input.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider_Input.Icon")));
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Login.Location = new System.Drawing.Point(275, 311);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(116, 26);
            this.Btn_Login.TabIndex = 9;
            this.Btn_Login.Text = "Log in";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            this.Btn_Login.MouseEnter += new System.EventHandler(this.Btn_Login_MouseEnter);
            this.Btn_Login.MouseLeave += new System.EventHandler(this.Btn_Login_MouseLeave);
            // 
            // Frm_LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(660, 382);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Label_Const_Version);
            this.Controls.Add(this.Pic_CloseForm);
            this.Controls.Add(this.Label_Const_Password);
            this.Controls.Add(this.Label_Const_UserName);
            this.Controls.Add(this.CheckBox_RememberMe);
            this.Controls.Add(this.Pic_UserLogin);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.TB_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoginScreen";
            this.Text = "Frm_LoginScreen";
            this.Load += new System.EventHandler(this.Frm_LoginScreen_Load);
            this.MouseCaptureChanged += new System.EventHandler(this.Frm_LoginScreen_MouseCaptureChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_LoginScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_LoginScreen_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_UserLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_CloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.PictureBox Pic_UserLogin;
        private System.Windows.Forms.CheckBox CheckBox_RememberMe;
        private System.Windows.Forms.Label Label_Const_UserName;
        private System.Windows.Forms.Label Label_Const_Password;
        private System.Windows.Forms.PictureBox Pic_CloseForm;
        private System.Windows.Forms.Label Label_Const_Version;
        private System.Windows.Forms.ErrorProvider ErrorProvider_Input;
        private System.Windows.Forms.Button Btn_Login;
    }
}