namespace DVLD.Sub_Forms
{
    partial class Frm_ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManageUsers));
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this._DataGridView = new System.Windows.Forms.DataGridView();
            this._ContextMenuStrip_Users = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pic_FormImageTitle = new System.Windows.Forms.PictureBox();
            this.PicButton_AddNewPerson = new System.Windows.Forms.PictureBox();
            this.Label_Variable_Records = new System.Windows.Forms.Label();
            this.Label_Const_Records = new System.Windows.Forms.Label();
            this.UC_Filter = new DVLD.User_Controls.UC_Filter();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).BeginInit();
            this._ContextMenuStrip_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicButton_AddNewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.AutoSize = true;
            this.Label_FormTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Location = new System.Drawing.Point(434, 186);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(164, 30);
            this.Label_FormTitle.TabIndex = 2;
            this.Label_FormTitle.Text = "Manage Users";
            // 
            // _DataGridView
            // 
            this._DataGridView.AllowUserToAddRows = false;
            this._DataGridView.AllowUserToDeleteRows = false;
            this._DataGridView.AllowUserToOrderColumns = true;
            this._DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView.ContextMenuStrip = this._ContextMenuStrip_Users;
            this._DataGridView.Location = new System.Drawing.Point(12, 266);
            this._DataGridView.Name = "_DataGridView";
            this._DataGridView.ReadOnly = true;
            this._DataGridView.Size = new System.Drawing.Size(962, 236);
            this._DataGridView.TabIndex = 4;
            this._DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DataGridView_CellContentClick);
            // 
            // _ContextMenuStrip_Users
            // 
            this._ContextMenuStrip_Users.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._ContextMenuStrip_Users.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this._ContextMenuStrip_Users.Name = "_ContextMenuStrip";
            this._ContextMenuStrip_Users.Size = new System.Drawing.Size(197, 304);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.id_card;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::DVLD.Properties.Resources.AddUser;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_user;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.email;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.telephone;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // Pic_FormImageTitle
            // 
            this.Pic_FormImageTitle.Image = ((System.Drawing.Image)(resources.GetObject("Pic_FormImageTitle.Image")));
            this.Pic_FormImageTitle.Location = new System.Drawing.Point(360, 12);
            this.Pic_FormImageTitle.Name = "Pic_FormImageTitle";
            this.Pic_FormImageTitle.Size = new System.Drawing.Size(316, 154);
            this.Pic_FormImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_FormImageTitle.TabIndex = 3;
            this.Pic_FormImageTitle.TabStop = false;
            // 
            // PicButton_AddNewPerson
            // 
            this.PicButton_AddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.PicButton_AddNewPerson.Image = global::DVLD.Properties.Resources.add_group;
            this.PicButton_AddNewPerson.Location = new System.Drawing.Point(918, 211);
            this.PicButton_AddNewPerson.Name = "PicButton_AddNewPerson";
            this.PicButton_AddNewPerson.Size = new System.Drawing.Size(56, 49);
            this.PicButton_AddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicButton_AddNewPerson.TabIndex = 9;
            this.PicButton_AddNewPerson.TabStop = false;
            this.PicButton_AddNewPerson.Click += new System.EventHandler(this.PicButton_AddNewPerson_Click);
            // 
            // Label_Variable_Records
            // 
            this.Label_Variable_Records.AutoSize = true;
            this.Label_Variable_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_Records.Location = new System.Drawing.Point(104, 507);
            this.Label_Variable_Records.Name = "Label_Variable_Records";
            this.Label_Variable_Records.Size = new System.Drawing.Size(123, 24);
            this.Label_Variable_Records.TabIndex = 16;
            this.Label_Variable_Records.Text = "(No Records)";
            // 
            // Label_Const_Records
            // 
            this.Label_Const_Records.AutoSize = true;
            this.Label_Const_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Records.Location = new System.Drawing.Point(12, 507);
            this.Label_Const_Records.Name = "Label_Const_Records";
            this.Label_Const_Records.Size = new System.Drawing.Size(86, 24);
            this.Label_Const_Records.TabIndex = 15;
            this.Label_Const_Records.Text = "Records:";
            // 
            // UC_Filter
            // 
            this.UC_Filter.Location = new System.Drawing.Point(12, 217);
            this.UC_Filter.Name = "UC_Filter";
            this.UC_Filter.Size = new System.Drawing.Size(349, 43);
            this.UC_Filter.TabIndex = 5;
            this.UC_Filter.EvFilter += new System.Action<string, object>(this.Filter_EvFilter);
            this.UC_Filter.Ev_IsInt += new System.Action<int>(this.UC_Filter_EvGetAnswer);
            this.UC_Filter.Load += new System.EventHandler(this.UC_Filter_Load);
            // 
            // Frm_ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 552);
            this.Controls.Add(this.Label_Variable_Records);
            this.Controls.Add(this.Label_Const_Records);
            this.Controls.Add(this.PicButton_AddNewPerson);
            this.Controls.Add(this.UC_Filter);
            this.Controls.Add(this._DataGridView);
            this.Controls.Add(this.Pic_FormImageTitle);
            this.Controls.Add(this.Label_FormTitle);
            this.Name = "Frm_ManageUsers";
            this.Text = "Frm_ManageUsers";
            this.Load += new System.EventHandler(this.Frm_ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).EndInit();
            this._ContextMenuStrip_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicButton_AddNewPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_FormImageTitle;
        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.DataGridView _DataGridView;
        private User_Controls.UC_Filter UC_Filter;
        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip_Users;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.PictureBox PicButton_AddNewPerson;
        private System.Windows.Forms.Label Label_Variable_Records;
        private System.Windows.Forms.Label Label_Const_Records;
    }
}