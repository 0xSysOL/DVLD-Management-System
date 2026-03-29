namespace DVLD
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.MS__Application = new System.Windows.Forms.ToolStripMenuItem();
            this.MS__People = new System.Windows.Forms.ToolStripMenuItem();
            this.MS__Drivers = new System.Windows.Forms.ToolStripMenuItem();
            this.MS__Users = new System.Windows.Forms.ToolStripMenuItem();
            this.MS__AccountSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCurrUserPassdTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.signOut_SM = new System.Windows.Forms.ToolStripMenuItem();
            this.DrivingLS_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.BackColor = System.Drawing.Color.Transparent;
            this.MS_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MS_Main.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_Main.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.MS_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS__Application,
            this.MS__People,
            this.MS__Drivers,
            this.MS__Users,
            this.MS__AccountSetting});
            this.MS_Main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(1345, 72);
            this.MS_Main.TabIndex = 0;
            this.MS_Main.Text = "menuStrip1";
            // 
            // MS__Application
            // 
            this.MS__Application.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrivingLS_ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.manageApplicationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.detainLicenseToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.MS__Application.Image = global::DVLD.Properties.Resources.clipboard_8074957;
            this.MS__Application.Name = "MS__Application";
            this.MS__Application.Size = new System.Drawing.Size(184, 68);
            this.MS__Application.Text = "Application";
            // 
            // MS__People
            // 
            this.MS__People.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MS__People.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS__People.Image = global::DVLD.Properties.Resources.group_1622082;
            this.MS__People.Name = "MS__People";
            this.MS__People.Size = new System.Drawing.Size(145, 68);
            this.MS__People.Text = "People";
            this.MS__People.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MS__People.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MS__People.Click += new System.EventHandler(this.MS__People_Click);
            // 
            // MS__Drivers
            // 
            this.MS__Drivers.Image = global::DVLD.Properties.Resources.driver_2481816;
            this.MS__Drivers.Name = "MS__Drivers";
            this.MS__Drivers.Size = new System.Drawing.Size(147, 68);
            this.MS__Drivers.Text = "Drviers";
            // 
            // MS__Users
            // 
            this.MS__Users.Image = global::DVLD.Properties.Resources.policing_17675955;
            this.MS__Users.Name = "MS__Users";
            this.MS__Users.Size = new System.Drawing.Size(134, 68);
            this.MS__Users.Text = "Users";
            this.MS__Users.Click += new System.EventHandler(this.MS__Users_Click);
            // 
            // MS__AccountSetting
            // 
            this.MS__AccountSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem,
            this.changeCurrUserPassdTSM,
            this.toolStripMenuItem2,
            this.signOut_SM});
            this.MS__AccountSetting.Image = global::DVLD.Properties.Resources.user_7766858;
            this.MS__AccountSetting.Name = "MS__AccountSetting";
            this.MS__AccountSetting.Size = new System.Drawing.Size(221, 68);
            this.MS__AccountSetting.Text = "Account Setting";
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("currentUserToolStripMenuItem.Image")));
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(281, 70);
            this.currentUserToolStripMenuItem.Text = "Current User";
            this.currentUserToolStripMenuItem.Click += new System.EventHandler(this.currentUserToolStripMenuItem_Click);
            // 
            // changeCurrUserPassdTSM
            // 
            this.changeCurrUserPassdTSM.Image = ((System.Drawing.Image)(resources.GetObject("changeCurrUserPassdTSM.Image")));
            this.changeCurrUserPassdTSM.Name = "changeCurrUserPassdTSM";
            this.changeCurrUserPassdTSM.Size = new System.Drawing.Size(281, 70);
            this.changeCurrUserPassdTSM.Text = "Change Password";
            this.changeCurrUserPassdTSM.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(278, 6);
            // 
            // signOut_SM
            // 
            this.signOut_SM.Image = ((System.Drawing.Image)(resources.GetObject("signOut_SM.Image")));
            this.signOut_SM.Name = "signOut_SM";
            this.signOut_SM.Size = new System.Drawing.Size(281, 70);
            this.signOut_SM.Text = "Sign Out";
            this.signOut_SM.Click += new System.EventHandler(this.signOut_SM_Click);
            // 
            // DrivingLS_ToolStripMenuItem
            // 
            this.DrivingLS_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DrivingLS_ToolStripMenuItem.Image")));
            this.DrivingLS_ToolStripMenuItem.Name = "DrivingLS_ToolStripMenuItem";
            this.DrivingLS_ToolStripMenuItem.Size = new System.Drawing.Size(354, 70);
            this.DrivingLS_ToolStripMenuItem.Text = "Driving Licenses  Services";
            // 
            // manageApplicationToolStripMenuItem
            // 
            this.manageApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationToolStripMenuItem.Image")));
            this.manageApplicationToolStripMenuItem.Name = "manageApplicationToolStripMenuItem";
            this.manageApplicationToolStripMenuItem.Size = new System.Drawing.Size(354, 70);
            this.manageApplicationToolStripMenuItem.Text = "Manage Application";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(351, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(351, 6);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicenseToolStripMenuItem.Image")));
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(354, 70);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationTypesToolStripMenuItem.Image")));
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(354, 70);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageTestTypesToolStripMenuItem.Image")));
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(354, 70);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD.Properties.Resources.police_station_19022866;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1345, 744);
            this.Controls.Add(this.MS_Main);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MS_Main;
            this.Name = "Main_Form";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS__Application;
        private System.Windows.Forms.ToolStripMenuItem MS__People;
        private System.Windows.Forms.ToolStripMenuItem MS__Drivers;
        private System.Windows.Forms.ToolStripMenuItem MS__Users;
        private System.Windows.Forms.ToolStripMenuItem MS__AccountSetting;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCurrUserPassdTSM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem signOut_SM;
        private System.Windows.Forms.ToolStripMenuItem DrivingLS_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
    }
}

