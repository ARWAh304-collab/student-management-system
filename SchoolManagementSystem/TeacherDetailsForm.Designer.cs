namespace SchoolManagementSystem
{
    partial class AddTeacherForm
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
            lblTeacherFormTitle = new Label();
            txtTeacherName = new Label();
            txtEmail = new Label();
            txtPhone = new Label();
            txtAddress = new Label();
            txtDepartment = new Label();
            txtSubject = new Label();
            picTeacherPhoto = new PictureBox();
            btnUploadPhoto = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            txtNewAddress = new TextBox();
            txtNewTeacherName = new TextBox();
            txtNewSubject = new TextBox();
            txtNewEmail = new TextBox();
            txtNewPhone = new TextBox();
            txtNewDepartment = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picTeacherPhoto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTeacherFormTitle
            // 
            lblTeacherFormTitle.AutoSize = true;
            lblTeacherFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherFormTitle.ForeColor = Color.White;
            lblTeacherFormTitle.Location = new Point(226, 22);
            lblTeacherFormTitle.Name = "lblTeacherFormTitle";
            lblTeacherFormTitle.Size = new Size(178, 28);
            lblTeacherFormTitle.TabIndex = 0;
            lblTeacherFormTitle.Text = "Add New Teacher";
            // 
            // txtTeacherName
            // 
            txtTeacherName.AutoSize = true;
            txtTeacherName.ForeColor = Color.DarkGreen;
            txtTeacherName.Location = new Point(58, 203);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(104, 20);
            txtTeacherName.TabIndex = 1;
            txtTeacherName.Text = "Teacher Name";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.ForeColor = Color.DarkGreen;
            txtEmail.Location = new Point(58, 315);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(46, 20);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.AutoSize = true;
            txtPhone.ForeColor = Color.DarkGreen;
            txtPhone.Location = new Point(416, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(108, 20);
            txtPhone.TabIndex = 3;
            txtPhone.Text = "Phone Number";
            // 
            // txtAddress
            // 
            txtAddress.AutoSize = true;
            txtAddress.ForeColor = Color.DarkGreen;
            txtAddress.Location = new Point(58, 422);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(62, 20);
            txtAddress.TabIndex = 4;
            txtAddress.Text = "Address";
            // 
            // txtDepartment
            // 
            txtDepartment.AutoSize = true;
            txtDepartment.ForeColor = Color.DarkGreen;
            txtDepartment.Location = new Point(416, 422);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(89, 20);
            txtDepartment.TabIndex = 5;
            txtDepartment.Text = "Department";
            // 
            // txtSubject
            // 
            txtSubject.AutoSize = true;
            txtSubject.ForeColor = Color.DarkGreen;
            txtSubject.Location = new Point(416, 332);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(58, 20);
            txtSubject.TabIndex = 6;
            txtSubject.Text = "Subject";
            // 
            // picTeacherPhoto
            // 
            picTeacherPhoto.BorderStyle = BorderStyle.FixedSingle;
            picTeacherPhoto.Location = new Point(126, 103);
            picTeacherPhoto.Name = "picTeacherPhoto";
            picTeacherPhoto.Size = new Size(125, 62);
            picTeacherPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picTeacherPhoto.TabIndex = 7;
            picTeacherPhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new Point(398, 119);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(127, 29);
            btnUploadPhoto.TabIndex = 8;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 60, 142);
            btnSave.Location = new Point(283, 551);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(46, 158, 79);
            btnCancel.Location = new Point(502, 551);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtNewAddress
            // 
            txtNewAddress.Location = new Point(58, 468);
            txtNewAddress.Name = "txtNewAddress";
            txtNewAddress.Size = new Size(208, 27);
            txtNewAddress.TabIndex = 11;
            // 
            // txtNewTeacherName
            // 
            txtNewTeacherName.Location = new Point(58, 241);
            txtNewTeacherName.Name = "txtNewTeacherName";
            txtNewTeacherName.Size = new Size(208, 27);
            txtNewTeacherName.TabIndex = 12;
            // 
            // txtNewSubject
            // 
            txtNewSubject.Location = new Point(398, 358);
            txtNewSubject.Name = "txtNewSubject";
            txtNewSubject.Size = new Size(198, 27);
            txtNewSubject.TabIndex = 13;
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(58, 358);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(208, 27);
            txtNewEmail.TabIndex = 14;
            // 
            // txtNewPhone
            // 
            txtNewPhone.Location = new Point(398, 241);
            txtNewPhone.Name = "txtNewPhone";
            txtNewPhone.Size = new Size(198, 27);
            txtNewPhone.TabIndex = 15;
            // 
            // txtNewDepartment
            // 
            txtNewDepartment.Location = new Point(398, 468);
            txtNewDepartment.Name = "txtNewDepartment";
            txtNewDepartment.Size = new Size(198, 27);
            txtNewDepartment.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 60, 142);
            panel1.Controls.Add(lblTeacherFormTitle);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 72);
            panel1.TabIndex = 17;
            // 
            // AddTeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(632, 603);
            Controls.Add(panel1);
            Controls.Add(txtNewDepartment);
            Controls.Add(txtNewPhone);
            Controls.Add(txtNewEmail);
            Controls.Add(txtNewSubject);
            Controls.Add(txtNewTeacherName);
            Controls.Add(txtNewAddress);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnUploadPhoto);
            Controls.Add(picTeacherPhoto);
            Controls.Add(txtSubject);
            Controls.Add(txtDepartment);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtTeacherName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddTeacherForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Teacher";
            Load += AddTeacherForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)picTeacherPhoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTeacherFormTitle;
        private Label txtTeacherName;
        private Label txtEmail;
        private Label txtPhone;
        private Label txtAddress;
        private Label txtDepartment;
        private Label txtSubject;
        private PictureBox picTeacherPhoto;
        private Button btnUploadPhoto;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtNewAddress;
        private TextBox txtNewTeacherName;
        private TextBox txtNewSubject;
        private TextBox txtNewEmail;
        private TextBox txtNewPhone;
        private TextBox txtNewDepartment;
        private Panel panel1;
    }
}