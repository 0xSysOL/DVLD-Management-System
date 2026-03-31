namespace DVLD.Sub_Forms.Application.ManageAppTypes
{
    partial class Frm_EditAppTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditAppTypes));
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Const_ID = new System.Windows.Forms.Label();
            this.Label_Const_Title = new System.Windows.Forms.Label();
            this.Label_Const_Fees = new System.Windows.Forms.Label();
            this.Label_Variable_ID = new System.Windows.Forms.Label();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.TB_Fees = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Application Types";
            // 
            // Label_Const_ID
            // 
            this.Label_Const_ID.AutoSize = true;
            this.Label_Const_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_ID.Location = new System.Drawing.Point(37, 62);
            this.Label_Const_ID.Name = "Label_Const_ID";
            this.Label_Const_ID.Size = new System.Drawing.Size(32, 21);
            this.Label_Const_ID.TabIndex = 6;
            this.Label_Const_ID.Text = "ID: ";
            // 
            // Label_Const_Title
            // 
            this.Label_Const_Title.AutoSize = true;
            this.Label_Const_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_Title.Location = new System.Drawing.Point(27, 100);
            this.Label_Const_Title.Name = "Label_Const_Title";
            this.Label_Const_Title.Size = new System.Drawing.Size(46, 21);
            this.Label_Const_Title.TabIndex = 7;
            this.Label_Const_Title.Text = "Title: ";
            // 
            // Label_Const_Fees
            // 
            this.Label_Const_Fees.AutoSize = true;
            this.Label_Const_Fees.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_Fees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Const_Fees.Location = new System.Drawing.Point(27, 138);
            this.Label_Const_Fees.Name = "Label_Const_Fees";
            this.Label_Const_Fees.Size = new System.Drawing.Size(48, 21);
            this.Label_Const_Fees.TabIndex = 8;
            this.Label_Const_Fees.Text = "Fees: ";
            // 
            // Label_Variable_ID
            // 
            this.Label_Variable_ID.AutoSize = true;
            this.Label_Variable_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Variable_ID.Location = new System.Drawing.Point(75, 62);
            this.Label_Variable_ID.Name = "Label_Variable_ID";
            this.Label_Variable_ID.Size = new System.Drawing.Size(66, 21);
            this.Label_Variable_ID.TabIndex = 9;
            this.Label_Variable_ID.Text = "Nathing";
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(79, 101);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(164, 20);
            this.TB_Title.TabIndex = 10;
            // 
            // TB_Fees
            // 
            this.TB_Fees.Location = new System.Drawing.Point(79, 139);
            this.TB_Fees.Name = "TB_Fees";
            this.TB_Fees.Size = new System.Drawing.Size(164, 20);
            this.TB_Fees.TabIndex = 11;
            this.TB_Fees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Fees_KeyPress);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(233, 177);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 12;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(152, 177);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 13;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // Frm_EditAppTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 212);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.TB_Fees);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.Label_Variable_ID);
            this.Controls.Add(this.Label_Const_Fees);
            this.Controls.Add(this.Label_Const_Title);
            this.Controls.Add(this.Label_Const_ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_EditAppTypes";
            this.Text = "Update Application Types";
            this.Load += new System.EventHandler(this.Frm_EditAppTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Const_ID;
        private System.Windows.Forms.Label Label_Const_Title;
        private System.Windows.Forms.Label Label_Const_Fees;
        private System.Windows.Forms.Label Label_Variable_ID;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.TextBox TB_Fees;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}