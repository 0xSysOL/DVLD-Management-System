namespace DVLD.Sub_Forms.People_Forms
{
    partial class Frm_Add_Edit_People
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
            this.Label_Variable_PersonID = new System.Windows.Forms.Label();
            this.Label_Const_PersonID = new System.Windows.Forms.Label();
            this.Label_FormTitle = new System.Windows.Forms.Label();
            this.UC_AddEditPerson = new DVLD.User_Controls.People_User_Control.UC_AddEditPerson();
            this.SuspendLayout();
            // 
            // Label_Variable_PersonID
            // 
            this.Label_Variable_PersonID.AutoSize = true;
            this.Label_Variable_PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_PersonID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Variable_PersonID.Location = new System.Drawing.Point(115, 116);
            this.Label_Variable_PersonID.Name = "Label_Variable_PersonID";
            this.Label_Variable_PersonID.Size = new System.Drawing.Size(79, 16);
            this.Label_Variable_PersonID.TabIndex = 14;
            this.Label_Variable_PersonID.Text = "........................";
            // 
            // Label_Const_PersonID
            // 
            this.Label_Const_PersonID.AutoSize = true;
            this.Label_Const_PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_PersonID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Const_PersonID.Location = new System.Drawing.Point(30, 116);
            this.Label_Const_PersonID.Name = "Label_Const_PersonID";
            this.Label_Const_PersonID.Size = new System.Drawing.Size(69, 16);
            this.Label_Const_PersonID.TabIndex = 13;
            this.Label_Const_PersonID.Text = "Person ID:";
            // 
            // Label_FormTitle
            // 
            this.Label_FormTitle.AutoSize = true;
            this.Label_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormTitle.ForeColor = System.Drawing.Color.Red;
            this.Label_FormTitle.Location = new System.Drawing.Point(333, 17);
            this.Label_FormTitle.Name = "Label_FormTitle";
            this.Label_FormTitle.Size = new System.Drawing.Size(195, 29);
            this.Label_FormTitle.TabIndex = 53;
            this.Label_FormTitle.Text = "Add New Person";
            // 
            // UC_AddEditPerson
            // 
            this.UC_AddEditPerson.Location = new System.Drawing.Point(4, 116);
            this.UC_AddEditPerson.Name = "UC_AddEditPerson";
            this.UC_AddEditPerson.Size = new System.Drawing.Size(877, 301);
            this.UC_AddEditPerson.TabIndex = 0;
            this.UC_AddEditPerson.NeedImage += new System.Action<bool>(this.UC_AddEditPerson_NeedImage);
            this.UC_AddEditPerson.IsNationalNoExists += new System.Action<string>(this.uC_AddEditPerson1_IsNationalNoExists);
            this.UC_AddEditPerson.SaveDate += new System.Action<bool>(this.UC_AddEditPerson_SaveData);
            this.UC_AddEditPerson.SendMessageToClose += new System.Action(this.UC_AddEditPerson_SendMessageToClose);
            this.UC_AddEditPerson.Load += new System.EventHandler(this.uC_AddEditPerson1_Load);
            // 
            // Frm_Add_Edit_People
            // 
            this.ClientSize = new System.Drawing.Size(893, 429);
            this.Controls.Add(this.Label_FormTitle);
            this.Controls.Add(this.Label_Variable_PersonID);
            this.Controls.Add(this.Label_Const_PersonID);
            this.Controls.Add(this.UC_AddEditPerson);
            this.Name = "Frm_Add_Edit_People";
            this.Text = "Add or Edit Person";
            this.Load += new System.EventHandler(this.Frm_Add_Edit_People_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label Label_Variable_ID;
        //private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.Label Label_Const_PersonID;
        //private System.Windows.Forms.Label Label_FormTitle;
        private User_Controls.People_User_Control.UC_AddEditPerson UC_AddEditPerson;
        private System.Windows.Forms.Label Label_Variable_PersonID;
        private System.Windows.Forms.Label Label_Const_PersonID;
        private System.Windows.Forms.Label Label_FormTitle;
    }
}