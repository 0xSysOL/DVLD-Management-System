namespace DVLD.Sub_Forms.Application.Manage_Applications
{
    partial class Frm_LocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LocalDrivingLicenseApplications));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Const_FormTitle = new System.Windows.Forms.Label();
            this._DataGridView = new System.Windows.Forms.DataGridView();
            this._ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sechduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDLFT_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Variable_Records = new System.Windows.Forms.Label();
            this.Label_Const_Records = new System.Windows.Forms.Label();
            this.Pic_NewLocalDrivingLicense = new System.Windows.Forms.PictureBox();
            this.UC_Filter = new DVLD.User_Controls.UC_Filter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).BeginInit();
            this._ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_NewLocalDrivingLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(470, 137);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(419, 31);
            this.Label_Const_FormTitle.TabIndex = 3;
            this.Label_Const_FormTitle.Text = "Local Driving License Application ";
            // 
            // _DataGridView
            // 
            this._DataGridView.AllowUserToAddRows = false;
            this._DataGridView.AllowUserToDeleteRows = false;
            this._DataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView.ContextMenuStrip = this._ContextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this._DataGridView.Location = new System.Drawing.Point(12, 235);
            this._DataGridView.Name = "_DataGridView";
            this._DataGridView.ReadOnly = true;
            this._DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._DataGridView.Size = new System.Drawing.Size(1325, 268);
            this._DataGridView.TabIndex = 4;
            this._DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DataGridView_CellClick);
            this._DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DataGridView_CellContentClick);
            this._DataGridView.SelectionChanged += new System.EventHandler(this._DataGridView_SelectionChanged);
            // 
            // _ContextMenuStrip
            // 
            this._ContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(42, 42);
            this._ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sechduleToolStripMenuItem,
            this.issueDLFT_ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showToolStripMenuItem});
            this._ContextMenuStrip.Name = "_ContextMenuStrip";
            this._ContextMenuStrip.Size = new System.Drawing.Size(350, 440);
            this._ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this._ContextMenuStrip_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showApplicationDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showApplicationDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showApplicationDetailsToolStripMenuItem.Image")));
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(349, 48);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(346, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editApplicationToolStripMenuItem.Image")));
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(349, 48);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteApplicationToolStripMenuItem.Image")));
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(349, 48);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(346, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelApplicationToolStripMenuItem.Image")));
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(349, 48);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(346, 6);
            // 
            // sechduleToolStripMenuItem
            // 
            this.sechduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleVisionTestToolStripMenuItem,
            this.sechduleWrittenTestToolStripMenuItem,
            this.sechduleStreetTestToolStripMenuItem});
            this.sechduleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleToolStripMenuItem.Image")));
            this.sechduleToolStripMenuItem.Name = "sechduleToolStripMenuItem";
            this.sechduleToolStripMenuItem.Size = new System.Drawing.Size(349, 48);
            this.sechduleToolStripMenuItem.Text = "Sechdule Tests";
            this.sechduleToolStripMenuItem.Click += new System.EventHandler(this.sechduleToolStripMenuItem_Click);
            // 
            // sechduleVisionTestToolStripMenuItem
            // 
            this.sechduleVisionTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleVisionTestToolStripMenuItem.Image")));
            this.sechduleVisionTestToolStripMenuItem.Name = "sechduleVisionTestToolStripMenuItem";
            this.sechduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(292, 48);
            this.sechduleVisionTestToolStripMenuItem.Text = "Sechdule Vision Test";
            this.sechduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleVisionTestToolStripMenuItem_Click);
            // 
            // sechduleWrittenTestToolStripMenuItem
            // 
            this.sechduleWrittenTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleWrittenTestToolStripMenuItem.Image")));
            this.sechduleWrittenTestToolStripMenuItem.Name = "sechduleWrittenTestToolStripMenuItem";
            this.sechduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(292, 48);
            this.sechduleWrittenTestToolStripMenuItem.Text = "Sechdule Written Test";
            this.sechduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleWrittenTestToolStripMenuItem_Click);
            // 
            // sechduleStreetTestToolStripMenuItem
            // 
            this.sechduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleStreetTestToolStripMenuItem.Image")));
            this.sechduleStreetTestToolStripMenuItem.Name = "sechduleStreetTestToolStripMenuItem";
            this.sechduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(292, 48);
            this.sechduleStreetTestToolStripMenuItem.Text = "Sechdule Street Test";
            this.sechduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleStreetTestToolStripMenuItem_Click);
            // 
            // issueDLFT_ToolStripMenuItem
            // 
            this.issueDLFT_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueDLFT_ToolStripMenuItem.Image")));
            this.issueDLFT_ToolStripMenuItem.Name = "issueDLFT_ToolStripMenuItem";
            this.issueDLFT_ToolStripMenuItem.Size = new System.Drawing.Size(349, 48);
            this.issueDLFT_ToolStripMenuItem.Text = "Issue Driving License";
            this.issueDLFT_ToolStripMenuItem.Click += new System.EventHandler(this.issueDateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(346, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(349, 48);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(346, 6);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(349, 48);
            this.showToolStripMenuItem.Text = "Show Person License History";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // Label_Variable_Records
            // 
            this.Label_Variable_Records.AutoSize = true;
            this.Label_Variable_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_Records.Location = new System.Drawing.Point(104, 506);
            this.Label_Variable_Records.Name = "Label_Variable_Records";
            this.Label_Variable_Records.Size = new System.Drawing.Size(123, 24);
            this.Label_Variable_Records.TabIndex = 16;
            this.Label_Variable_Records.Text = "(No Records)";
            // 
            // Label_Const_Records
            // 
            this.Label_Const_Records.AutoSize = true;
            this.Label_Const_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Records.Location = new System.Drawing.Point(12, 506);
            this.Label_Const_Records.Name = "Label_Const_Records";
            this.Label_Const_Records.Size = new System.Drawing.Size(86, 24);
            this.Label_Const_Records.TabIndex = 15;
            this.Label_Const_Records.Text = "Records:";
            // 
            // Pic_NewLocalDrivingLicense
            // 
            this.Pic_NewLocalDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("Pic_NewLocalDrivingLicense.Image")));
            this.Pic_NewLocalDrivingLicense.Location = new System.Drawing.Point(1279, 184);
            this.Pic_NewLocalDrivingLicense.Name = "Pic_NewLocalDrivingLicense";
            this.Pic_NewLocalDrivingLicense.Size = new System.Drawing.Size(58, 50);
            this.Pic_NewLocalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_NewLocalDrivingLicense.TabIndex = 18;
            this.Pic_NewLocalDrivingLicense.TabStop = false;
            this.Pic_NewLocalDrivingLicense.Click += new System.EventHandler(this.Pic_ApplicationForm_Click);
            // 
            // UC_Filter
            // 
            this.UC_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_Filter.Location = new System.Drawing.Point(16, 171);
            this.UC_Filter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_Filter.Name = "UC_Filter";
            this.UC_Filter.Size = new System.Drawing.Size(481, 58);
            this.UC_Filter.TabIndex = 17;
            this.UC_Filter.EvFilter += new System.Action<string, object>(this.UC_Filter_EvFilter);
            this.UC_Filter.Ev_IsInt += new System.Action<int>(this.UC_Filter_Ev_IsInt);
            this.UC_Filter.EvClickedSearchButton += new System.Action<string>(this.UC_Filter_EvClickedSearchButton);
            this.UC_Filter.Load += new System.EventHandler(this.UC_Filter_Load);
            // 
            // Frm_LocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 597);
            this.Controls.Add(this.Pic_NewLocalDrivingLicense);
            this.Controls.Add(this.UC_Filter);
            this.Controls.Add(this.Label_Variable_Records);
            this.Controls.Add(this.Label_Const_Records);
            this.Controls.Add(this._DataGridView);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_LocalDrivingLicenseApplications";
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.Frm_LocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).EndInit();
            this._ContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_NewLocalDrivingLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Const_FormTitle;
        private System.Windows.Forms.DataGridView _DataGridView;
        private System.Windows.Forms.Label Label_Variable_Records;
        private System.Windows.Forms.Label Label_Const_Records;
        private User_Controls.UC_Filter UC_Filter;
        private System.Windows.Forms.PictureBox Pic_NewLocalDrivingLicense;
        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sechduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDLFT_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleStreetTestToolStripMenuItem;
    }
}