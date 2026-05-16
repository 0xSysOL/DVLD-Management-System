namespace DVLD.Sub_Forms.License
{
    partial class Frm_ShowPersonLicenseHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UC_ShowPersonInfo = new DVLD.User_Controls.UC_ShowPersonInfo();
            this.Label_Variable_Local_Records = new System.Windows.Forms.Label();
            this.Label_Const_Local_Records = new System.Windows.Forms.Label();
            this._DataGridView_Local = new System.Windows.Forms.DataGridView();
            this.Label_Const_FormTitle = new System.Windows.Forms.Label();
            this.Pic_FormTitle = new System.Windows.Forms.PictureBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.TC = new System.Windows.Forms.TabControl();
            this.TP_Local = new System.Windows.Forms.TabPage();
            this.Label_Const_TabPageLocalTitle = new System.Windows.Forms.Label();
            this.TP_International = new System.Windows.Forms.TabPage();
            this.Label_Const_TabPageInternationalTitle = new System.Windows.Forms.Label();
            this.Label_Variable_International_Records = new System.Windows.Forms.Label();
            this.Label_Const_International_Records = new System.Windows.Forms.Label();
            this._DataGridView_International = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView_Local)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormTitle)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.TC.SuspendLayout();
            this.TP_Local.SuspendLayout();
            this.TP_International.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView_International)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_ShowPersonInfo
            // 
            this.UC_ShowPersonInfo.Location = new System.Drawing.Point(208, 73);
            this.UC_ShowPersonInfo.Name = "UC_ShowPersonInfo";
            this.UC_ShowPersonInfo.Size = new System.Drawing.Size(751, 291);
            this.UC_ShowPersonInfo.TabIndex = 0;
            // 
            // Label_Variable_Local_Records
            // 
            this.Label_Variable_Local_Records.AutoSize = true;
            this.Label_Variable_Local_Records.BackColor = System.Drawing.Color.Transparent;
            this.Label_Variable_Local_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_Local_Records.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Variable_Local_Records.Location = new System.Drawing.Point(89, 248);
            this.Label_Variable_Local_Records.Name = "Label_Variable_Local_Records";
            this.Label_Variable_Local_Records.Size = new System.Drawing.Size(123, 24);
            this.Label_Variable_Local_Records.TabIndex = 19;
            this.Label_Variable_Local_Records.Text = "(No Records)";
            // 
            // Label_Const_Local_Records
            // 
            this.Label_Const_Local_Records.AutoSize = true;
            this.Label_Const_Local_Records.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_Local_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Local_Records.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_Local_Records.Location = new System.Drawing.Point(6, 248);
            this.Label_Const_Local_Records.Name = "Label_Const_Local_Records";
            this.Label_Const_Local_Records.Size = new System.Drawing.Size(86, 24);
            this.Label_Const_Local_Records.TabIndex = 18;
            this.Label_Const_Local_Records.Text = "Records:";
            // 
            // _DataGridView_Local
            // 
            this._DataGridView_Local.AllowUserToAddRows = false;
            this._DataGridView_Local.AllowUserToDeleteRows = false;
            this._DataGridView_Local.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._DataGridView_Local.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._DataGridView_Local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView_Local.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._DataGridView_Local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView_Local.Location = new System.Drawing.Point(6, 57);
            this._DataGridView_Local.Name = "_DataGridView_Local";
            this._DataGridView_Local.ReadOnly = true;
            this._DataGridView_Local.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this._DataGridView_Local.Size = new System.Drawing.Size(1173, 188);
            this._DataGridView_Local.TabIndex = 17;
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(465, 29);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(201, 31);
            this.Label_Const_FormTitle.TabIndex = 21;
            this.Label_Const_FormTitle.Text = "License History";
            // 
            // Pic_FormTitle
            // 
            this.Pic_FormTitle.Image = global::DVLD.Properties.Resources.scroll;
            this.Pic_FormTitle.Location = new System.Drawing.Point(12, 197);
            this.Pic_FormTitle.Name = "Pic_FormTitle";
            this.Pic_FormTitle.Size = new System.Drawing.Size(184, 151);
            this.Pic_FormTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_FormTitle.TabIndex = 20;
            this.Pic_FormTitle.TabStop = false;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.TC);
            this.GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(3, 396);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(1208, 363);
            this.GroupBox.TabIndex = 22;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Driver License";
            // 
            // TC
            // 
            this.TC.Controls.Add(this.TP_Local);
            this.TC.Controls.Add(this.TP_International);
            this.TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC.Location = new System.Drawing.Point(9, 41);
            this.TC.Name = "TC";
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(1193, 316);
            this.TC.TabIndex = 0;
            // 
            // TP_Local
            // 
            this.TP_Local.BackColor = System.Drawing.Color.Transparent;
            this.TP_Local.Controls.Add(this.Label_Const_TabPageLocalTitle);
            this.TP_Local.Controls.Add(this.Label_Variable_Local_Records);
            this.TP_Local.Controls.Add(this.Label_Const_Local_Records);
            this.TP_Local.Controls.Add(this._DataGridView_Local);
            this.TP_Local.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TP_Local.Location = new System.Drawing.Point(4, 29);
            this.TP_Local.Name = "TP_Local";
            this.TP_Local.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Local.Size = new System.Drawing.Size(1185, 283);
            this.TP_Local.TabIndex = 0;
            this.TP_Local.Text = "Local";
            // 
            // Label_Const_TabPageLocalTitle
            // 
            this.Label_Const_TabPageLocalTitle.AutoSize = true;
            this.Label_Const_TabPageLocalTitle.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_TabPageLocalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_TabPageLocalTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_TabPageLocalTitle.Location = new System.Drawing.Point(18, 21);
            this.Label_Const_TabPageLocalTitle.Name = "Label_Const_TabPageLocalTitle";
            this.Label_Const_TabPageLocalTitle.Size = new System.Drawing.Size(193, 24);
            this.Label_Const_TabPageLocalTitle.TabIndex = 20;
            this.Label_Const_TabPageLocalTitle.Text = "Local License Histroy:";
            // 
            // TP_International
            // 
            this.TP_International.BackColor = System.Drawing.Color.Transparent;
            this.TP_International.Controls.Add(this.Label_Const_TabPageInternationalTitle);
            this.TP_International.Controls.Add(this.Label_Variable_International_Records);
            this.TP_International.Controls.Add(this.Label_Const_International_Records);
            this.TP_International.Controls.Add(this._DataGridView_International);
            this.TP_International.Location = new System.Drawing.Point(4, 29);
            this.TP_International.Name = "TP_International";
            this.TP_International.Padding = new System.Windows.Forms.Padding(3);
            this.TP_International.Size = new System.Drawing.Size(1185, 283);
            this.TP_International.TabIndex = 1;
            this.TP_International.Text = "International";
            // 
            // Label_Const_TabPageInternationalTitle
            // 
            this.Label_Const_TabPageInternationalTitle.AutoSize = true;
            this.Label_Const_TabPageInternationalTitle.BackColor = System.Drawing.Color.Transparent;
            this.Label_Const_TabPageInternationalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_TabPageInternationalTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_TabPageInternationalTitle.Location = new System.Drawing.Point(6, 26);
            this.Label_Const_TabPageInternationalTitle.Name = "Label_Const_TabPageInternationalTitle";
            this.Label_Const_TabPageInternationalTitle.Size = new System.Drawing.Size(249, 24);
            this.Label_Const_TabPageInternationalTitle.TabIndex = 23;
            this.Label_Const_TabPageInternationalTitle.Text = "International License History:";
            // 
            // Label_Variable_International_Records
            // 
            this.Label_Variable_International_Records.AutoSize = true;
            this.Label_Variable_International_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_International_Records.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Variable_International_Records.Location = new System.Drawing.Point(89, 253);
            this.Label_Variable_International_Records.Name = "Label_Variable_International_Records";
            this.Label_Variable_International_Records.Size = new System.Drawing.Size(123, 24);
            this.Label_Variable_International_Records.TabIndex = 22;
            this.Label_Variable_International_Records.Text = "(No Records)";
            // 
            // Label_Const_International_Records
            // 
            this.Label_Const_International_Records.AutoSize = true;
            this.Label_Const_International_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_International_Records.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_International_Records.Location = new System.Drawing.Point(6, 253);
            this.Label_Const_International_Records.Name = "Label_Const_International_Records";
            this.Label_Const_International_Records.Size = new System.Drawing.Size(86, 24);
            this.Label_Const_International_Records.TabIndex = 21;
            this.Label_Const_International_Records.Text = "Records:";
            // 
            // _DataGridView_International
            // 
            this._DataGridView_International.AllowUserToAddRows = false;
            this._DataGridView_International.AllowUserToDeleteRows = false;
            this._DataGridView_International.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._DataGridView_International.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this._DataGridView_International.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView_International.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._DataGridView_International.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView_International.Location = new System.Drawing.Point(6, 62);
            this._DataGridView_International.Name = "_DataGridView_International";
            this._DataGridView_International.ReadOnly = true;
            this._DataGridView_International.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this._DataGridView_International.Size = new System.Drawing.Size(1173, 188);
            this._DataGridView_International.TabIndex = 20;
            // 
            // Frm_ShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 771);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Controls.Add(this.Pic_FormTitle);
            this.Controls.Add(this.UC_ShowPersonInfo);
            this.Name = "Frm_ShowPersonLicenseHistory";
            this.Text = "License History";
            this.Load += new System.EventHandler(this.Frm_ShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView_Local)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormTitle)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.TC.ResumeLayout(false);
            this.TP_Local.ResumeLayout(false);
            this.TP_Local.PerformLayout();
            this.TP_International.ResumeLayout(false);
            this.TP_International.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView_International)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.UC_ShowPersonInfo UC_ShowPersonInfo;
        private System.Windows.Forms.Label Label_Variable_Local_Records;
        private System.Windows.Forms.Label Label_Const_Local_Records;
        private System.Windows.Forms.DataGridView _DataGridView_Local;
        private System.Windows.Forms.Label Label_Const_FormTitle;
        private System.Windows.Forms.PictureBox Pic_FormTitle;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TabControl TC;
        private System.Windows.Forms.TabPage TP_Local;
        private System.Windows.Forms.TabPage TP_International;
        private System.Windows.Forms.Label Label_Variable_International_Records;
        private System.Windows.Forms.Label Label_Const_International_Records;
        private System.Windows.Forms.DataGridView _DataGridView_International;
        private System.Windows.Forms.Label Label_Const_TabPageLocalTitle;
        private System.Windows.Forms.Label Label_Const_TabPageInternationalTitle;
    }
}