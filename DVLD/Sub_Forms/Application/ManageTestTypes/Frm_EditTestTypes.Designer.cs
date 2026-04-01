namespace DVLD.Sub_Forms.Application.ManageTestTypes
{
    partial class Frm_EditTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditTestTypes));
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.TB_Fees = new System.Windows.Forms.TextBox();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.Label_Variable_ID = new System.Windows.Forms.Label();
            this.Label_Const_Fees = new System.Windows.Forms.Label();
            this.Label_Const_Title = new System.Windows.Forms.Label();
            this.Label_Const_ID = new System.Windows.Forms.Label();
            this.Label_Const_FormTitle = new System.Windows.Forms.Label();
            this.TB_Descriptiion = new System.Windows.Forms.TextBox();
            this.Label_Const_Description = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(181, 230);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 22;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(262, 230);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 21;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // TB_Fees
            // 
            this.TB_Fees.Location = new System.Drawing.Point(108, 192);
            this.TB_Fees.Multiline = true;
            this.TB_Fees.Name = "TB_Fees";
            this.TB_Fees.Size = new System.Drawing.Size(164, 20);
            this.TB_Fees.TabIndex = 20;
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(108, 103);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(164, 20);
            this.TB_Title.TabIndex = 19;
            // 
            // Label_Variable_ID
            // 
            this.Label_Variable_ID.AutoSize = true;
            this.Label_Variable_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Variable_ID.Location = new System.Drawing.Point(104, 64);
            this.Label_Variable_ID.Name = "Label_Variable_ID";
            this.Label_Variable_ID.Size = new System.Drawing.Size(66, 21);
            this.Label_Variable_ID.TabIndex = 18;
            this.Label_Variable_ID.Text = "Nathing";
            // 
            // Label_Const_Fees
            // 
            this.Label_Const_Fees.AutoSize = true;
            this.Label_Const_Fees.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Fees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_Fees.Location = new System.Drawing.Point(56, 191);
            this.Label_Const_Fees.Name = "Label_Const_Fees";
            this.Label_Const_Fees.Size = new System.Drawing.Size(48, 21);
            this.Label_Const_Fees.TabIndex = 17;
            this.Label_Const_Fees.Text = "Fees: ";
            // 
            // Label_Const_Title
            // 
            this.Label_Const_Title.AutoSize = true;
            this.Label_Const_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_Title.Location = new System.Drawing.Point(56, 102);
            this.Label_Const_Title.Name = "Label_Const_Title";
            this.Label_Const_Title.Size = new System.Drawing.Size(46, 21);
            this.Label_Const_Title.TabIndex = 16;
            this.Label_Const_Title.Text = "Title: ";
            // 
            // Label_Const_ID
            // 
            this.Label_Const_ID.AutoSize = true;
            this.Label_Const_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_ID.Location = new System.Drawing.Point(66, 64);
            this.Label_Const_ID.Name = "Label_Const_ID";
            this.Label_Const_ID.Size = new System.Drawing.Size(32, 21);
            this.Label_Const_ID.TabIndex = 15;
            this.Label_Const_ID.Text = "ID: ";
            // 
            // Label_Const_FormTitle
            // 
            this.Label_Const_FormTitle.AutoSize = true;
            this.Label_Const_FormTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_FormTitle.ForeColor = System.Drawing.Color.Red;
            this.Label_Const_FormTitle.Location = new System.Drawing.Point(80, 23);
            this.Label_Const_FormTitle.Name = "Label_Const_FormTitle";
            this.Label_Const_FormTitle.Size = new System.Drawing.Size(220, 30);
            this.Label_Const_FormTitle.TabIndex = 14;
            this.Label_Const_FormTitle.Text = "Manage Test Types";
            // 
            // TB_Descriptiion
            // 
            this.TB_Descriptiion.Location = new System.Drawing.Point(108, 129);
            this.TB_Descriptiion.Multiline = true;
            this.TB_Descriptiion.Name = "TB_Descriptiion";
            this.TB_Descriptiion.Size = new System.Drawing.Size(192, 57);
            this.TB_Descriptiion.TabIndex = 24;
            // 
            // Label_Const_Description
            // 
            this.Label_Const_Description.AutoSize = true;
            this.Label_Const_Description.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Description.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_Description.Location = new System.Drawing.Point(13, 128);
            this.Label_Const_Description.Name = "Label_Const_Description";
            this.Label_Const_Description.Size = new System.Drawing.Size(92, 21);
            this.Label_Const_Description.TabIndex = 23;
            this.Label_Const_Description.Text = "Description:";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // Frm_EditTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 258);
            this.Controls.Add(this.TB_Descriptiion);
            this.Controls.Add(this.Label_Const_Description);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.TB_Fees);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.Label_Variable_ID);
            this.Controls.Add(this.Label_Const_Fees);
            this.Controls.Add(this.Label_Const_Title);
            this.Controls.Add(this.Label_Const_ID);
            this.Controls.Add(this.Label_Const_FormTitle);
            this.Name = "Frm_EditTestTypes";
            this.Text = "Frm_EditTestTypes";
            this.Load += new System.EventHandler(this.Frm_EditTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox TB_Fees;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label Label_Variable_ID;
        private System.Windows.Forms.Label Label_Const_Fees;
        private System.Windows.Forms.Label Label_Const_Title;
        private System.Windows.Forms.Label Label_Const_ID;
        private System.Windows.Forms.Label Label_Const_FormTitle;
        private System.Windows.Forms.TextBox TB_Descriptiion;
        private System.Windows.Forms.Label Label_Const_Description;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}