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
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.Pic_FormImageTitle = new System.Windows.Forms.PictureBox();
            this.getDataWithFilter_UC1 = new DVLD.User_Controls.UserControl_GetPersonDataWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImageTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.AutoSize = true;
            this.Label_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.Location = new System.Drawing.Point(622, 199);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(184, 29);
            this.Label_FormTitle.TabIndex = 0;
            this.Label_FormTitle.Text = "Manage People";
            // 
            // Pic_FormImageTitle
            // 
            this.Pic_FormImageTitle.Image = global::DVLD.Properties.Resources.team_14307467;
            this.Pic_FormImageTitle.Location = new System.Drawing.Point(550, 25);
            this.Pic_FormImageTitle.Name = "Pic_FormImageTitle";
            this.Pic_FormImageTitle.Size = new System.Drawing.Size(316, 154);
            this.Pic_FormImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_FormImageTitle.TabIndex = 1;
            this.Pic_FormImageTitle.TabStop = false;
            // 
            // getDataWithFilter_UC1
            // 
            this.getDataWithFilter_UC1.Location = new System.Drawing.Point(13, 285);
            this.getDataWithFilter_UC1.Name = "getDataWithFilter_UC1";
            this.getDataWithFilter_UC1.Size = new System.Drawing.Size(1342, 300);
            this.getDataWithFilter_UC1.TabIndex = 4;
            this.getDataWithFilter_UC1.Load += new System.EventHandler(this.getDataWithFilter_UC1_Load);
            // 
            // Frm_People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 597);
            this.Controls.Add(this.getDataWithFilter_UC1);
            this.Controls.Add(this.Pic_FormImageTitle);
            this.Controls.Add(this.Label_FormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_People";
            this.Text = "People_Form";
            this.Load += new System.EventHandler(this.People_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormImageTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_FormTitle;
        private System.Windows.Forms.PictureBox Pic_FormImageTitle;
        private User_Controls.UserControl_GetPersonDataWithFilter getDataWithFilter_UC1;
    }
}