namespace DVLD.User_Controls
{
    partial class UC_LicenseFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LicenseFilter));
            this.Pic_SearchForPerson = new System.Windows.Forms.PictureBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.Label_Const_LicenseID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_SearchForPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_SearchForPerson
            // 
            this.Pic_SearchForPerson.Image = ((System.Drawing.Image)(resources.GetObject("Pic_SearchForPerson.Image")));
            this.Pic_SearchForPerson.Location = new System.Drawing.Point(217, 21);
            this.Pic_SearchForPerson.Name = "Pic_SearchForPerson";
            this.Pic_SearchForPerson.Size = new System.Drawing.Size(39, 26);
            this.Pic_SearchForPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_SearchForPerson.TabIndex = 19;
            this.Pic_SearchForPerson.TabStop = false;
            this.Pic_SearchForPerson.Click += new System.EventHandler(this.Pic_SearchForPerson_Click);
            // 
            // TB_Search
            // 
            this.TB_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(111, 21);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(100, 22);
            this.TB_Search.TabIndex = 17;
            this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            this.TB_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Search_KeyPress);
            // 
            // Label_Const_LicenseID
            // 
            this.Label_Const_LicenseID.AutoSize = true;
            this.Label_Const_LicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_LicenseID.Location = new System.Drawing.Point(12, 23);
            this.Label_Const_LicenseID.Name = "Label_Const_LicenseID";
            this.Label_Const_LicenseID.Size = new System.Drawing.Size(93, 20);
            this.Label_Const_LicenseID.TabIndex = 15;
            this.Label_Const_LicenseID.Text = "License ID: ";
            // 
            // UC_LicenseFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pic_SearchForPerson);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.Label_Const_LicenseID);
            this.Name = "UC_LicenseFilter";
            this.Size = new System.Drawing.Size(271, 68);
            this.Load += new System.EventHandler(this.UC_LicenseFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_SearchForPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_SearchForPerson;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Label Label_Const_LicenseID;
    }
}
