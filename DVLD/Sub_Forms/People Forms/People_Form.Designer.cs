namespace DVLD.Sub_Forms
{
    partial class Frm_People
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
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.Pic_FormImageTitle = new System.Windows.Forms.PictureBox();
            this._DataGridView = new System.Windows.Forms.DataGridView();
            this._ContextMenuStrip_People = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetails_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewPerson_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPerson_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePerson_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.SendEmail_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCall_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Const_Records = new System.Windows.Forms.Label();
            this.Label_Variable_Records = new System.Windows.Forms.Label();
            this.PicButton_AddNewPerson = new System.Windows.Forms.PictureBox();
            this.UC_Filter = new DVLD.User_Controls.UC_Filter();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).BeginInit();
            this._ContextMenuStrip_People.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicButton_AddNewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.AutoSize = true;
            this.Label_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Location = new System.Drawing.Point(480, 218);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(184, 29);
            this.Label_FormTitle.TabIndex = 0;
            this.Label_FormTitle.Text = "Manage People";
            // 
            // Pic_FormImageTitle
            // 
            this.Pic_FormImageTitle.Image = global::DVLD.Properties.Resources.team_14307467;
            this.Pic_FormImageTitle.Location = new System.Drawing.Point(408, 44);
            this.Pic_FormImageTitle.Name = "Pic_FormImageTitle";
            this.Pic_FormImageTitle.Size = new System.Drawing.Size(316, 154);
            this.Pic_FormImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_FormImageTitle.TabIndex = 1;
            this.Pic_FormImageTitle.TabStop = false;
            // 
            // _DataGridView
            // 
            this._DataGridView.AllowUserToAddRows = false;
            this._DataGridView.AllowUserToDeleteRows = false;
            this._DataGridView.AllowUserToOrderColumns = true;
            this._DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView.ContextMenuStrip = this._ContextMenuStrip_People;
            this._DataGridView.Location = new System.Drawing.Point(18, 290);
            this._DataGridView.Name = "_DataGridView";
            this._DataGridView.ReadOnly = true;
            this._DataGridView.Size = new System.Drawing.Size(999, 236);
            this._DataGridView.TabIndex = 5;
            // 
            // _ContextMenuStrip_People
            // 
            this._ContextMenuStrip_People.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._ContextMenuStrip_People.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetails_TSMI,
            this.toolStripMenuItem1,
            this.AddNewPerson_TSMI,
            this.EditPerson_TSMI,
            this.DeletePerson_TSMI,
            this.toolStripMenuItem2,
            this.SendEmail_TSMI,
            this.PhoneCall_TSMI});
            this._ContextMenuStrip_People.Name = "_ContextMenuStrip";
            this._ContextMenuStrip_People.Size = new System.Drawing.Size(179, 244);
            // 
            // ShowDetails_TSMI
            // 
            this.ShowDetails_TSMI.Image = global::DVLD.Properties.Resources.id_card;
            this.ShowDetails_TSMI.Name = "ShowDetails_TSMI";
            this.ShowDetails_TSMI.Size = new System.Drawing.Size(178, 38);
            this.ShowDetails_TSMI.Text = "Show Details";
            this.ShowDetails_TSMI.Click += new System.EventHandler(this.ShowPerson_TSMI_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // AddNewPerson_TSMI
            // 
            this.AddNewPerson_TSMI.Image = global::DVLD.Properties.Resources.AddUser;
            this.AddNewPerson_TSMI.Name = "AddNewPerson_TSMI";
            this.AddNewPerson_TSMI.Size = new System.Drawing.Size(178, 38);
            this.AddNewPerson_TSMI.Text = "Add New Person";
            this.AddNewPerson_TSMI.Click += new System.EventHandler(this.AddNewPerson_TSMI_Click);
            // 
            // EditPerson_TSMI
            // 
            this.EditPerson_TSMI.Image = global::DVLD.Properties.Resources.edit_user;
            this.EditPerson_TSMI.Name = "EditPerson_TSMI";
            this.EditPerson_TSMI.Size = new System.Drawing.Size(178, 38);
            this.EditPerson_TSMI.Text = "Edit";
            this.EditPerson_TSMI.Click += new System.EventHandler(this.EditPerson_TSMI_Click);
            // 
            // DeletePerson_TSMI
            // 
            this.DeletePerson_TSMI.Image = global::DVLD.Properties.Resources.delete;
            this.DeletePerson_TSMI.Name = "DeletePerson_TSMI";
            this.DeletePerson_TSMI.Size = new System.Drawing.Size(178, 38);
            this.DeletePerson_TSMI.Text = "Delete";
            this.DeletePerson_TSMI.Click += new System.EventHandler(this.DeletePerson_TSMI_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
            // 
            // SendEmail_TSMI
            // 
            this.SendEmail_TSMI.Image = global::DVLD.Properties.Resources.email;
            this.SendEmail_TSMI.Name = "SendEmail_TSMI";
            this.SendEmail_TSMI.Size = new System.Drawing.Size(178, 38);
            this.SendEmail_TSMI.Text = "Send Email";
            this.SendEmail_TSMI.Click += new System.EventHandler(this.SendEmail_TSMI_Click);
            // 
            // PhoneCall_TSMI
            // 
            this.PhoneCall_TSMI.Image = global::DVLD.Properties.Resources.telephone;
            this.PhoneCall_TSMI.Name = "PhoneCall_TSMI";
            this.PhoneCall_TSMI.Size = new System.Drawing.Size(178, 38);
            this.PhoneCall_TSMI.Text = "Phone Call";
            this.PhoneCall_TSMI.Click += new System.EventHandler(this.PhoneCall_TSMI_Click);
            // 
            // Label_Const_Records
            // 
            this.Label_Const_Records.AutoSize = true;
            this.Label_Const_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Records.Location = new System.Drawing.Point(12, 538);
            this.Label_Const_Records.Name = "Label_Const_Records";
            this.Label_Const_Records.Size = new System.Drawing.Size(86, 24);
            this.Label_Const_Records.TabIndex = 13;
            this.Label_Const_Records.Text = "Records:";
            // 
            // Label_Variable_Records
            // 
            this.Label_Variable_Records.AutoSize = true;
            this.Label_Variable_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_Records.Location = new System.Drawing.Point(104, 538);
            this.Label_Variable_Records.Name = "Label_Variable_Records";
            this.Label_Variable_Records.Size = new System.Drawing.Size(123, 24);
            this.Label_Variable_Records.TabIndex = 14;
            this.Label_Variable_Records.Text = "(No Records)";
            // 
            // PicButton_AddNewPerson
            // 
            this.PicButton_AddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.PicButton_AddNewPerson.Image = global::DVLD.Properties.Resources.add_group;
            this.PicButton_AddNewPerson.Location = new System.Drawing.Point(961, 235);
            this.PicButton_AddNewPerson.Name = "PicButton_AddNewPerson";
            this.PicButton_AddNewPerson.Size = new System.Drawing.Size(56, 49);
            this.PicButton_AddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicButton_AddNewPerson.TabIndex = 10;
            this.PicButton_AddNewPerson.TabStop = false;
            this.PicButton_AddNewPerson.Click += new System.EventHandler(this.PicButton_AddNewPerson_Click);
            // 
            // UC_Filter
            // 
            this.UC_Filter.Location = new System.Drawing.Point(18, 239);
            this.UC_Filter.Name = "UC_Filter";
            this.UC_Filter.Size = new System.Drawing.Size(456, 45);
            this.UC_Filter.TabIndex = 15;
            this.UC_Filter.EvFilter += new System.Action<string, object>(this.uC_Filter1_EvFilter);
            this.UC_Filter.Ev_IsInt += new System.Action<int>(this.uC_Filter1_Ev_IsInt);
            // 
            // Frm_People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 597);
            this.Controls.Add(this.UC_Filter);
            this.Controls.Add(this.Label_Variable_Records);
            this.Controls.Add(this.Label_Const_Records);
            this.Controls.Add(this.PicButton_AddNewPerson);
            this.Controls.Add(this._DataGridView);
            this.Controls.Add(this.Pic_FormImageTitle);
            this.Controls.Add(this.Label_FormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_People";
            this.Text = "People_Form";
            this.Load += new System.EventHandler(this.People_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).EndInit();
            this._ContextMenuStrip_People.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicButton_AddNewPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.PictureBox Pic_FormImageTitle;
        private System.Windows.Forms.DataGridView _DataGridView;
        private System.Windows.Forms.Label Label_Const_Records;
        private System.Windows.Forms.Label Label_Variable_Records;
        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip_People;
        private System.Windows.Forms.ToolStripMenuItem ShowDetails_TSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddNewPerson_TSMI;
        private System.Windows.Forms.ToolStripMenuItem EditPerson_TSMI;
        private System.Windows.Forms.ToolStripMenuItem DeletePerson_TSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SendEmail_TSMI;
        private System.Windows.Forms.ToolStripMenuItem PhoneCall_TSMI;
        private System.Windows.Forms.PictureBox PicButton_AddNewPerson;
        private User_Controls.UC_Filter UC_Filter;
    }
}