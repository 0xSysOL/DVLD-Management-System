namespace DVLD.User_Controls.Users_User_Control
{
    partial class UC_LoginInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrouBox_Information = new System.Windows.Forms.GroupBox();
            this.Label_Const_UserID = new System.Windows.Forms.Label();
            this.Label_Variable_UserID = new System.Windows.Forms.Label();
            this.Label_Const_Username = new System.Windows.Forms.Label();
            this.Label_Variable_Username = new System.Windows.Forms.Label();
            this.Label_Variable_IsActive = new System.Windows.Forms.Label();
            this.Label_Const_IsActive = new System.Windows.Forms.Label();
            this.GrouBox_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrouBox_Information
            // 
            this.GrouBox_Information.Controls.Add(this.Label_Variable_IsActive);
            this.GrouBox_Information.Controls.Add(this.Label_Const_IsActive);
            this.GrouBox_Information.Controls.Add(this.Label_Variable_Username);
            this.GrouBox_Information.Controls.Add(this.Label_Const_Username);
            this.GrouBox_Information.Controls.Add(this.Label_Variable_UserID);
            this.GrouBox_Information.Controls.Add(this.Label_Const_UserID);
            this.GrouBox_Information.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrouBox_Information.Location = new System.Drawing.Point(43, 18);
            this.GrouBox_Information.Name = "GrouBox_Information";
            this.GrouBox_Information.Size = new System.Drawing.Size(488, 73);
            this.GrouBox_Information.TabIndex = 0;
            this.GrouBox_Information.TabStop = false;
            this.GrouBox_Information.Text = "Login Info";
            // 
            // Label_Const_UserID
            // 
            this.Label_Const_UserID.AutoSize = true;
            this.Label_Const_UserID.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_UserID.Location = new System.Drawing.Point(23, 32);
            this.Label_Const_UserID.Name = "Label_Const_UserID";
            this.Label_Const_UserID.Size = new System.Drawing.Size(64, 19);
            this.Label_Const_UserID.TabIndex = 0;
            this.Label_Const_UserID.Text = "User ID: ";
            // 
            // Label_Variable_UserID
            // 
            this.Label_Variable_UserID.AutoSize = true;
            this.Label_Variable_UserID.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_UserID.Location = new System.Drawing.Point(81, 32);
            this.Label_Variable_UserID.Name = "Label_Variable_UserID";
            this.Label_Variable_UserID.Size = new System.Drawing.Size(60, 19);
            this.Label_Variable_UserID.TabIndex = 1;
            this.Label_Variable_UserID.Text = "(No Va)";
            // 
            // Label_Const_Username
            // 
            this.Label_Const_Username.AutoSize = true;
            this.Label_Const_Username.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Username.Location = new System.Drawing.Point(171, 32);
            this.Label_Const_Username.Name = "Label_Const_Username";
            this.Label_Const_Username.Size = new System.Drawing.Size(82, 19);
            this.Label_Const_Username.TabIndex = 2;
            this.Label_Const_Username.Text = "Username: ";
            // 
            // Label_Variable_Username
            // 
            this.Label_Variable_Username.AutoSize = true;
            this.Label_Variable_Username.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_Username.Location = new System.Drawing.Point(246, 32);
            this.Label_Variable_Username.Name = "Label_Variable_Username";
            this.Label_Variable_Username.Size = new System.Drawing.Size(60, 19);
            this.Label_Variable_Username.TabIndex = 3;
            this.Label_Variable_Username.Text = "(No Va)";
            // 
            // Label_Variable_IsActive
            // 
            this.Label_Variable_IsActive.AutoSize = true;
            this.Label_Variable_IsActive.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_IsActive.Location = new System.Drawing.Point(408, 32);
            this.Label_Variable_IsActive.Name = "Label_Variable_IsActive";
            this.Label_Variable_IsActive.Size = new System.Drawing.Size(60, 19);
            this.Label_Variable_IsActive.TabIndex = 5;
            this.Label_Variable_IsActive.Text = "(No Va)";
            // 
            // Label_Const_IsActive
            // 
            this.Label_Const_IsActive.AutoSize = true;
            this.Label_Const_IsActive.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_IsActive.Location = new System.Drawing.Point(338, 32);
            this.Label_Const_IsActive.Name = "Label_Const_IsActive";
            this.Label_Const_IsActive.Size = new System.Drawing.Size(67, 19);
            this.Label_Const_IsActive.TabIndex = 4;
            this.Label_Const_IsActive.Text = "Is Active:";
            // 
            // ChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrouBox_Information);
            this.Name = "ChangeUserPassword";
            this.Size = new System.Drawing.Size(571, 113);
            this.GrouBox_Information.ResumeLayout(false);
            this.GrouBox_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrouBox_Information;
        private System.Windows.Forms.Label Label_Variable_IsActive;
        private System.Windows.Forms.Label Label_Const_IsActive;
        private System.Windows.Forms.Label Label_Variable_Username;
        private System.Windows.Forms.Label Label_Const_Username;
        private System.Windows.Forms.Label Label_Variable_UserID;
        private System.Windows.Forms.Label Label_Const_UserID;
    }
}
