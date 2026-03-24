namespace DVLD.User_Controls
{
    partial class UC_Filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Filter));
            this.ComboBox_YesNo = new System.Windows.Forms.ComboBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.ComboBOX = new System.Windows.Forms.ComboBox();
            this.Label_FilterBy = new System.Windows.Forms.Label();
            this.Pic_SearchForPerson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_SearchForPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_YesNo
            // 
            this.ComboBox_YesNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_YesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_YesNo.FormattingEnabled = true;
            this.ComboBox_YesNo.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.ComboBox_YesNo.Location = new System.Drawing.Point(218, 12);
            this.ComboBox_YesNo.Name = "ComboBox_YesNo";
            this.ComboBox_YesNo.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_YesNo.TabIndex = 13;
            this.ComboBox_YesNo.Visible = false;
            this.ComboBox_YesNo.SelectedIndexChanged += new System.EventHandler(this.ComboBox_YesNo_SelectedIndexChanged);
            // 
            // TB_Search
            // 
            this.TB_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(218, 12);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(100, 22);
            this.TB_Search.TabIndex = 12;
            this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            this.TB_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Search_KeyPress);
            // 
            // ComboBOX
            // 
            this.ComboBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBOX.FormattingEnabled = true;
            this.ComboBOX.Location = new System.Drawing.Point(91, 12);
            this.ComboBOX.Name = "ComboBOX";
            this.ComboBOX.Size = new System.Drawing.Size(121, 21);
            this.ComboBOX.TabIndex = 11;
            this.ComboBOX.SelectedIndexChanged += new System.EventHandler(this.ComboBOX_SelectedIndexChanged);
            // 
            // Label_FilterBy
            // 
            this.Label_FilterBy.AutoSize = true;
            this.Label_FilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FilterBy.Location = new System.Drawing.Point(19, 13);
            this.Label_FilterBy.Name = "Label_FilterBy";
            this.Label_FilterBy.Size = new System.Drawing.Size(66, 20);
            this.Label_FilterBy.TabIndex = 10;
            this.Label_FilterBy.Text = "Filter By";
            // 
            // Pic_SearchForPerson
            // 
            this.Pic_SearchForPerson.Image = ((System.Drawing.Image)(resources.GetObject("Pic_SearchForPerson.Image")));
            this.Pic_SearchForPerson.Location = new System.Drawing.Point(324, 12);
            this.Pic_SearchForPerson.Name = "Pic_SearchForPerson";
            this.Pic_SearchForPerson.Size = new System.Drawing.Size(39, 26);
            this.Pic_SearchForPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_SearchForPerson.TabIndex = 14;
            this.Pic_SearchForPerson.TabStop = false;
            this.Pic_SearchForPerson.Visible = false;
            this.Pic_SearchForPerson.Click += new System.EventHandler(this.Pic_SearchForPerson_Click);
            // 
            // UC_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pic_SearchForPerson);
            this.Controls.Add(this.ComboBox_YesNo);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.ComboBOX);
            this.Controls.Add(this.Label_FilterBy);
            this.Name = "UC_Filter";
            this.Size = new System.Drawing.Size(481, 45);
            this.Load += new System.EventHandler(this.UC_Filter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_SearchForPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_YesNo;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.ComboBox ComboBOX;
        private System.Windows.Forms.Label Label_FilterBy;
        private System.Windows.Forms.PictureBox Pic_SearchForPerson;
    }
}
