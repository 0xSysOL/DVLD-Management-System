namespace DVLD.Sub_Forms.Application.ManageTestTypes
{
    partial class Frm_ManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManageTestTypes));
            this.Label_Variable_Record = new System.Windows.Forms.Label();
            this.Label_Const_Record = new System.Windows.Forms.Label();
            this._DataGridView = new System.Windows.Forms.DataGridView();
            this._ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pic_FormImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).BeginInit();
            this._ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Variable_Record
            // 
            this.Label_Variable_Record.AutoSize = true;
            this.Label_Variable_Record.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_Record.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Variable_Record.Location = new System.Drawing.Point(106, 420);
            this.Label_Variable_Record.Name = "Label_Variable_Record";
            this.Label_Variable_Record.Size = new System.Drawing.Size(106, 23);
            this.Label_Variable_Record.TabIndex = 19;
            this.Label_Variable_Record.Text = "No Column";
            // 
            // Label_Const_Record
            // 
            this.Label_Const_Record.AutoSize = true;
            this.Label_Const_Record.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Record.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_Record.Location = new System.Drawing.Point(16, 420);
            this.Label_Const_Record.Name = "Label_Const_Record";
            this.Label_Const_Record.Size = new System.Drawing.Size(102, 23);
            this.Label_Const_Record.TabIndex = 18;
            this.Label_Const_Record.Text = "# Records: ";
            // 
            // _DataGridView
            // 
            this._DataGridView.AllowUserToAddRows = false;
            this._DataGridView.AllowUserToDeleteRows = false;
            this._DataGridView.AllowUserToOrderColumns = true;
            this._DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView.ContextMenuStrip = this._ContextMenuStrip;
            this._DataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this._DataGridView.Location = new System.Drawing.Point(20, 191);
            this._DataGridView.Name = "_DataGridView";
            this._DataGridView.ReadOnly = true;
            this._DataGridView.Size = new System.Drawing.Size(768, 226);
            this._DataGridView.TabIndex = 16;
            // 
            // _ContextMenuStrip
            // 
            this._ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolStripMenuItem2});
            this._ContextMenuStrip.Name = "_ContextMenuStrip";
            this._ContextMenuStrip.Size = new System.Drawing.Size(165, 54);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(164, 38);
            this.editToolStripMenuItem.Text = "Edit Test Type";
            this.editToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(288, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manage Test Types";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Close.Location = new System.Drawing.Point(711, 420);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(77, 23);
            this.Btn_Close.TabIndex = 20;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Pic_FormImage
            // 
            this.Pic_FormImage.Image = ((System.Drawing.Image)(resources.GetObject("Pic_FormImage.Image")));
            this.Pic_FormImage.Location = new System.Drawing.Point(195, 7);
            this.Pic_FormImage.Name = "Pic_FormImage";
            this.Pic_FormImage.Size = new System.Drawing.Size(433, 110);
            this.Pic_FormImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_FormImage.TabIndex = 17;
            this.Pic_FormImage.TabStop = false;
            // 
            // Frm_ManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Label_Variable_Record);
            this.Controls.Add(this.Label_Const_Record);
            this.Controls.Add(this.Pic_FormImage);
            this.Controls.Add(this._DataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ManageTestTypes";
            this.Text = "Frm_ManageTestTypes";
            this.Load += new System.EventHandler(this.Frm_ManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).EndInit();
            this._ContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Label_Variable_Record;
        private System.Windows.Forms.Label Label_Const_Record;
        private System.Windows.Forms.PictureBox Pic_FormImage;
        private System.Windows.Forms.DataGridView _DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}