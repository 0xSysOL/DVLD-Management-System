namespace DVLD.User_Controls
{
    partial class UserControl_GetPersonDataWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.Label_FilterBy = new System.Windows.Forms.Label();
            this._DataGridView = new System.Windows.Forms.DataGridView();
            this.Label_CountRows = new System.Windows.Forms.Label();
            this.ComboBOX = new System.Windows.Forms.ComboBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this._ContextMenuStrip_People = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PicButton_AddNewPerson = new System.Windows.Forms.PictureBox();
            this.ComboBox_IsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).BeginInit();
            this._ContextMenuStrip_People.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicButton_AddNewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_FilterBy
            // 
            this.Label_FilterBy.AutoSize = true;
            this.Label_FilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FilterBy.Location = new System.Drawing.Point(15, 43);
            this.Label_FilterBy.Name = "Label_FilterBy";
            this.Label_FilterBy.Size = new System.Drawing.Size(66, 20);
            this.Label_FilterBy.TabIndex = 0;
            this.Label_FilterBy.Text = "Filter By";
            // 
            // _DataGridView
            // 
            this._DataGridView.AllowUserToAddRows = false;
            this._DataGridView.AllowUserToDeleteRows = false;
            this._DataGridView.AllowUserToOrderColumns = true;
            this._DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView.Location = new System.Drawing.Point(19, 69);
            this._DataGridView.Name = "_DataGridView";
            this._DataGridView.ReadOnly = true;
            this._DataGridView.Size = new System.Drawing.Size(1260, 199);
            this._DataGridView.TabIndex = 3;
            // 
            // Label_CountRows
            // 
            this.Label_CountRows.AutoSize = true;
            this.Label_CountRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CountRows.Location = new System.Drawing.Point(15, 271);
            this.Label_CountRows.Name = "Label_CountRows";
            this.Label_CountRows.Size = new System.Drawing.Size(94, 20);
            this.Label_CountRows.TabIndex = 5;
            this.Label_CountRows.Text = "# Records : ";
            // 
            // ComboBOX
            // 
            this.ComboBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBOX.FormattingEnabled = true;
            this.ComboBOX.Location = new System.Drawing.Point(87, 42);
            this.ComboBOX.Name = "ComboBOX";
            this.ComboBOX.Size = new System.Drawing.Size(121, 21);
            this.ComboBOX.TabIndex = 6;
            this.ComboBOX.SelectedIndexChanged += new System.EventHandler(this.ComboBOX_SelectedIndexChanged);
            // 
            // TB_Search
            // 
            this.TB_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(223, 42);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(100, 22);
            this.TB_Search.TabIndex = 7;
            this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            this.TB_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Search_KeyPress);
            // 
            // _ContextMenuStrip_People
            // 
            this._ContextMenuStrip_People.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._ContextMenuStrip_People.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this._ContextMenuStrip_People.Name = "_ContextMenuStrip";
            this._ContextMenuStrip_People.Size = new System.Drawing.Size(197, 266);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.id_card;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD.Properties.Resources.AddUser;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_user;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.telephone;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // PicButton_AddNewPerson
            // 
            this.PicButton_AddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.PicButton_AddNewPerson.Image = global::DVLD.Properties.Resources.add_group;
            this.PicButton_AddNewPerson.Location = new System.Drawing.Point(1223, 15);
            this.PicButton_AddNewPerson.Name = "PicButton_AddNewPerson";
            this.PicButton_AddNewPerson.Size = new System.Drawing.Size(56, 49);
            this.PicButton_AddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicButton_AddNewPerson.TabIndex = 8;
            this.PicButton_AddNewPerson.TabStop = false;
            this.PicButton_AddNewPerson.Click += new System.EventHandler(this.PicButton_AddNewPerson_Click);
            this.PicButton_AddNewPerson.MouseEnter += new System.EventHandler(this.PicButton_AddNewPerson_MouseEnter);
            this.PicButton_AddNewPerson.MouseLeave += new System.EventHandler(this.PicButton_AddNewPerson_MouseLeave);
            // 
            // ComboBox_IsActive
            // 
            this.ComboBox_IsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_IsActive.FormattingEnabled = true;
            this.ComboBox_IsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.ComboBox_IsActive.Location = new System.Drawing.Point(214, 44);
            this.ComboBox_IsActive.Name = "ComboBox_IsActive";
            this.ComboBox_IsActive.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_IsActive.TabIndex = 9;
            this.ComboBox_IsActive.Visible = false;
            this.ComboBox_IsActive.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IsActive_SelectedIndexChanged);
            // 
            // UserControl_GetPersonDataWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboBox_IsActive);
            this.Controls.Add(this.PicButton_AddNewPerson);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.ComboBOX);
            this.Controls.Add(this.Label_CountRows);
            this.Controls.Add(this._DataGridView);
            this.Controls.Add(this.Label_FilterBy);
            this.Name = "UserControl_GetPersonDataWithFilter";
            this.Size = new System.Drawing.Size(1298, 296);
            this.Load += new System.EventHandler(this._UserControl_GetRecordsDataWithFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).EndInit();
            this._ContextMenuStrip_People.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicButton_AddNewPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_FilterBy;
        private System.Windows.Forms.DataGridView _DataGridView;
        private System.Windows.Forms.Label Label_CountRows;
        private System.Windows.Forms.ComboBox ComboBOX;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.PictureBox PicButton_AddNewPerson;
        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip_People;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBox_IsActive;
    }
}
