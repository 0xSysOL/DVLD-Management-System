namespace DVLD.Sub_Forms
{
    partial class Frm_AddEditPerson_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddEditPerson_));
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.Label_Const_PersonID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_Edit_Person_UC = new DVLD.User_Controls.UserControl__Add_Edit_Person();
            this.Label_Variable_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.AutoSize = true;
            this.Label_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.ForeColor = System.Drawing.Color.Red;
            this.Label_FormTitle.Location = new System.Drawing.Point(347, 38);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(195, 29);
            this.Label_FormTitle.TabIndex = 0;
            this.Label_FormTitle.Text = "Add New Person";
            // 
            // Label_Const_PersonID
            // 
            this.Label_Const_PersonID.AutoSize = true;
            this.Label_Const_PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_PersonID.Location = new System.Drawing.Point(59, 85);
            this.Label_Const_PersonID.Name = "Label_Const_PersonID";
            this.Label_Const_PersonID.Size = new System.Drawing.Size(69, 16);
            this.Label_Const_PersonID.TabIndex = 2;
            this.Label_Const_PersonID.Text = "Person ID:";
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::DVLD.Properties.Resources.id1;
            this.pictureBox1.Location = new System.Drawing.Point(32, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // add_Edit_Person_UC
            // 
            this.add_Edit_Person_UC.Location = new System.Drawing.Point(12, 107);
            this.add_Edit_Person_UC.Name = "add_Edit_Person_UC";
            this.add_Edit_Person_UC.Size = new System.Drawing.Size(876, 294);
            this.add_Edit_Person_UC.TabIndex = 1;
            this.add_Edit_Person_UC.Load += new System.EventHandler(this.Add_Edit_Person1_Load);
            // 
            // Label_Variable_ID
            // 
            this.Label_Variable_ID.AutoSize = true;
            this.Label_Variable_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_ID.Location = new System.Drawing.Point(134, 85);
            this.Label_Variable_ID.Name = "Label_Variable_ID";
            this.Label_Variable_ID.Size = new System.Drawing.Size(0, 16);
            this.Label_Variable_ID.TabIndex = 4;
            // 
            // Frm_AddEditPerson_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 435);
            this.Controls.Add(this.Label_Variable_ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label_Const_PersonID);
            this.Controls.Add(this.add_Edit_Person_UC);
            this.Controls.Add(this.Label_FormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AddEditPerson_";
            this.Text = "Add / Edit Person Info";
            this.Load += new System.EventHandler(this.Frm_AddEditPerson__Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_FormTitle;
        private User_Controls.UserControl__Add_Edit_Person add_Edit_Person_UC;
        private System.Windows.Forms.Label Label_Const_PersonID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Variable_ID;
    }
}