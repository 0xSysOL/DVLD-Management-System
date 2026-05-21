namespace DVLD.Sub_Forms.Drivers
{
    partial class Frm_ManageDrivers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UC_Filter = new DVLD.User_Controls.UC_Filter();
            this.Label_Variable_Records = new System.Windows.Forms.Label();
            this.Label_Const_Records = new System.Windows.Forms.Label();
            this._DataGridView = new System.Windows.Forms.DataGridView();
            this.Label_Const_FormTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_Filter
            // 
            this.UC_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_Filter.Location = new System.Drawing.Point(24, 169);
            this.UC_Filter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_Filter.Name = "UC_Filter";
            this.UC_Filter.Size = new System.Drawing.Size(481, 58);
            this.UC_Filter.TabIndex = 23;
            // 
            // Label_Variable_Records
            // 
            this.Label_Variable_Records.AutoSize = true;
            this.Label_Variable_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_Records.Location = new System.Drawing.Point(112, 506);
            this.Label_Variable_Records.Name = "Label_Variable_Records";
            this.Label_Variable_Records.Size = new System.Drawing.Size(123, 24);
            this.Label_Variable_Records.TabIndex = 22;
            this.Label_Variable_Records.Text = "(No Records)";
            // 
            // Label_Const_Records
            // 
            this.Label_Const_Records.AutoSize = true;
            this.Label_Const_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Records.Location = new System.Drawing.Point(20, 506);
            this.Label_Const_Records.Name = "Label_Const_Records";
            this.Label_Const_Records.Size = new System.Drawing.Size(86, 24);
            this.Label_Const_Records.TabIndex = 21;
            this.Label_Const_Records.Text = "Records:";
            // 
            // _DataGridView
            // 
            this._DataGridView.AllowUserToAddRows = false;
            this._DataGridView.AllowUserToDeleteRows = false;
            this._DataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this._DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._DataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this._DataGridView.Location = new System.Drawing.Point(20, 235);
            this._DataGridView.Name = "_DataGridView";
            this._DataGridView.ReadOnly = true;
            this._DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this._DataGridView.Size = new System.Drawing.Size(1325, 268);
            this._DataGridView.TabIndex = 20;
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(598, 147);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(205, 31);
            this.Label_Const_FormTitle.TabIndex = 19;
            this.Label_Const_FormTitle.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Drivers;
            this.pictureBox1.Location = new System.Drawing.Point(541, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_ManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 548);
            this.Controls.Add(this.UC_Filter);
            this.Controls.Add(this.Label_Variable_Records);
            this.Controls.Add(this.Label_Const_Records);
            this.Controls.Add(this._DataGridView);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_ManageDrivers";
            this.Text = "Frm_ManageDrivers";
            this.Load += new System.EventHandler(this.Frm_ManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.UC_Filter UC_Filter;
        private System.Windows.Forms.Label Label_Variable_Records;
        private System.Windows.Forms.Label Label_Const_Records;
        private System.Windows.Forms.DataGridView _DataGridView;
        private System.Windows.Forms.Label Label_Const_FormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}