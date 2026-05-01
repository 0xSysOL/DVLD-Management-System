namespace DVLD.Sub_Forms.Application.Schedule_Tests
{
    partial class Frm_Schedule_TestsAppointments
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
            this.Label_Const_DGV_Title = new System.Windows.Forms.Label();
            this._DataGridView = new System.Windows.Forms.DataGridView();
            this.Label_Variable_FormTitle = new System.Windows.Forms.Label();
            this.Pic_FormPicture = new System.Windows.Forms.PictureBox();
            this.Pic_AddNewAppointment = new System.Windows.Forms.PictureBox();
            this.UC_DrivingLicenseApplication_Info = new DVLD.User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_DrivingLicenseApplication_Info();
            this.UC_ApplicationBasic_Info = new DVLD.User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_ApplicationBasic_Info();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_AddNewAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Const_DGV_Title
            // 
            this.Label_Const_DGV_Title.AutoSize = true;
            this.Label_Const_DGV_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Const_DGV_Title.Location = new System.Drawing.Point(37, 568);
            this.Label_Const_DGV_Title.Name = "Label_Const_DGV_Title";
            this.Label_Const_DGV_Title.Size = new System.Drawing.Size(98, 18);
            this.Label_Const_DGV_Title.TabIndex = 2;
            this.Label_Const_DGV_Title.Text = "Appointment: ";
            // 
            // _DataGridView
            // 
            this._DataGridView.AllowUserToAddRows = false;
            this._DataGridView.AllowUserToDeleteRows = false;
            this._DataGridView.AllowUserToOrderColumns = true;
            this._DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGridView.Location = new System.Drawing.Point(12, 599);
            this._DataGridView.Name = "_DataGridView";
            this._DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._DataGridView.Size = new System.Drawing.Size(776, 181);
            this._DataGridView.TabIndex = 5;
            // 
            // Label_Variable_FormTitle
            // 
            this.Label_Variable_FormTitle.AutoSize = true;
            this.Label_Variable_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Variable_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Variable_FormTitle.Location = new System.Drawing.Point(206, 107);
            this.Label_Variable_FormTitle.Name = "Label_Variable_FormTitle";
            this.Label_Variable_FormTitle.Size = new System.Drawing.Size(348, 31);
            this.Label_Variable_FormTitle.TabIndex = 21;
            this.Label_Variable_FormTitle.Text = "Unknown Test Appointment";
            // 
            // Pic_FormPicture
            // 
            this.Pic_FormPicture.Image = global::DVLD.Properties.Resources.test;
            this.Pic_FormPicture.Location = new System.Drawing.Point(303, 12);
            this.Pic_FormPicture.Name = "Pic_FormPicture";
            this.Pic_FormPicture.Size = new System.Drawing.Size(165, 76);
            this.Pic_FormPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_FormPicture.TabIndex = 20;
            this.Pic_FormPicture.TabStop = false;
            // 
            // Pic_AddNewAppointment
            // 
            this.Pic_AddNewAppointment.Image = global::DVLD.Properties.Resources.new_document;
            this.Pic_AddNewAppointment.Location = new System.Drawing.Point(735, 543);
            this.Pic_AddNewAppointment.Name = "Pic_AddNewAppointment";
            this.Pic_AddNewAppointment.Size = new System.Drawing.Size(53, 50);
            this.Pic_AddNewAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_AddNewAppointment.TabIndex = 19;
            this.Pic_AddNewAppointment.TabStop = false;
            this.Pic_AddNewAppointment.Click += new System.EventHandler(this.Pic_AddNewAppointment_Click);
            // 
            // UC_DrivingLicenseApplication_Info
            // 
            this.UC_DrivingLicenseApplication_Info.Location = new System.Drawing.Point(12, 169);
            this.UC_DrivingLicenseApplication_Info.Name = "UC_DrivingLicenseApplication_Info";
            this.UC_DrivingLicenseApplication_Info.Size = new System.Drawing.Size(777, 130);
            this.UC_DrivingLicenseApplication_Info.TabIndex = 1;
            this.UC_DrivingLicenseApplication_Info.Load += new System.EventHandler(this.UC_DrivingLicenseApplication_Info_Load);
            // 
            // UC_ApplicationBasic_Info
            // 
            this.UC_ApplicationBasic_Info.Location = new System.Drawing.Point(24, 323);
            this.UC_ApplicationBasic_Info.Name = "UC_ApplicationBasic_Info";
            this.UC_ApplicationBasic_Info.Size = new System.Drawing.Size(764, 214);
            this.UC_ApplicationBasic_Info.TabIndex = 0;
            this.UC_ApplicationBasic_Info.Load += new System.EventHandler(this.UC_ApplicationBasic_Info_Load);
            // 
            // Frm_Schedule_TestsAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 829);
            this.Controls.Add(this.Label_Variable_FormTitle);
            this.Controls.Add(this.Pic_FormPicture);
            this.Controls.Add(this.Pic_AddNewAppointment);
            this.Controls.Add(this._DataGridView);
            this.Controls.Add(this.Label_Const_DGV_Title);
            this.Controls.Add(this.UC_DrivingLicenseApplication_Info);
            this.Controls.Add(this.UC_ApplicationBasic_Info);
            this.Name = "Frm_Schedule_TestsAppointments";
            this.Text = "Frm_Schedule_TestsAppointments";
            this.Load += new System.EventHandler(this.Frm_Schedule_TestsAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FormPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_AddNewAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_ApplicationBasic_Info UC_ApplicationBasic_Info;
        private User_Controls.Sechdule_Tests.Vision_Test_Appointment.UC_DrivingLicenseApplication_Info UC_DrivingLicenseApplication_Info;
        private System.Windows.Forms.Label Label_Const_DGV_Title;
        private System.Windows.Forms.DataGridView _DataGridView;
        private System.Windows.Forms.PictureBox Pic_AddNewAppointment;
        private System.Windows.Forms.PictureBox Pic_FormPicture;
        private System.Windows.Forms.Label Label_Variable_FormTitle;
    }
}